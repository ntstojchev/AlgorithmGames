using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Robot
{
	public partial class PickMap : Form
	{
		public string FilePath { get; set; }

		public PickMap()
		{
			InitializeComponent();

			FillListView();
		}

		private void FillListView()
		{
			DirectoryInfo directory = new DirectoryInfo("Maps/");
			FileInfo[] files = directory.GetFiles("*.xml");

			foreach (FileInfo file in files)
			{
				var item = new ListViewItem(GetFileName(file.Name));
				item.Tag = file.FullName;

				listViewProblems.Items.Add(item);
			}
		}

		private string GetFileName(string fileName)
		{
			return fileName.Split('.')[0];
		}

		private void PickMapFromListView()
		{
			if (listViewProblems.SelectedItems.Count > 0)
			{
				string filePath = (string)listViewProblems.SelectedItems[0].Tag;

				FilePath = filePath;
				DialogResult = DialogResult.OK;
			}
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			PickMapFromListView();
		}

		private void buttonChooseProblem_Click(object sender, EventArgs e)
		{
			var fileChooser = new OpenFileDialog();
			fileChooser.Filter = "xml files (*.xml)|*.xml";

			if (fileChooser.ShowDialog() == DialogResult.OK)
			{
				FilePath = fileChooser.FileName;
				DialogResult = DialogResult.OK;
			}
		}

		private void listViewProblems_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			PickMapFromListView();
		}
	}
}
