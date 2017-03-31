using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Experiments
{
	public partial class AddToGroup : Form
	{
		public int Step { get; set; }

		public AddToGroup()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(textBoxStep.Text))
			{
				Step = Int32.Parse(textBoxStep.Text);

				if (Step > 0)
					DialogResult = DialogResult.OK;
				else
				{
					Step = 0;
					DialogResult = DialogResult.Cancel;
				}
			}
		}

		private void textBoxStep_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar)
			&& !char.IsDigit(e.KeyChar))
				{
					e.Handled = true;
				}
		}
	}
}
