using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CreateMapTool
{
	public partial class CreateMap : Form
	{
		private Map _map;
		private Graphics _g;

		private Cell _selectedCell;
		private bool _mouseOverMap;
		private bool _mapChanged = false;
		private bool _isMapDrawn = false;
		private bool _isMapEdit = false;

		public CreateMap()
		{
			InitializeComponent();

			comboBoxBehavior.DataSource = Enum.GetValues(typeof(CellBehavior));

			_map = new Map(50, 500);
		}

		public CreateMap(string fileName)
		{
			InitializeComponent();

			this.Text = "Редактиране на карта";
			_isMapEdit = true;

			DeserializeMap(fileName);
		}

		private void DeserializeMap(string filePath)
		{
			Map map = null;
			comboBoxBehavior.DataSource = Enum.GetValues(typeof(CellBehavior));
			XmlSerializer serializer = new XmlSerializer(typeof(Map));

			StreamReader reader = new StreamReader(filePath);
			map = (Map)serializer.Deserialize(reader);
			reader.Close();

			BinaryFormatter bf = new BinaryFormatter();
			Cell[,] cells;
			using (FileStream file = new FileStream(string.Format("{0}-Cells.dat", filePath), FileMode.Open, FileAccess.Read))
				cells = (Cell[,])bf.Deserialize(file);

			map.Cells = cells;
			_map = map;
		}

		private void FillListView()
		{
			listViewActions.LargeImageList = imageList;
			listViewPickedActions.LargeImageList = imageList;

			foreach (string key in imageList.Images.Keys)
			{
				var item = new ListViewItem(key);
				item.ImageKey = key;

				listViewActions.Items.Add(item);
			}
		}

		private void FillListViewPickedActions()
		{
			foreach (string key in _map.MapSolution)
			{
				var item = new ListViewItem(key);
				item.ImageKey = key;

				listViewPickedActions.Items.Add(item);
			}
		}

		private string GetFileName(string fileName)
		{
			return fileName.Split('.')[0];
		}

		private void SaveCell()
		{
			try
			{
				CellBehavior behavior = (CellBehavior)comboBoxBehavior.SelectedItem;

				if (_selectedCell.IsStartPosition && behavior != CellBehavior.Path)
					throw new Exception("Забранено е задаване на нещо различно от път върху стартова клетка.");

				_selectedCell.Behavior = (CellBehavior)comboBoxBehavior.SelectedItem;

				if (checkBoxStartPosition.Checked)
				{
					if (_selectedCell.Behavior == CellBehavior.Empty || _selectedCell.Behavior == CellBehavior.Wall)
						throw new Exception("Стена или празно поле не могат да бъдат стартова позиция на робота.");

					_selectedCell.IsStartPosition = true;

					if (_map.RobotStartingCell != null)
					{
						_map.RobotStartingCell.IsStartPosition = false;
						_map.SaveCell(_map.RobotStartingCell);
					}

					_map.RobotStartingCell = _selectedCell;
				}
				else
				{
					_selectedCell.IsStartPosition = false;
					_map.RobotStartingCell = null;
				}

				if (_selectedCell.Behavior == CellBehavior.EndGoal)
				{
					if (_map.EndGoal != null)
					{
						_map.EndGoal.Behavior = CellBehavior.Path;
						_map.SaveCell(_map.EndGoal);
						_map.DrawCell(_g, _map.EndGoal);
					}

					_map.EndGoal = _selectedCell;
				}

				_map.SaveCell(_selectedCell);

				if (checkBoxStartPosition.Checked)
					_map.DrawMap(_g);
				else
					_map.DrawCell(_g, _selectedCell);

				_mapChanged = true;
				_selectedCell = null;
				checkBoxStartPosition.Checked = false;
				checkBoxStartPosition.Enabled = false;
				comboBoxBehavior.Enabled = false;
				buttonSaveCell.Enabled = false;
			}
			catch (Exception ex)
			{
				_selectedCell = null;
				checkBoxStartPosition.Checked = false;
				checkBoxStartPosition.Enabled = false;
				comboBoxBehavior.Enabled = false;
				buttonSaveCell.Enabled = false;
				MessageBox.Show(this, ex.Message, "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Insert()
		{
			if (listViewActions.SelectedItems.Count > 0)
			{
				ListViewItem item = listViewActions.SelectedItems[0];
				ListViewItem clone = (ListViewItem)item.Clone();

				listViewPickedActions.Items.Add(clone);
				listViewActions.SelectedItems.Clear();
			}
		}

		private void Delete()
		{
			if (listViewPickedActions.SelectedItems.Count > 0)
			{
				ListViewItem item = listViewPickedActions.SelectedItems[0];

				listViewPickedActions.Items.Remove(item);
			}
		}

		private void panelMap_MouseClick(object sender, MouseEventArgs e)
		{
			if (_isMapDrawn)
			{
				var selectedCell = new Point(e.X, e.Y);

				Cell cell = _map.GetCell(selectedCell);
				if (cell != null)
				{
					_selectedCell = cell;
					buttonSaveCell.Enabled = true;
					comboBoxBehavior.Enabled = true;
					checkBoxStartPosition.Enabled = true;

					checkBoxStartPosition.Checked = cell.IsStartPosition;
					comboBoxBehavior.SelectedItem = cell.Behavior;
				}
			}
		}

		private void buttonDrawMap_Click(object sender, EventArgs e)
		{
			_g = panelMap.CreateGraphics();
			_map.DrawMap(_g);
			_selectedCell = null;

			FillListView();

			if (_isMapEdit)
				FillListViewPickedActions();

			_isMapDrawn = true;

			buttonDrawMap.Enabled = false;
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Сигурни ли сте?", "Изход", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
				Close();
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			try
			{
				if (!_isMapEdit)
				{
					if (!_mapChanged)
						throw new Exception("Направете карта.");
				}

				if (_map.RobotStartingCell == null)
					throw new Exception("Посочете стартова клетка на робота.");

				if (listViewPickedActions.Items.Count <= 0)
					throw new Exception("Въведете решение.");

				if (_map.EndGoal == null)
					throw new Exception("Посочете клетката, до която трябва да стигне робота.");

				var saveDialog = new SaveFileDialog();
				saveDialog.Filter = "xml files (*.xml)|*.xml";

				if (_isMapEdit)
					_map.MapSolution.Clear();

				foreach (ListViewItem item in listViewPickedActions.Items)
					_map.MapSolution.Add(item.Text);

				if (saveDialog.ShowDialog() == DialogResult.OK)
				{
					XmlSerializer x = new XmlSerializer(_map.GetType());
					x.Serialize(saveDialog.OpenFile(), _map);

					string fileName = saveDialog.FileName;
					BinaryFormatter bf = new BinaryFormatter();
					using (FileStream file = new FileStream(string.Format("{0}-Cells.dat", fileName), FileMode.Create, FileAccess.Write))
						bf.Serialize(file, _map.Cells);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, ex.Message, "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void buttonInsert_Click(object sender, EventArgs e)
		{
			Insert();
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			Delete();
		}

		private void CreateMapTool_KeyDown(object sender, KeyEventArgs e)
		{
			if (_mouseOverMap && _isMapDrawn)
			{
				int x = panelMap.PointToClient(Cursor.Position).X;
				int y = panelMap.PointToClient(Cursor.Position).Y;
				var p = new Point(x, y);

				Cell cell = _map.GetCell(p);

				if (cell != null)
				{
					_selectedCell = cell;
					switch (e.KeyCode)
					{
						case Keys.E:
							comboBoxBehavior.SelectedItem = CellBehavior.Empty;
							SaveCell();
							break;
						case Keys.G:
							comboBoxBehavior.SelectedItem = CellBehavior.EndGoal;
							SaveCell();
							break;
						case Keys.W:
							comboBoxBehavior.SelectedItem = CellBehavior.Wall;
							SaveCell();
							break;
						case Keys.P:
							comboBoxBehavior.SelectedItem = CellBehavior.Path;
							SaveCell();
							break;
					}
				}
			}
		}

		private void panelMap_MouseEnter(object sender, EventArgs e)
		{
			_mouseOverMap = true;
		}

		private void panelMap_MouseLeave(object sender, EventArgs e)
		{
			_mouseOverMap = false;
		}

		private void comboBoxBehavior_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void listViewActions_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			Insert();
		}

		private void listViewPickedActions_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			Delete();
		}

		private void checkBoxStartPosition_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void buttonSaveCell_Click(object sender, EventArgs e)
		{
			SaveCell();
		}
	}
}
