namespace CreateMapTool
{
	partial class CreateMap
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateMap));
			this.panelMap = new System.Windows.Forms.Panel();
			this.groupBoxCellSettings = new System.Windows.Forms.GroupBox();
			this.buttonSaveCell = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBoxBehavior = new System.Windows.Forms.ComboBox();
			this.checkBoxStartPosition = new System.Windows.Forms.CheckBox();
			this.buttonDrawMap = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.groupBoxMovement = new System.Windows.Forms.GroupBox();
			this.listViewPickedActions = new System.Windows.Forms.ListView();
			this.buttonInsert = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.groupBoxActions = new System.Windows.Forms.GroupBox();
			this.listViewActions = new System.Windows.Forms.ListView();
			this.imageList = new System.Windows.Forms.ImageList(this.components);
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBoxKeys = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.groupBoxCellSettings.SuspendLayout();
			this.groupBoxMovement.SuspendLayout();
			this.groupBoxActions.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBoxKeys.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMap
			// 
			this.panelMap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelMap.Location = new System.Drawing.Point(21, 141);
			this.panelMap.Name = "panelMap";
			this.panelMap.Size = new System.Drawing.Size(500, 500);
			this.panelMap.TabIndex = 0;
			this.panelMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelMap_MouseClick);
			this.panelMap.MouseEnter += new System.EventHandler(this.panelMap_MouseEnter);
			this.panelMap.MouseLeave += new System.EventHandler(this.panelMap_MouseLeave);
			// 
			// groupBoxCellSettings
			// 
			this.groupBoxCellSettings.Controls.Add(this.buttonSaveCell);
			this.groupBoxCellSettings.Controls.Add(this.label1);
			this.groupBoxCellSettings.Controls.Add(this.comboBoxBehavior);
			this.groupBoxCellSettings.Controls.Add(this.checkBoxStartPosition);
			this.groupBoxCellSettings.Location = new System.Drawing.Point(21, 41);
			this.groupBoxCellSettings.Name = "groupBoxCellSettings";
			this.groupBoxCellSettings.Size = new System.Drawing.Size(269, 94);
			this.groupBoxCellSettings.TabIndex = 2;
			this.groupBoxCellSettings.TabStop = false;
			this.groupBoxCellSettings.Text = "Контрол над клетка";
			// 
			// buttonSaveCell
			// 
			this.buttonSaveCell.Enabled = false;
			this.buttonSaveCell.Location = new System.Drawing.Point(7, 65);
			this.buttonSaveCell.Name = "buttonSaveCell";
			this.buttonSaveCell.Size = new System.Drawing.Size(110, 23);
			this.buttonSaveCell.TabIndex = 3;
			this.buttonSaveCell.Text = "Запази клетка";
			this.buttonSaveCell.UseVisualStyleBackColor = true;
			this.buttonSaveCell.Click += new System.EventHandler(this.buttonSaveCell_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(131, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(130, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Поведение на клетката:";
			// 
			// comboBoxBehavior
			// 
			this.comboBoxBehavior.Enabled = false;
			this.comboBoxBehavior.FormattingEnabled = true;
			this.comboBoxBehavior.Location = new System.Drawing.Point(134, 32);
			this.comboBoxBehavior.Name = "comboBoxBehavior";
			this.comboBoxBehavior.Size = new System.Drawing.Size(120, 21);
			this.comboBoxBehavior.TabIndex = 1;
			this.comboBoxBehavior.SelectedIndexChanged += new System.EventHandler(this.comboBoxBehavior_SelectedIndexChanged);
			// 
			// checkBoxStartPosition
			// 
			this.checkBoxStartPosition.Enabled = false;
			this.checkBoxStartPosition.Location = new System.Drawing.Point(7, 16);
			this.checkBoxStartPosition.Name = "checkBoxStartPosition";
			this.checkBoxStartPosition.Size = new System.Drawing.Size(123, 34);
			this.checkBoxStartPosition.TabIndex = 0;
			this.checkBoxStartPosition.Text = "Стартова позиция на робота";
			this.checkBoxStartPosition.UseVisualStyleBackColor = true;
			this.checkBoxStartPosition.CheckedChanged += new System.EventHandler(this.checkBoxStartPosition_CheckedChanged);
			// 
			// buttonDrawMap
			// 
			this.buttonDrawMap.Location = new System.Drawing.Point(21, 12);
			this.buttonDrawMap.Name = "buttonDrawMap";
			this.buttonDrawMap.Size = new System.Drawing.Size(117, 23);
			this.buttonDrawMap.TabIndex = 3;
			this.buttonDrawMap.Text = "Начертай карта";
			this.buttonDrawMap.UseVisualStyleBackColor = true;
			this.buttonDrawMap.Click += new System.EventHandler(this.buttonDrawMap_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(918, 647);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 4;
			this.buttonCancel.Text = "Откажи";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(837, 647);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 5;
			this.buttonSave.Text = "Запази";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// groupBoxMovement
			// 
			this.groupBoxMovement.Controls.Add(this.listViewPickedActions);
			this.groupBoxMovement.Location = new System.Drawing.Point(837, 41);
			this.groupBoxMovement.Name = "groupBoxMovement";
			this.groupBoxMovement.Size = new System.Drawing.Size(159, 600);
			this.groupBoxMovement.TabIndex = 6;
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
			this.listViewPickedActions.Size = new System.Drawing.Size(153, 581);
			this.listViewPickedActions.TabIndex = 0;
			this.listViewPickedActions.UseCompatibleStateImageBehavior = false;
			this.listViewPickedActions.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewPickedActions_MouseDoubleClick);
			// 
			// buttonInsert
			// 
			this.buttonInsert.Location = new System.Drawing.Point(786, 206);
			this.buttonInsert.Name = "buttonInsert";
			this.buttonInsert.Size = new System.Drawing.Size(43, 23);
			this.buttonInsert.TabIndex = 7;
			this.buttonInsert.Text = ">>";
			this.buttonInsert.UseVisualStyleBackColor = true;
			this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(786, 235);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(43, 23);
			this.buttonDelete.TabIndex = 8;
			this.buttonDelete.Text = "<<";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// groupBoxActions
			// 
			this.groupBoxActions.Controls.Add(this.listViewActions);
			this.groupBoxActions.Location = new System.Drawing.Point(536, 41);
			this.groupBoxActions.Name = "groupBoxActions";
			this.groupBoxActions.Size = new System.Drawing.Size(244, 415);
			this.groupBoxActions.TabIndex = 9;
			this.groupBoxActions.TabStop = false;
			this.groupBoxActions.Text = "Налични действия за движение";
			// 
			// listViewActions
			// 
			this.listViewActions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewActions.Location = new System.Drawing.Point(3, 16);
			this.listViewActions.Name = "listViewActions";
			this.listViewActions.Size = new System.Drawing.Size(238, 396);
			this.listViewActions.TabIndex = 0;
			this.listViewActions.UseCompatibleStateImageBehavior = false;
			this.listViewActions.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewActions_MouseDoubleClick);
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
			// pictureBox6
			// 
			this.pictureBox6.Image = global::CreateMapTool.Properties.Resources.Untitled;
			this.pictureBox6.Location = new System.Drawing.Point(626, 20);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(55, 50);
			this.pictureBox6.TabIndex = 31;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = global::CreateMapTool.Properties.Resources.start;
			this.pictureBox5.Location = new System.Drawing.Point(570, 20);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(50, 50);
			this.pictureBox5.TabIndex = 30;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = global::CreateMapTool.Properties.Resources.robot;
			this.pictureBox4.Location = new System.Drawing.Point(477, 20);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(32, 50);
			this.pictureBox4.TabIndex = 29;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::CreateMapTool.Properties.Resources.path2Texture;
			this.pictureBox3.Location = new System.Drawing.Point(343, 20);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(50, 50);
			this.pictureBox3.TabIndex = 28;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::CreateMapTool.Properties.Resources.trapPitTexture;
			this.pictureBox2.Location = new System.Drawing.Point(168, 19);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(47, 50);
			this.pictureBox2.TabIndex = 27;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::CreateMapTool.Properties.Resources.wallTexture;
			this.pictureBox1.Location = new System.Drawing.Point(6, 19);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(50, 51);
			this.pictureBox1.TabIndex = 26;
			this.pictureBox1.TabStop = false;
			// 
			// groupBoxKeys
			// 
			this.groupBoxKeys.Controls.Add(this.label6);
			this.groupBoxKeys.Controls.Add(this.label5);
			this.groupBoxKeys.Controls.Add(this.label4);
			this.groupBoxKeys.Controls.Add(this.label3);
			this.groupBoxKeys.Location = new System.Drawing.Point(296, 41);
			this.groupBoxKeys.Name = "groupBoxKeys";
			this.groupBoxKeys.Size = new System.Drawing.Size(225, 94);
			this.groupBoxKeys.TabIndex = 32;
			this.groupBoxKeys.TabStop = false;
			this.groupBoxKeys.Text = "Справка за клавишите";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(9, 53);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(156, 13);
			this.label6.TabIndex = 3;
			this.label6.Text = "G - задава финалната клетка";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(10, 72);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(91, 13);
			this.label5.TabIndex = 2;
			this.label5.Text = "Е - задава дупка";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 35);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 13);
			this.label4.TabIndex = 1;
			this.label4.Text = "P - задава път";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 17);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "W - задава стена";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(278, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(262, 29);
			this.label2.TabIndex = 0;
			this.label2.Text = "Като поставите курсора над клетка, с натискане на клавиш задавате нейното поведен" +
    "ие, като:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.pictureBox5);
			this.groupBox1.Controls.Add(this.pictureBox2);
			this.groupBox1.Controls.Add(this.pictureBox3);
			this.groupBox1.Controls.Add(this.pictureBox6);
			this.groupBox1.Controls.Add(this.pictureBox4);
			this.groupBox1.Location = new System.Drawing.Point(21, 644);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(756, 81);
			this.groupBox1.TabIndex = 33;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Легенда на картата";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label11.Location = new System.Drawing.Point(687, 19);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(63, 51);
			this.label11.TabIndex = 36;
			this.label11.Text = "Стартова и финална клетка";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label10.Location = new System.Drawing.Point(512, 19);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(52, 46);
			this.label10.TabIndex = 35;
			this.label10.Text = "Роботът-това сте вие";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.Location = new System.Drawing.Point(399, 19);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(72, 62);
			this.label9.TabIndex = 34;
			this.label9.Text = "Път - роботът може да преминава безопастно";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(221, 17);
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
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label14);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Location = new System.Drawing.Point(539, 462);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(238, 176);
			this.groupBox2.TabIndex = 34;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Правила за движение";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(7, 115);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(219, 60);
			this.label14.TabIndex = 2;
			this.label14.Text = "Скок наляво, надясно, нагоре, надолу карат робота да скочи. Това действие премест" +
    "ва робота на разстояние с 2 клетки.";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(7, 62);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(222, 49);
			this.label13.TabIndex = 1;
			this.label13.Text = "Посоките нагоре, надолу, наляво, надясно преместват робота в съответната посока.";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(7, 16);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(225, 46);
			this.label12.TabIndex = 0;
			this.label12.Text = "Всяка от посоките премества робота с разстояние 1 клетка. Движение по диагонал е " +
    "забранено.";
			// 
			// CreateMap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 730);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.groupBoxKeys);
			this.Controls.Add(this.groupBoxActions);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonInsert);
			this.Controls.Add(this.groupBoxMovement);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonDrawMap);
			this.Controls.Add(this.groupBoxCellSettings);
			this.Controls.Add(this.panelMap);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CreateMap";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Създаване на карта";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CreateMapTool_KeyDown);
			this.groupBoxCellSettings.ResumeLayout(false);
			this.groupBoxCellSettings.PerformLayout();
			this.groupBoxMovement.ResumeLayout(false);
			this.groupBoxActions.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBoxKeys.ResumeLayout(false);
			this.groupBoxKeys.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMap;
		private System.Windows.Forms.GroupBox groupBoxCellSettings;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxBehavior;
		private System.Windows.Forms.CheckBox checkBoxStartPosition;
		private System.Windows.Forms.Button buttonDrawMap;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.GroupBox groupBoxMovement;
		private System.Windows.Forms.Button buttonInsert;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.GroupBox groupBoxActions;
		private System.Windows.Forms.ListView listViewPickedActions;
		private System.Windows.Forms.ListView listViewActions;
		private System.Windows.Forms.ImageList imageList;
		private System.Windows.Forms.Button buttonSaveCell;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBoxKeys;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
	}
}

