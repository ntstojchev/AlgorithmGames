﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Robot
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			PickMap picker = new PickMap();
			if (picker.ShowDialog() == DialogResult.OK)
			{
				Application.Run(new RobotForm(picker.FilePath));
			}
		}
	}
}
