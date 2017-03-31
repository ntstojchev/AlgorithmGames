namespace Robot
{
	partial class RobotForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RobotForm));
			this.groupBoxActions = new System.Windows.Forms.GroupBox();
			this.listViewActions = new System.Windows.Forms.ListView();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonInsert = new System.Windows.Forms.Button();
			this.imageList = new System.Windows.Forms.ImageList(this.components);
			this.groupBoxMovement = new System.Windows.Forms.GroupBox();
			this.listViewPickedActions = new System.Windows.Forms.ListView();
			this.panelMap = new System.Windows.Forms.Panel();
			this.buttonCheckSolution = new System.Windows.Forms.Button();
			this.buttonClearSolution = new System.Windows.Forms.Button();
			this.buttonSolutionHint = new System.Windows.Forms.Button();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.началоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.избериДругаКартаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.хелпToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.buttonSolution = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lbl_TryCount = new System.Windows.Forms.Label();
			this.groupBoxActions.SuspendLayout();
			this.groupBoxMovement.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxActions
			// 
			this.groupBoxActions.Controls.Add(this.listViewActions);
			this.groupBoxActions.Location = new System.Drawing.Point(537, 41);
			this.groupBoxActions.Name = "groupBoxActions";
			this.groupBoxActions.Size = new System.Drawing.Size(230, 500);
			this.groupBoxActions.TabIndex = 14;
			this.groupBoxActions.TabStop = false;
			this.groupBoxActions.Text = "Налични действия";
			// 
			// listViewActions
			// 
			this.listViewActions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewActions.Location = new System.Drawing.Point(3, 16);
			this.listViewActions.Name = "listViewActions";
			this.listViewActions.Size = new System.Drawing.Size(224, 481);
			this.listViewActions.TabIndex = 0;
			this.listViewActions.UseCompatibleStateImageBehavior = false;
			this.listViewActions.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewActions_MouseDoubleClick);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(786, 296);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(43, 23);
			this.buttonDelete.TabIndex = 13;
			this.buttonDelete.Text = "<<";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonInsert
			// 
			this.buttonInsert.Location = new System.Drawing.Point(786, 267);
			this.buttonInsert.Name = "buttonInsert";
			this.buttonInsert.Size = new System.Drawing.Size(43, 23);
			this.buttonInsert.TabIndex = 12;
			this.buttonInsert.Text = ">>";
			this.buttonInsert.UseVisualStyleBackColor = true;
			this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
			// 
			// imageList
			// 
			this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
			this.imageList.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList.Images.SetKeyName(0, "Надолу");
			this.imageList.Images.SetKeyName(1, "Надясно");
			this.imageList.Images.SetKeyName(2, "Наляво");
			this.imageList.Images.SetKeyName(3, "Нагоре");
			this.imageList.Images.SetKeyName(4, "Скок нагоре");
			this.imageList.Images.SetKeyName(5, "Скок надолу");
			this.imageList.Images.SetKeyName(6, "Скок наляво");
			this.imageList.Images.SetKeyName(7, "Скок надясно");
			// 
			// groupBoxMovement
			// 
			this.groupBoxMovement.Controls.Add(this.listViewPickedActions);
			this.groupBoxMovement.Location = new System.Drawing.Point(839, 41);
			this.groupBoxMovement.Name = "groupBoxMovement";
			this.groupBoxMovement.Size = new System.Drawing.Size(142, 497);
			this.groupBoxMovement.TabIndex = 11;
			this.groupBoxMovement.TabStop = false;
			this.groupBoxMovement.Text = "Действия";
			// 
			// listViewPickedActions
			// 
			this.listViewPickedActions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewPickedActions.FullRowSelect = true;
			this.listViewPickedActions.Location = new System.Drawing.Point(3, 16);
			this.listViewPickedActions.MultiSelect = false;
			this.listViewPickedActions.Name = "listViewPickedActions";
			this.listViewPickedActions.Size = new System.Drawing.Size(136, 478);
			this.listViewPickedActions.TabIndex = 0;
			this.listViewPickedActions.UseCompatibleStateImageBehavior = false;
			this.listViewPickedActions.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewPickedActions_MouseDoubleClick);
			// 
			// panelMap
			// 
			this.panelMap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelMap.Location = new System.Drawing.Point(12, 41);
			this.panelMap.Name = "panelMap";
			this.panelMap.Size = new System.Drawing.Size(500, 500);
			this.panelMap.TabIndex = 10;
			// 
			// buttonCheckSolution
			// 
			this.buttonCheckSolution.Location = new System.Drawing.Point(842, 561);
			this.buttonCheckSolution.Name = "buttonCheckSolution";
			this.buttonCheckSolution.Size = new System.Drawing.Size(136, 37);
			this.buttonCheckSolution.TabIndex = 15;
			this.buttonCheckSolution.Text = "Изпълни действията до момента";
			this.buttonCheckSolution.UseVisualStyleBackColor = true;
			this.buttonCheckSolution.Click += new System.EventHandler(this.buttonCheckSolution_Click);
			// 
			// buttonClearSolution
			// 
			this.buttonClearSolution.Location = new System.Drawing.Point(842, 635);
			this.buttonClearSolution.Name = "buttonClearSolution";
			this.buttonClearSolution.Size = new System.Drawing.Size(136, 23);
			this.buttonClearSolution.TabIndex = 16;
			this.buttonClearSolution.Text = "Изчисти действията";
			this.buttonClearSolution.UseVisualStyleBackColor = true;
			this.buttonClearSolution.Click += new System.EventHandler(this.buttonClearSolution_Click);
			// 
			// buttonSolutionHint
			// 
			this.buttonSolutionHint.Location = new System.Drawing.Point(786, 238);
			this.buttonSolutionHint.Name = "buttonSolutionHint";
			this.buttonSolutionHint.Size = new System.Drawing.Size(42, 23);
			this.buttonSolutionHint.TabIndex = 17;
			this.buttonSolutionHint.Text = "?";
			this.buttonSolutionHint.UseVisualStyleBackColor = true;
			this.buttonSolutionHint.Click += new System.EventHandler(this.buttonSolutionHint_Click);
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.началоToolStripMenuItem,
            this.избериДругаКартаToolStripMenuItem,
            this.хелпToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(1008, 24);
			this.menuStrip.TabIndex = 18;
			this.menuStrip.Text = "menuStrip1";
			// 
			// началоToolStripMenuItem
			// 
			this.началоToolStripMenuItem.Name = "началоToolStripMenuItem";
			this.началоToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.началоToolStripMenuItem.Text = "Начало";
			this.началоToolStripMenuItem.Click += new System.EventHandler(this.началоToolStripMenuItem_Click);
			// 
			// избериДругаКартаToolStripMenuItem
			// 
			this.избериДругаКартаToolStripMenuItem.Name = "избериДругаКартаToolStripMenuItem";
			this.избериДругаКартаToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
			this.избериДругаКартаToolStripMenuItem.Text = "Избери друга карта";
			this.избериДругаКартаToolStripMenuItem.Click += new System.EventHandler(this.избериДругаКартаToolStripMenuItem_Click);
			// 
			// хелпToolStripMenuItem
			// 
			this.хелпToolStripMenuItem.Name = "хелпToolStripMenuItem";
			this.хелпToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
			this.хелпToolStripMenuItem.Text = "Помощ";
			this.хелпToolStripMenuItem.Click += new System.EventHandler(this.хелпToolStripMenuItem_Click);
			// 
			// buttonSolution
			// 
			this.buttonSolution.Location = new System.Drawing.Point(842, 604);
			this.buttonSolution.Name = "buttonSolution";
			this.buttonSolution.Size = new System.Drawing.Size(136, 23);
			this.buttonSolution.TabIndex = 19;
			this.buttonSolution.Text = "Провери решение";
			this.buttonSolution.UseVisualStyleBackColor = true;
			this.buttonSolution.Click += new System.EventHandler(this.buttonSolution_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.pictureBox7);
			this.groupBox1.Controls.Add(this.pictureBox8);
			this.groupBox1.Controls.Add(this.pictureBox9);
			this.groupBox1.Controls.Add(this.pictureBox10);
			this.groupBox1.Controls.Add(this.pictureBox11);
			this.groupBox1.Controls.Add(this.pictureBox12);
			this.groupBox1.Location = new System.Drawing.Point(11, 547);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(501, 171);
			this.groupBox1.TabIndex = 34;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Легенда на картата";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(430, 112);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 51);
			this.label1.TabIndex = 37;
			this.label1.Text = "Финална клетка";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label11.Location = new System.Drawing.Point(425, 18);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(63, 51);
			this.label11.TabIndex = 36;
			this.label11.Text = "Стартова клетка";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label10.Location = new System.Drawing.Point(236, 112);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(52, 46);
			this.label10.TabIndex = 35;
			this.label10.Text = "Роботът-това сте вие";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.Location = new System.Drawing.Point(257, 18);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(72, 62);
			this.label9.TabIndex = 34;
			this.label9.Text = "Път - роботът може да преминава безопастно";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(62, 113);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(116, 53);
			this.label8.TabIndex = 33;
			this.label8.Text = "Дупка - роботът не може да преминава през нея, но може да я прескочи";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(62, 19);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 54);
			this.label7.TabIndex = 32;
			this.label7.Text = "Стена - роботът не може да преминава през нея";
			// 
			// pictureBox7
			// 
			this.pictureBox7.Image = global::Robot.Properties.Resources.wallTexture;
			this.pictureBox7.InitialImage = null;
			this.pictureBox7.Location = new System.Drawing.Point(6, 19);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(50, 51);
			this.pictureBox7.TabIndex = 26;
			this.pictureBox7.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Image = global::Robot.Properties.Resources.start;
			this.pictureBox8.Location = new System.Drawing.Point(369, 19);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(50, 50);
			this.pictureBox8.TabIndex = 30;
			this.pictureBox8.TabStop = false;
			// 
			// pictureBox9
			// 
			this.pictureBox9.Image = global::Robot.Properties.Resources.trapPitTexture;
			this.pictureBox9.Location = new System.Drawing.Point(9, 115);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(47, 50);
			this.pictureBox9.TabIndex = 27;
			this.pictureBox9.TabStop = false;
			// 
			// pictureBox10
			// 
			this.pictureBox10.Image = global::Robot.Properties.Resources.path2Texture;
			this.pictureBox10.Location = new System.Drawing.Point(201, 19);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(50, 50);
			this.pictureBox10.TabIndex = 28;
			this.pictureBox10.TabStop = false;
			// 
			// pictureBox11
			// 
			this.pictureBox11.Image = global::Robot.Properties.Resources.EndGoal;
			this.pictureBox11.Location = new System.Drawing.Point(369, 112);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(55, 50);
			this.pictureBox11.TabIndex = 31;
			this.pictureBox11.TabStop = false;
			// 
			// pictureBox12
			// 
			this.pictureBox12.Image = global::Robot.Properties.Resources.robot;
			this.pictureBox12.Location = new System.Drawing.Point(201, 113);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(32, 50);
			this.pictureBox12.TabIndex = 29;
			this.pictureBox12.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label14);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Location = new System.Drawing.Point(540, 547);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(227, 176);
			this.groupBox2.TabIndex = 35;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Правила за движение";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(7, 115);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(214, 60);
			this.label14.TabIndex = 2;
			this.label14.Text = "Скок наляво, надясно, нагоре, надолу карат робота да скочи. Това действие премест" +
    "ва робота на разстояние с 2 клетки.";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(7, 62);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(214, 49);
			this.label13.TabIndex = 1;
			this.label13.Text = "Посоките нагоре, надолу, наляво, надясно преместват робота в съответната посока.";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(7, 16);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(214, 46);
			this.label12.TabIndex = 0;
			this.label12.Text = "Всяка от посоките премества робота с разстояние 1 клетка. Движение по диагонал е " +
    "забранено.";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(839, 541);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 13);
			this.label2.TabIndex = 36;
			this.label2.Text = "Брой опити:";
			// 
			// lbl_TryCount
			// 
			this.lbl_TryCount.AutoSize = true;
			this.lbl_TryCount.Location = new System.Drawing.Point(912, 541);
			this.lbl_TryCount.Name = "lbl_TryCount";
			this.lbl_TryCount.Size = new System.Drawing.Size(0, 13);
			this.lbl_TryCount.TabIndex = 37;
			// 
			// RobotForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.ClientSize = new System.Drawing.Size(1008, 730);
			this.Controls.Add(this.lbl_TryCount);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.buttonSolution);
			this.Controls.Add(this.menuStrip);
			this.Controls.Add(this.buttonSolutionHint);
			this.Controls.Add(this.buttonClearSolution);
			this.Controls.Add(this.buttonCheckSolution);
			this.Controls.Add(this.groupBoxActions);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonInsert);
			this.Controls.Add(this.groupBoxMovement);
			this.Controls.Add(this.panelMap);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "RobotForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Robot";
			this.Shown += new System.EventHandler(this.Robot_Shown);
			this.groupBoxActions.ResumeLayout(false);
			this.groupBoxMovement.ResumeLayout(false);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxActions;
		private System.Windows.Forms.ListView listViewActions;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonInsert;
		private System.Windows.Forms.ImageList imageList;
		private System.Windows.Forms.GroupBox groupBoxMovement;
		private System.Windows.Forms.ListView listViewPickedActions;
		private System.Windows.Forms.Panel panelMap;
		private System.Windows.Forms.Button buttonCheckSolution;
		private System.Windows.Forms.Button buttonClearSolution;
		private System.Windows.Forms.Button buttonSolutionHint;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem началоToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem хелпToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem избериДругаКартаToolStripMenuItem;
		private System.Windows.Forms.Button buttonSolution;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.PictureBox pictureBox11;
		private System.Windows.Forms.PictureBox pictureBox12;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbl_TryCount;
	}
}