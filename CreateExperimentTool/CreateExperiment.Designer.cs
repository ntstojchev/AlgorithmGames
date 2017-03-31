namespace CreateExperimentTool
{
    partial class CreateExperiment
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateExperiment));
			this.groupBoxExperimentInformation = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxSteps = new System.Windows.Forms.TextBox();
			this.labelSteps = new System.Windows.Forms.Label();
			this.textBoxExperimentExtraInfo = new System.Windows.Forms.TextBox();
			this.textBoxLink = new System.Windows.Forms.TextBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.labelExperimentExtraInfo = new System.Windows.Forms.Label();
			this.labelLink = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.groupBoxSolution = new System.Windows.Forms.GroupBox();
			this.listViewSolution = new System.Windows.Forms.ListView();
			this.groupBoxInstruments = new System.Windows.Forms.GroupBox();
			this.listViewInstruments = new System.Windows.Forms.ListView();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonInsert = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonRemove = new System.Windows.Forms.Button();
			this.buttonRemoveAllInstruments = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBoxExperimentInformation.SuspendLayout();
			this.groupBoxSolution.SuspendLayout();
			this.groupBoxInstruments.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBoxExperimentInformation
			// 
			this.groupBoxExperimentInformation.Controls.Add(this.label6);
			this.groupBoxExperimentInformation.Controls.Add(this.label5);
			this.groupBoxExperimentInformation.Controls.Add(this.label4);
			this.groupBoxExperimentInformation.Controls.Add(this.textBoxSteps);
			this.groupBoxExperimentInformation.Controls.Add(this.labelSteps);
			this.groupBoxExperimentInformation.Controls.Add(this.textBoxExperimentExtraInfo);
			this.groupBoxExperimentInformation.Controls.Add(this.textBoxLink);
			this.groupBoxExperimentInformation.Controls.Add(this.textBoxName);
			this.groupBoxExperimentInformation.Controls.Add(this.labelExperimentExtraInfo);
			this.groupBoxExperimentInformation.Controls.Add(this.labelLink);
			this.groupBoxExperimentInformation.Controls.Add(this.labelName);
			this.groupBoxExperimentInformation.Location = new System.Drawing.Point(3, 12);
			this.groupBoxExperimentInformation.Name = "groupBoxExperimentInformation";
			this.groupBoxExperimentInformation.Size = new System.Drawing.Size(990, 234);
			this.groupBoxExperimentInformation.TabIndex = 0;
			this.groupBoxExperimentInformation.TabStop = false;
			this.groupBoxExperimentInformation.Text = "Данни за опита";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(388, 41);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(223, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Броят на действията (глаголите) на опита.";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(269, 89);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(419, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Информация, която ще се изпише при правилно подреждане стъпките на опита.";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(388, 66);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(326, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Hyperlink към източника на видео материала свързан с опита.";
			// 
			// textBoxSteps
			// 
			this.textBoxSteps.Location = new System.Drawing.Point(147, 38);
			this.textBoxSteps.Name = "textBoxSteps";
			this.textBoxSteps.Size = new System.Drawing.Size(235, 20);
			this.textBoxSteps.TabIndex = 7;
			this.textBoxSteps.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSteps_KeyPress);
			this.textBoxSteps.Leave += new System.EventHandler(this.textBoxSteps_Leave);
			// 
			// labelSteps
			// 
			this.labelSteps.AutoSize = true;
			this.labelSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelSteps.Location = new System.Drawing.Point(6, 39);
			this.labelSteps.Name = "labelSteps";
			this.labelSteps.Size = new System.Drawing.Size(123, 17);
			this.labelSteps.TabIndex = 6;
			this.labelSteps.Text = "Стъпки на опита:";
			// 
			// textBoxExperimentExtraInfo
			// 
			this.textBoxExperimentExtraInfo.Location = new System.Drawing.Point(6, 107);
			this.textBoxExperimentExtraInfo.Multiline = true;
			this.textBoxExperimentExtraInfo.Name = "textBoxExperimentExtraInfo";
			this.textBoxExperimentExtraInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxExperimentExtraInfo.Size = new System.Drawing.Size(972, 121);
			this.textBoxExperimentExtraInfo.TabIndex = 5;
			// 
			// textBoxLink
			// 
			this.textBoxLink.Location = new System.Drawing.Point(147, 64);
			this.textBoxLink.Name = "textBoxLink";
			this.textBoxLink.Size = new System.Drawing.Size(235, 20);
			this.textBoxLink.TabIndex = 4;
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(147, 15);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(235, 20);
			this.textBoxName.TabIndex = 3;
			// 
			// labelExperimentExtraInfo
			// 
			this.labelExperimentExtraInfo.AutoSize = true;
			this.labelExperimentExtraInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelExperimentExtraInfo.Location = new System.Drawing.Point(6, 87);
			this.labelExperimentExtraInfo.Name = "labelExperimentExtraInfo";
			this.labelExperimentExtraInfo.Size = new System.Drawing.Size(257, 17);
			this.labelExperimentExtraInfo.TabIndex = 2;
			this.labelExperimentExtraInfo.Text = "Допълнителна информация за опита";
			// 
			// labelLink
			// 
			this.labelLink.AutoSize = true;
			this.labelLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelLink.Location = new System.Drawing.Point(6, 64);
			this.labelLink.Name = "labelLink";
			this.labelLink.Size = new System.Drawing.Size(132, 17);
			this.labelLink.TabIndex = 1;
			this.labelLink.Text = "Връзка към видео:";
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelName.Location = new System.Drawing.Point(6, 15);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(39, 17);
			this.labelName.TabIndex = 0;
			this.labelName.Text = "Име:";
			// 
			// groupBoxSolution
			// 
			this.groupBoxSolution.Controls.Add(this.listViewSolution);
			this.groupBoxSolution.Location = new System.Drawing.Point(520, 308);
			this.groupBoxSolution.Name = "groupBoxSolution";
			this.groupBoxSolution.Size = new System.Drawing.Size(476, 338);
			this.groupBoxSolution.TabIndex = 1;
			this.groupBoxSolution.TabStop = false;
			this.groupBoxSolution.Text = "Решение";
			// 
			// listViewSolution
			// 
			this.listViewSolution.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewSolution.Location = new System.Drawing.Point(3, 16);
			this.listViewSolution.MultiSelect = false;
			this.listViewSolution.Name = "listViewSolution";
			this.listViewSolution.Size = new System.Drawing.Size(470, 319);
			this.listViewSolution.TabIndex = 0;
			this.listViewSolution.UseCompatibleStateImageBehavior = false;
			this.listViewSolution.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewSolution_MouseDoubleClick);
			// 
			// groupBoxInstruments
			// 
			this.groupBoxInstruments.Controls.Add(this.listViewInstruments);
			this.groupBoxInstruments.Location = new System.Drawing.Point(9, 308);
			this.groupBoxInstruments.Name = "groupBoxInstruments";
			this.groupBoxInstruments.Size = new System.Drawing.Size(450, 338);
			this.groupBoxInstruments.TabIndex = 2;
			this.groupBoxInstruments.TabStop = false;
			this.groupBoxInstruments.Text = "Инструменти";
			// 
			// listViewInstruments
			// 
			this.listViewInstruments.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewInstruments.Location = new System.Drawing.Point(3, 16);
			this.listViewInstruments.MultiSelect = false;
			this.listViewInstruments.Name = "listViewInstruments";
			this.listViewInstruments.Size = new System.Drawing.Size(444, 319);
			this.listViewInstruments.TabIndex = 0;
			this.listViewInstruments.UseCompatibleStateImageBehavior = false;
			this.listViewInstruments.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewInstruments_MouseDoubleClick);
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(858, 649);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(66, 23);
			this.buttonSave.TabIndex = 3;
			this.buttonSave.Text = "Запази";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(930, 649);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(66, 23);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = "Откажи";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonInsert
			// 
			this.buttonInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonInsert.Location = new System.Drawing.Point(465, 500);
			this.buttonInsert.Name = "buttonInsert";
			this.buttonInsert.Size = new System.Drawing.Size(49, 25);
			this.buttonInsert.TabIndex = 6;
			this.buttonInsert.Text = ">>";
			this.buttonInsert.UseVisualStyleBackColor = true;
			this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonDelete.Location = new System.Drawing.Point(465, 469);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(49, 25);
			this.buttonDelete.TabIndex = 7;
			this.buttonDelete.Text = "<<";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Image = global::CreateExperimentTool.Properties.Resources._1;
			this.buttonAdd.Location = new System.Drawing.Point(12, 274);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(36, 28);
			this.buttonAdd.TabIndex = 8;
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonRemove
			// 
			this.buttonRemove.Image = global::CreateExperimentTool.Properties.Resources._;
			this.buttonRemove.Location = new System.Drawing.Point(54, 274);
			this.buttonRemove.Name = "buttonRemove";
			this.buttonRemove.Size = new System.Drawing.Size(30, 28);
			this.buttonRemove.TabIndex = 9;
			this.buttonRemove.UseVisualStyleBackColor = true;
			this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
			// 
			// buttonRemoveAllInstruments
			// 
			this.buttonRemoveAllInstruments.Image = global::CreateExperimentTool.Properties.Resources.X;
			this.buttonRemoveAllInstruments.Location = new System.Drawing.Point(90, 274);
			this.buttonRemoveAllInstruments.Name = "buttonRemoveAllInstruments";
			this.buttonRemoveAllInstruments.Size = new System.Drawing.Size(32, 28);
			this.buttonRemoveAllInstruments.TabIndex = 10;
			this.buttonRemoveAllInstruments.UseVisualStyleBackColor = true;
			this.buttonRemoveAllInstruments.Click += new System.EventHandler(this.buttonRemoveAllInstruments_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.pictureBox3);
			this.groupBox1.Controls.Add(this.pictureBox2);
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Location = new System.Drawing.Point(12, 652);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(444, 66);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Упътване";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(323, 19);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(101, 41);
			this.label3.TabIndex = 5;
			this.label3.Text = "Изчиства всички инструменти от инвентара";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(192, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 41);
			this.label2.TabIndex = 4;
			this.label2.Text = "Изтрива инструмент от инвентара";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(39, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 41);
			this.label1.TabIndex = 3;
			this.label1.Text = "Добавя инструмент към инвентара";
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::CreateExperimentTool.Properties.Resources.X;
			this.pictureBox3.Location = new System.Drawing.Point(281, 19);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(36, 41);
			this.pictureBox3.TabIndex = 2;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::CreateExperimentTool.Properties.Resources._;
			this.pictureBox2.Location = new System.Drawing.Point(151, 19);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(35, 41);
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::CreateExperimentTool.Properties.Resources._1;
			this.pictureBox1.Location = new System.Drawing.Point(6, 19);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(30, 41);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// CreateExperiment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 730);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.buttonRemoveAllInstruments);
			this.Controls.Add(this.buttonRemove);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonInsert);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.groupBoxSolution);
			this.Controls.Add(this.groupBoxInstruments);
			this.Controls.Add(this.groupBoxExperimentInformation);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "CreateExperiment";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Създаване на опит";
			this.groupBoxExperimentInformation.ResumeLayout(false);
			this.groupBoxExperimentInformation.PerformLayout();
			this.groupBoxSolution.ResumeLayout(false);
			this.groupBoxInstruments.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxExperimentInformation;
        private System.Windows.Forms.TextBox textBoxLink;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelExperimentExtraInfo;
        private System.Windows.Forms.Label labelLink;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxExperimentExtraInfo;
        private System.Windows.Forms.GroupBox groupBoxSolution;
        private System.Windows.Forms.ListView listViewSolution;
        private System.Windows.Forms.GroupBox groupBoxInstruments;
        private System.Windows.Forms.ListView listViewInstruments;
		private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonInsert;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonRemove;
		private System.Windows.Forms.TextBox textBoxSteps;
		private System.Windows.Forms.Label labelSteps;
		private System.Windows.Forms.Button buttonRemoveAllInstruments;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
    }
}

