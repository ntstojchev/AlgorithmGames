using Experiments;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CreateExperimentTool
{
	public partial class CreateExperiment : Form
	{
		private ImageList _instruments;
		private int _steps;
		private Problem _problem;
		private bool _instrumentsImageListSetted = false;

		public CreateExperiment()
		{
			InitializeComponent();

			_instruments = new ImageList();
			_instruments.ImageSize = new Size(96, 96);
		}

		public CreateExperiment(string filePath)
		{
			InitializeComponent();

			this.Text = "Редактиране на експеримент";

			_instruments = new ImageList();
			_instruments.ImageSize = new Size(96, 96);

			Problem problem = null;
			XmlSerializer serializer = new XmlSerializer(typeof(Problem));

			StreamReader reader = new StreamReader(filePath);
			problem = (Problem)serializer.Deserialize(reader);
			reader.Close();

			_problem = problem;

			FillInstrumentsListView(problem);
			MakeSolutionSteps();
			FillTextBoxes();
		}

		private string GetFileName(string fileName)
		{
			return fileName.Split('.')[0];
		}

		private void FillInstrumentsListView(Problem problem)
		{
			if(!_instrumentsImageListSetted)
				_instruments = problem.GetImageList();

			listViewInstruments.LargeImageList = _instruments;
			listViewSolution.LargeImageList = _instruments;

			foreach (string key in _instruments.Images.Keys)
			{
				string name;
				if (key.Contains('$'))
					name = "";
				else
					name = key;

				var item = new ListViewItem(name);
				item.ImageKey = key;

				listViewInstruments.Items.Add(item);
			}
		}

		private void FillInstrumentsListView()
		{
			listViewInstruments.Items.Clear();

			listViewInstruments.LargeImageList = _instruments;
			listViewSolution.LargeImageList = _instruments;

			foreach (string key in _instruments.Images.Keys)
			{
				string name;
				if (key.Contains('$'))
					name = "";
				else
					name = key;

				var item = new ListViewItem(name);
				item.ImageKey = key;

				listViewInstruments.Items.Add(item);
			}
		}

		private void FillTextBoxes()
		{
			textBoxName.Text = _problem.ExperimentName;
			textBoxSteps.Text = _problem.ExperimentSteps.ToString();
			textBoxLink.Text = _problem.ExperimentLink;
			textBoxExperimentExtraInfo.Text = _problem.ExperimentExtraInfo;
		}

		private void CreateProblem()
		{
			var problem = new Problem();
			problem.ExperimentName = textBoxName.Text;
			problem.ExperimentLink = textBoxLink.Text;
			problem.ExperimentExtraInfo = textBoxExperimentExtraInfo.Text;
			problem.ExperimentSteps = _steps;

			foreach (ListViewItem item in listViewSolution.Items)
				problem.ExperimentSolution.Add(item.ImageKey);

			foreach (string key in _instruments.Images.Keys)
			{
				using (var ms = new MemoryStream())
				{
					Image image = _instruments.Images[key];
					image.Save(ms, ImageFormat.Bmp);
					byte[] array = ms.ToArray();

					problem.PictureNames.Add(key);
					problem.PicturesImageList.Add(Convert.ToBase64String(array));
				}
			}

			var saveDialog = new SaveFileDialog();
			saveDialog.Filter = "xml files (*.xml)|*.xml";

			if (saveDialog.ShowDialog() == DialogResult.OK)
			{
				XmlSerializer x = new XmlSerializer(problem.GetType());
				x.Serialize(saveDialog.OpenFile(), problem);
			}
		}

		private void Insert()
		{
			try
			{
				if (listViewInstruments.SelectedItems.Count > 0)
				{
					if (_steps != 0)
					{
						var dialog = new AddToGroup();
						if (dialog.ShowDialog() == DialogResult.OK)
						{
							ListViewItem item = listViewInstruments.SelectedItems[0];
							ListViewItem clone = (ListViewItem)item.Clone();

							clone.Group = listViewSolution.Groups[dialog.Step - 1];
							listViewSolution.Items.Add(clone);
							listViewInstruments.SelectedItems.Clear();
						}
					}
					else
						throw new Exception("Въведете брой стъпки на опита.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, "Невалидна стъпка.", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Delete()
		{
			if (listViewSolution.SelectedItems.Count > 0)
			{
				ListViewItem item = listViewSolution.SelectedItems[0];

				listViewSolution.Items.Remove(item);
			}
		}

		private void MakeSolutionSteps()
		{
			listViewSolution.Groups.Clear();

			for (int i = 0; i < _steps; i++)
			{
				var group = new ListViewGroup(string.Format("Стъпка {0}", i + 1), HorizontalAlignment.Left);
				listViewSolution.Groups.Add(group);
			}
		}

		//private void buttonOpenInstruments_Click(object sender, EventArgs e)
		//{
		//	var directoryDialog = new FolderBrowserDialog();
		//	if (directoryDialog.ShowDialog() == DialogResult.OK)
		//	{
		//		DirectoryInfo directory = new DirectoryInfo(directoryDialog.SelectedPath);
		//		FileInfo[] files = directory.GetFiles("*.bmp");

		//		foreach (FileInfo file in files)
		//		{
		//			Image image = new Bitmap(file.FullName);
		//			string fileName = GetFileName(file.Name);

		//			_instruments.Images.Add(fileName, image);
		//		}

		//		FillInstrumentsListView();
		//	}
		//}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(textBoxName.Text))
					throw new Exception("Въведете име на опита.");

				if (string.IsNullOrEmpty(textBoxLink.Text))
					throw new Exception("Въведете линк към видеото на опита.");

				if (string.IsNullOrEmpty(textBoxExperimentExtraInfo.Text))
					throw new Exception("Въведете допълнителна информация за опита.");

				if (listViewSolution.Items.Count <= 0)
					throw new Exception("Въведете решение на опита.");

				CreateProblem();
				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, ex.Message, "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Сигурни ли сте?", "Изход", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
				Close();
		}

		private void buttonInsert_Click(object sender, EventArgs e)
		{
			Insert();
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			Delete();
		}

		private void listViewInstruments_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			Insert();
		}

		private void listViewSolution_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			Delete();
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			var dialog = new OpenFileDialog();
			dialog.Filter = "bmp files (*.bmp)|*.bmp";
			dialog.Multiselect = true;

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				foreach (string fileName in dialog.FileNames)
				{
					var file = new FileInfo(fileName);

					Image image = new Bitmap(file.FullName);
					string fileSubName = GetFileName(file.Name);

					_instruments.Images.Add(fileSubName, image);
				}

				FillInstrumentsListView();
			}
		}

		private void buttonRemove_Click(object sender, EventArgs e)
		{
			if (listViewInstruments.SelectedItems.Count > 0)
			{
				ListViewItem item = listViewInstruments.SelectedItems[0];

				listViewInstruments.Items.Remove(item);
				_instruments.Images.RemoveByKey(item.ImageKey);
			}
		}

		private void textBoxSteps_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar)
			&& !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void textBoxSteps_Leave(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(textBoxSteps.Text))
			{
				_steps = Int32.Parse(textBoxSteps.Text);
			}

			MakeSolutionSteps();
		}

		private void buttonRemoveAllInstruments_Click(object sender, EventArgs e)
		{
			listViewInstruments.Items.Clear();
			_instruments.Images.Clear();
		}
	}
}
