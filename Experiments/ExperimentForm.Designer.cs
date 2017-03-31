namespace Experiments
{
    partial class ExperimentForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExperimentForm));
			this.listViewInstruments = new System.Windows.Forms.ListView();
			this.linkLabelLink = new System.Windows.Forms.LinkLabel();
			this.labelLinkStatic = new System.Windows.Forms.Label();
			this.groupBoxInstruments = new System.Windows.Forms.GroupBox();
			this.groupBoxSolution = new System.Windows.Forms.GroupBox();
			this.listViewSolution = new System.Windows.Forms.ListView();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonInsert = new System.Windows.Forms.Button();
			this.buttonCleanSolutionListView = new System.Windows.Forms.Button();
			this.buttonCheckSolution = new System.Windows.Forms.Button();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.началоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.избериДругЕкспериментToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBoxQuestion = new System.Windows.Forms.GroupBox();
			this.groupBoxInstruments.SuspendLayout();
			this.groupBoxSolution.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.groupBoxQuestion.SuspendLayout();
			this.SuspendLayout();
			// 
			// listViewInstruments
			// 
			this.listViewInstruments.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewInstruments.Location = new System.Drawing.Point(3, 16);
			this.listViewInstruments.MultiSelect = false;
			this.listViewInstruments.Name = "listViewInstruments";
			this.listViewInstruments.Size = new System.Drawing.Size(451, 533);
			this.listViewInstruments.TabIndex = 0;
			this.listViewInstruments.UseCompatibleStateImageBehavior = false;
			this.listViewInstruments.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewInstruments_MouseDoubleClick);
			// 
			// linkLabelLink
			// 
			this.linkLabelLink.AutoSize = true;
			this.linkLabelLink.Location = new System.Drawing.Point(85, 112);
			this.linkLabelLink.Name = "linkLabelLink";
			this.linkLabelLink.Size = new System.Drawing.Size(0, 13);
			this.linkLabelLink.TabIndex = 4;
			this.linkLabelLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLink_LinkClicked);
			// 
			// labelLinkStatic
			// 
			this.labelLinkStatic.AutoSize = true;
			this.labelLinkStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelLinkStatic.Location = new System.Drawing.Point(23, 108);
			this.labelLinkStatic.Name = "labelLinkStatic";
			this.labelLinkStatic.Size = new System.Drawing.Size(56, 18);
			this.labelLinkStatic.TabIndex = 1;
			this.labelLinkStatic.Text = "Видео:";
			// 
			// groupBoxInstruments
			// 
			this.groupBoxInstruments.Controls.Add(this.listViewInstruments);
			this.groupBoxInstruments.Location = new System.Drawing.Point(16, 129);
			this.groupBoxInstruments.Name = "groupBoxInstruments";
			this.groupBoxInstruments.Size = new System.Drawing.Size(457, 552);
			this.groupBoxInstruments.TabIndex = 2;
			this.groupBoxInstruments.TabStop = false;
			this.groupBoxInstruments.Text = "Инструменти";
			// 
			// groupBoxSolution
			// 
			this.groupBoxSolution.Controls.Add(this.listViewSolution);
			this.groupBoxSolution.Location = new System.Drawing.Point(534, 129);
			this.groupBoxSolution.Name = "groupBoxSolution";
			this.groupBoxSolution.Size = new System.Drawing.Size(462, 555);
			this.groupBoxSolution.TabIndex = 3;
			this.groupBoxSolution.TabStop = false;
			this.groupBoxSolution.Text = "Решение";
			// 
			// listViewSolution
			// 
			this.listViewSolution.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewSolution.Location = new System.Drawing.Point(3, 16);
			this.listViewSolution.Name = "listViewSolution";
			this.listViewSolution.Size = new System.Drawing.Size(456, 536);
			this.listViewSolution.TabIndex = 0;
			this.listViewSolution.UseCompatibleStateImageBehavior = false;
			this.listViewSolution.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewSolution_MouseDoubleClick);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonDelete.Location = new System.Drawing.Point(479, 396);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(49, 25);
			this.buttonDelete.TabIndex = 9;
			this.buttonDelete.Text = "<<";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonInsert
			// 
			this.buttonInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonInsert.Location = new System.Drawing.Point(479, 365);
			this.buttonInsert.Name = "buttonInsert";
			this.buttonInsert.Size = new System.Drawing.Size(49, 25);
			this.buttonInsert.TabIndex = 8;
			this.buttonInsert.Text = ">>";
			this.buttonInsert.UseVisualStyleBackColor = true;
			this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
			// 
			// buttonCleanSolutionListView
			// 
			this.buttonCleanSolutionListView.Location = new System.Drawing.Point(883, 690);
			this.buttonCleanSolutionListView.Name = "buttonCleanSolutionListView";
			this.buttonCleanSolutionListView.Size = new System.Drawing.Size(113, 28);
			this.buttonCleanSolutionListView.TabIndex = 10;
			this.buttonCleanSolutionListView.Text = "Изчисти решение";
			this.buttonCleanSolutionListView.UseVisualStyleBackColor = true;
			this.buttonCleanSolutionListView.Click += new System.EventHandler(this.buttonCleanSolutionListView_Click);
			// 
			// buttonCheckSolution
			// 
			this.buttonCheckSolution.Location = new System.Drawing.Point(764, 690);
			this.buttonCheckSolution.Name = "buttonCheckSolution";
			this.buttonCheckSolution.Size = new System.Drawing.Size(113, 28);
			this.buttonCheckSolution.TabIndex = 11;
			this.buttonCheckSolution.Text = "Провери решение";
			this.buttonCheckSolution.UseVisualStyleBackColor = true;
			this.buttonCheckSolution.Click += new System.EventHandler(this.buttonCheckSolution_Click);
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.началоToolStripMenuItem,
            this.избериДругЕкспериментToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(1008, 24);
			this.menuStrip.TabIndex = 19;
			this.menuStrip.Text = "menuStrip1";
			// 
			// началоToolStripMenuItem
			// 
			this.началоToolStripMenuItem.Name = "началоToolStripMenuItem";
			this.началоToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.началоToolStripMenuItem.Text = "Начало";
			this.началоToolStripMenuItem.Click += new System.EventHandler(this.началоToolStripMenuItem_Click);
			// 
			// избериДругЕкспериментToolStripMenuItem
			// 
			this.избериДругЕкспериментToolStripMenuItem.Name = "избериДругЕкспериментToolStripMenuItem";
			this.избериДругЕкспериментToolStripMenuItem.Size = new System.Drawing.Size(162, 20);
			this.избериДругЕкспериментToolStripMenuItem.Text = "Избери друг експеримент";
			this.избериДругЕкспериментToolStripMenuItem.Click += new System.EventHandler(this.избериДругЕкспериментToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
			this.helpToolStripMenuItem.Text = "Помощ";
			this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(3, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(956, 41);
			this.label1.TabIndex = 20;
			this.label1.Text = "Изгледайте видеото на експеримента.  Обърнете внимание на предметите и действията" +
    ". Запишете последователността от действията, които се извършват.";
			// 
			// groupBoxQuestion
			// 
			this.groupBoxQuestion.Controls.Add(this.label1);
			this.groupBoxQuestion.Location = new System.Drawing.Point(19, 27);
			this.groupBoxQuestion.Name = "groupBoxQuestion";
			this.groupBoxQuestion.Size = new System.Drawing.Size(968, 72);
			this.groupBoxQuestion.TabIndex = 21;
			this.groupBoxQuestion.TabStop = false;
			this.groupBoxQuestion.Text = "Условие";
			// 
			// ExperimentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 730);
			this.Controls.Add(this.groupBoxQuestion);
			this.Controls.Add(this.linkLabelLink);
			this.Controls.Add(this.menuStrip);
			this.Controls.Add(this.buttonCheckSolution);
			this.Controls.Add(this.labelLinkStatic);
			this.Controls.Add(this.buttonCleanSolutionListView);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonInsert);
			this.Controls.Add(this.groupBoxSolution);
			this.Controls.Add(this.groupBoxInstruments);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "ExperimentForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Опит";
			this.groupBoxInstruments.ResumeLayout(false);
			this.groupBoxSolution.ResumeLayout(false);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.groupBoxQuestion.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.ListView listViewInstruments;
		private System.Windows.Forms.Label labelLinkStatic;
		private System.Windows.Forms.GroupBox groupBoxInstruments;
		private System.Windows.Forms.GroupBox groupBoxSolution;
		private System.Windows.Forms.ListView listViewSolution;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonInsert;
		private System.Windows.Forms.Button buttonCleanSolutionListView;
		private System.Windows.Forms.Button buttonCheckSolution;
		private System.Windows.Forms.LinkLabel linkLabelLink;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem началоToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem избериДругЕкспериментToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBoxQuestion;
    }
}

