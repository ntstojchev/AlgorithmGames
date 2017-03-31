namespace Robot
{
	partial class PickMap
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBoxMaps = new System.Windows.Forms.GroupBox();
			this.listViewProblems = new System.Windows.Forms.ListView();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonChooseProblem = new System.Windows.Forms.Button();
			this.groupBoxMaps.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxMaps
			// 
			this.groupBoxMaps.Controls.Add(this.listViewProblems);
			this.groupBoxMaps.Location = new System.Drawing.Point(12, 12);
			this.groupBoxMaps.Name = "groupBoxMaps";
			this.groupBoxMaps.Size = new System.Drawing.Size(260, 378);
			this.groupBoxMaps.TabIndex = 1;
			this.groupBoxMaps.TabStop = false;
			this.groupBoxMaps.Text = "Налични карти";
			// 
			// listViewProblems
			// 
			this.listViewProblems.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewProblems.FullRowSelect = true;
			this.listViewProblems.Location = new System.Drawing.Point(3, 16);
			this.listViewProblems.MultiSelect = false;
			this.listViewProblems.Name = "listViewProblems";
			this.listViewProblems.Size = new System.Drawing.Size(254, 359);
			this.listViewProblems.TabIndex = 0;
			this.listViewProblems.UseCompatibleStateImageBehavior = false;
			this.listViewProblems.View = System.Windows.Forms.View.List;
			this.listViewProblems.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewProblems_MouseDoubleClick);
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(12, 396);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 2;
			this.buttonOK.Text = "Избери";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(93, 396);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 3;
			this.buttonCancel.Text = "Отказ";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonChooseProblem
			// 
			this.buttonChooseProblem.Location = new System.Drawing.Point(175, 396);
			this.buttonChooseProblem.Name = "buttonChooseProblem";
			this.buttonChooseProblem.Size = new System.Drawing.Size(97, 23);
			this.buttonChooseProblem.TabIndex = 4;
			this.buttonChooseProblem.Text = "Избери друг ...";
			this.buttonChooseProblem.UseVisualStyleBackColor = true;
			this.buttonChooseProblem.Click += new System.EventHandler(this.buttonChooseProblem_Click);
			// 
			// PickMap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(283, 431);
			this.Controls.Add(this.buttonChooseProblem);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.groupBoxMaps);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PickMap";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Изберете карта";
			this.groupBoxMaps.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxMaps;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonChooseProblem;
		private System.Windows.Forms.ListView listViewProblems;
	}
}