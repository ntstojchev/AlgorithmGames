using CreateMapTool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Robot
{
	public partial class RobotForm : Form
	{
		private Map _map;
		private Graphics _g;
		private int _tryCount;

		public RobotForm(string filePath)
		{
			InitializeComponent();

			DeserializeMap(filePath);
			_tryCount = 5;
			lbl_TryCount.Text = _tryCount.ToString();
		}

		private void DeserializeMap(string filePath)
		{
			Map map = null;
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

		private string GetFileName(string fileName)
		{
			return fileName.Split('.')[0];
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

		private void Robot_Shown(object sender, EventArgs e)
		{
			_g = panelMap.CreateGraphics();
			_map.DrawMap(_g);

			FillListView();
			_map.RobotCurrentCell = _map.RobotStartingCell;
		}

		private void buttonInsert_Click(object sender, EventArgs e)
		{
			Insert();
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			Delete();
		}

		private void buttonCheckSolution_Click(object sender, EventArgs e)
		{
			CheckSolution();
		}

		private void buttonSolution_Click(object sender, EventArgs e)
		{
			try
			{
				if (CheckSolution())
				{
					MessageBox.Show("Браво! Роботът стигна успешно до целта.");
					buttonSolution.Enabled = false;
					listViewPickedActions.Enabled = false;
					buttonClearSolution.Enabled = false;
					buttonInsert.Enabled = false;
					buttonCheckSolution.Enabled = false;
					buttonDelete.Enabled = false;
					listViewActions.Enabled = false;
				}
				else
				{
					MessageBox.Show("Можеш да се справиш, опитай отново!");

					_tryCount = 5;
					lbl_TryCount.Text = _tryCount.ToString();
					buttonCheckSolution.Enabled = true;
					listViewPickedActions.Items.Clear();

					_map.RobotCurrentCell = _map.RobotStartingCell;
					_map.DrawMap(_g, true);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, ex.Message, "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private bool CheckSolution()
		{
			try
			{
				if (listViewPickedActions.Items.Count > 0)
				{
					_map.RobotCurrentCell = _map.RobotStartingCell;
					bool goalReached = false;

					foreach (ListViewItem item in listViewPickedActions.Items)
					{
						Cell currentCell = _map.RobotCurrentCell;
						Cell nextCell;

						switch (item.ImageKey)
						{
							case "Нагоре":
								nextCell = _map.GetCell(currentCell.Column, currentCell.Row - 1);
								break;
							case "Надолу":
								nextCell = _map.GetCell(currentCell.Column, currentCell.Row + 1);
								break;
							case "Наляво":
								nextCell = _map.GetCell(currentCell.Column - 1, currentCell.Row);
								break;
							case "Надясно":
								nextCell = _map.GetCell(currentCell.Column + 1, currentCell.Row);
								break;
							case "Скок нагоре":
								nextCell = _map.GetCell(currentCell.Column, currentCell.Row - 2);
								break;
							case "Скок надолу":
								nextCell = _map.GetCell(currentCell.Column, currentCell.Row + 2);
								break;
							case "Скок наляво":
								nextCell = _map.GetCell(currentCell.Column - 2, currentCell.Row);
								break;
							case "Скок надясно":
								nextCell = _map.GetCell(currentCell.Column + 2, currentCell.Row);
								break;
							default:
								nextCell = null;
								break;
						}

						goalReached = _map.MoveRobot(_g, currentCell, nextCell);

						Thread.Sleep(150);
					}

					DecrementCounter();
					return goalReached;
				}
				return false;
			}
			catch (Exception ex)
			{
				DecrementCounter();

				MessageBox.Show(this, ex.Message, "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		private void DecrementCounter()
		{
			_tryCount -= 1;
			lbl_TryCount.Text = _tryCount.ToString();
			if (_tryCount == 0)
				buttonCheckSolution.Enabled = false;
		}

		private void listViewActions_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			Insert();
		}

		private void listViewPickedActions_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			Delete();
		}

		private void buttonClearSolution_Click(object sender, EventArgs e)
		{
			listViewPickedActions.Items.Clear();
		}

		private void buttonSolutionHint_Click(object sender, EventArgs e)
		{
			MessageBox.Show(String.Join(Environment.NewLine, _map.MapSolution.ToArray()), "Примерно решение", MessageBoxButtons.OK, MessageBoxIcon.Question);
		}

		private void началоToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void избериДругаКартаToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Hide();

			var pickMap = new PickMap();
			if (pickMap.ShowDialog() == DialogResult.OK)
			{
				var robotForm = new RobotForm(pickMap.FilePath);
				robotForm.ShowDialog();
			}
		}

		private void хелпToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var uri = new Uri("https://www.youtube.com/watch?v=8LwA8uJRgc8");
			System.Diagnostics.Process.Start(uri.AbsoluteUri);
		}
	}
}
