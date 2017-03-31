using CreateExperimentTool;
using CreateMapTool;
using Experiments;
using Robot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AlgorithmGames
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		public bool IsExperimentTrainerWatched
		{
			get
			{
				return Boolean.Parse(ConfigurationManager.AppSettings["IsExperimentTrainerWatched"]);
			}
			set
			{
				ConfigurationManager.AppSettings["IsExperimentTrainerWatched"] = value.ToString();
			}
		}

		public bool IsRobotTrainerWatched
		{
			get
			{
				return Boolean.Parse(ConfigurationManager.AppSettings["IsRobotTrainerWatched"]);
			}
			set
			{
				ConfigurationManager.AppSettings["IsRobotTrainerWatched"] = value.ToString();
			}
		}

		private void OpenProblem()
		{
			if (!IsExperimentTrainerWatched)
			{
				var uri = new Uri("https://www.youtube.com/watch?v=t-46x2KafFs");
				System.Diagnostics.Process.Start(uri.AbsoluteUri);
				IsExperimentTrainerWatched = true;
			}

			var pickProblem = new PickProblem();
			if (pickProblem.ShowDialog() == DialogResult.OK)
			{
				var experiment = new ExperimentForm(pickProblem.FilePath);
				experiment.ShowDialog();
			}
		}

		private void OpenMap()
		{
			if (!IsRobotTrainerWatched)
			{
				var uri = new Uri("https://www.youtube.com/watch?v=8LwA8uJRgc8");
				System.Diagnostics.Process.Start(uri.AbsoluteUri);
				IsRobotTrainerWatched = true;
			}

			var pickMap = new PickMap();
			if (pickMap.ShowDialog() == DialogResult.OK)
			{
				var robot = new RobotForm(pickMap.FilePath);
				robot.ShowDialog();
			}
		}

		private void подредетеДействиятаНаЕкспериментаToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenProblem();
		}

		private void помогнетеНаРоботаДаСтигнеДоЦелтаToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenMap();
		}

		private void linkLabelExperiment_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			OpenProblem();
		}

		private void linkLabelRobot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			OpenMap();
		}

		private void експериментToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			PickProblem pickProblem = new PickProblem();
			if (pickProblem.ShowDialog() == DialogResult.OK)
			{
				CreateExperiment createExperiment = new CreateExperiment(pickProblem.FilePath);
				createExperiment.ShowDialog();
			}
		}

		private void картаToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			PickMap pickMap = new PickMap();
			if (pickMap.ShowDialog() == DialogResult.OK)
			{
				CreateMap createMap = new CreateMap(pickMap.FilePath);
				createMap.ShowDialog();
			}
		}

		private void експериментToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var createExperiment = new CreateExperiment();
			createExperiment.ShowDialog();
		}

		private void картаToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var createMap = new CreateMap();
			createMap.ShowDialog();
		}

		private void pictureBoxRobot_Click(object sender, EventArgs e)
		{
			OpenMap();
		}

		private void pictureBoxExperiments_Click(object sender, EventArgs e)
		{
			OpenProblem();
		}

		private void заНасToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var aboutBox = new AboutBox();
			aboutBox.ShowDialog();
		}

		private void изходToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
