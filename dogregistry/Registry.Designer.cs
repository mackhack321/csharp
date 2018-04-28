namespace dogregistry
{
    partial class Registry
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.comboBoxAge = new System.Windows.Forms.ComboBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.listBoxDogs = new System.Windows.Forms.ListBox();
            this.comboBoxRating = new System.Windows.Forms.ComboBox();
            this.labelRating = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDump = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.labelSelName = new System.Windows.Forms.Label();
            this.labelSelAge = new System.Windows.Forms.Label();
            this.labelSelRating = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Broadway", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(109, 44);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(447, 72);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Dog Registry";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(173, 164);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(208, 148);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            // 
            // comboBoxAge
            // 
            this.comboBoxAge.FormattingEnabled = true;
            this.comboBoxAge.Location = new System.Drawing.Point(202, 218);
            this.comboBoxAge.Name = "comboBoxAge";
            this.comboBoxAge.Size = new System.Drawing.Size(41, 21);
            this.comboBoxAge.TabIndex = 3;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(208, 202);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(26, 13);
            this.labelAge.TabIndex = 4;
            this.labelAge.Text = "Age";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerate.Location = new System.Drawing.Point(149, 296);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(154, 87);
            this.buttonGenerate.TabIndex = 5;
            this.buttonGenerate.Text = "GENERATE\r\nDOG";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // listBoxDogs
            // 
            this.listBoxDogs.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBoxDogs.FormattingEnabled = true;
            this.listBoxDogs.Location = new System.Drawing.Point(390, 165);
            this.listBoxDogs.Name = "listBoxDogs";
            this.listBoxDogs.Size = new System.Drawing.Size(120, 95);
            this.listBoxDogs.TabIndex = 6;
            this.listBoxDogs.Click += new System.EventHandler(this.listBoxDogs_Click);
            this.listBoxDogs.DoubleClick += new System.EventHandler(this.listBoxDogs_DoubleClick);
            // 
            // comboBoxRating
            // 
            this.comboBoxRating.FormattingEnabled = true;
            this.comboBoxRating.Location = new System.Drawing.Point(202, 262);
            this.comboBoxRating.Name = "comboBoxRating";
            this.comboBoxRating.Size = new System.Drawing.Size(41, 21);
            this.comboBoxRating.TabIndex = 7;
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Location = new System.Drawing.Point(205, 246);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(38, 13);
            this.labelRating.TabIndex = 8;
            this.labelRating.Text = "Rating";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "/10";
            // 
            // buttonDump
            // 
            this.buttonDump.Location = new System.Drawing.Point(412, 311);
            this.buttonDump.Name = "buttonDump";
            this.buttonDump.Size = new System.Drawing.Size(75, 23);
            this.buttonDump.TabIndex = 10;
            this.buttonDump.Text = "Dump Dogs";
            this.buttonDump.UseVisualStyleBackColor = true;
            this.buttonDump.Click += new System.EventHandler(this.buttonDump_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(412, 351);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 11;
            this.buttonLoad.Text = "Load Dogs";
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // labelSelName
            // 
            this.labelSelName.AutoSize = true;
            this.labelSelName.Location = new System.Drawing.Point(521, 171);
            this.labelSelName.Name = "labelSelName";
            this.labelSelName.Size = new System.Drawing.Size(35, 13);
            this.labelSelName.TabIndex = 12;
            this.labelSelName.Text = "label2";
            this.labelSelName.Visible = false;
            // 
            // labelSelAge
            // 
            this.labelSelAge.AutoSize = true;
            this.labelSelAge.Location = new System.Drawing.Point(521, 202);
            this.labelSelAge.Name = "labelSelAge";
            this.labelSelAge.Size = new System.Drawing.Size(35, 13);
            this.labelSelAge.TabIndex = 13;
            this.labelSelAge.Text = "label3";
            this.labelSelAge.Visible = false;
            // 
            // labelSelRating
            // 
            this.labelSelRating.AutoSize = true;
            this.labelSelRating.Location = new System.Drawing.Point(521, 235);
            this.labelSelRating.Name = "labelSelRating";
            this.labelSelRating.Size = new System.Drawing.Size(35, 13);
            this.labelSelRating.TabIndex = 14;
            this.labelSelRating.Text = "label4";
            this.labelSelRating.Visible = false;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(401, 270);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(109, 23);
            this.buttonDel.TabIndex = 15;
            this.buttonDel.Text = "Delete Selected";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // Registry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 450);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.labelSelRating);
            this.Controls.Add(this.labelSelAge);
            this.Controls.Add(this.labelSelName);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonDump);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.comboBoxRating);
            this.Controls.Add(this.listBoxDogs);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.comboBoxAge);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelTitle);
            this.Name = "Registry";
            this.Text = "Dog Registry";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registry_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ComboBox comboBoxAge;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.ListBox listBoxDogs;
        private System.Windows.Forms.ComboBox comboBoxRating;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDump;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label labelSelName;
        private System.Windows.Forms.Label labelSelAge;
        private System.Windows.Forms.Label labelSelRating;
        private System.Windows.Forms.Button buttonDel;
    }
}

