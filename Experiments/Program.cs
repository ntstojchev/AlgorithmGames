using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Experiments
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

			PickProblem picker = new PickProblem();
			if (picker.ShowDialog() == DialogResult.OK)
			{
				Application.Run(new ExperimentForm(picker.FilePath));
			}
        }
    }
}
