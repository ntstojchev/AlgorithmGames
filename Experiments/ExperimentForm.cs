using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Experiments
{
	public partial class ExperimentForm : Form
	{
		private Problem _problem;

		public ExperimentForm(string filePath)
		{
			InitializeComponent();

			Problem problem = null;
			XmlSerializer serializer = new XmlSerializer(typeof(Problem));

			StreamReader reader = new StreamReader(filePath);
			problem = (Problem)serializer.Deserialize(reader);
			reader.Close();

			_problem = problem;

			FillInstrumentsListView(problem);
			MakeSolutionSteps();
			FillLabels();
		}

		private void FillInstrumentsListView(Problem problem)
		{
			ImageList imageList = problem.GetImageList();
			listViewInstruments.LargeImageList = imageList;
			listViewSolution.LargeImageList = imageList;

			foreach (string key in imageList.Images.Keys)
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

		private void FillLabels()
		{
			this.Text = _problem.ExperimentName;

			linkLabelLink.Text = _problem.ExperimentLink;
		}

		private void Insert()
		{
			try
			{
				if (listViewInstruments.SelectedItems.Count > 0)
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

			for (int i = 0; i < _problem.ExperimentSteps; i++)
			{
				var group = new ListViewGroup(string.Format("Стъпка {0}", i + 1), HorizontalAlignment.Left);
				listViewSolution.Groups.Add(group);
			}
		}

		private void ChooseNextExperiment()
		{
			Hide();

			var pickProblem = new PickProblem();
			if (pickProblem.ShowDialog() == DialogResult.OK)
			{
				var experiment = new ExperimentForm(pickProblem.FilePath);
				experiment.ShowDialog();
			}

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

		private void buttonCleanSolutionListView_Click(object sender, EventArgs e)
		{
			listViewSolution.Items.Clear();
		}

		private void linkLabelLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(linkLabelLink.Text);
		}

		private void buttonCheckSolution_Click(object sender, EventArgs e)
		{
			try
			{
				if (listViewSolution.Items.Count == 0)
					throw new Exception("Въведете решение.");
				else if (_problem.ExperimentSolution.Count > listViewSolution.Items.Count)
					throw new Exception("Липсват елементи в решението.");
				else if (_problem.ExperimentSolution.Count < listViewSolution.Items.Count)
					throw new Exception("Решението съдържа излишни елементи.");

				for (int i = 0; i < _problem.ExperimentSolution.Count; i++)
				{
					if (listViewSolution.Items[i].ImageKey != _problem.ExperimentSolution[i])
						throw new Exception(string.Format("Има грешка в решението на стъпка номер {0}.", i + 1));
				}

				MessageBox.Show(_problem.ExperimentExtraInfo, "Правилно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ChooseNextExperiment();
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, ex.Message, "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void началоToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void избериДругЕкспериментToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ChooseNextExperiment();
		}

		private void helpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var uri = new Uri("https://www.youtube.com/watch?v=t-46x2KafFs");
			System.Diagnostics.Process.Start(uri.AbsoluteUri);
		}
	}
}
