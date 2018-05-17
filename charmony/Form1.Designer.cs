namespace charmony
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.comboBoxAge = new System.Windows.Forms.ComboBox();
            this.listBoxInterests = new System.Windows.Forms.ListBox();
            this.textBoxInterest = new System.Windows.Forms.TextBox();
            this.buttonAddInterest = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBoxPeople = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Interests";
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(12, 54);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(90, 20);
            this.textBoxFName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Last Name";
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(142, 54);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(90, 20);
            this.textBoxLName.TabIndex = 2;
            // 
            // comboBoxAge
            // 
            this.comboBoxAge.FormattingEnabled = true;
            this.comboBoxAge.Location = new System.Drawing.Point(100, 127);
            this.comboBoxAge.Name = "comboBoxAge";
            this.comboBoxAge.Size = new System.Drawing.Size(44, 21);
            this.comboBoxAge.TabIndex = 3;
            // 
            // listBoxInterests
            // 
            this.listBoxInterests.FormattingEnabled = true;
            this.listBoxInterests.Location = new System.Drawing.Point(62, 201);
            this.listBoxInterests.Name = "listBoxInterests";
            this.listBoxInterests.Size = new System.Drawing.Size(120, 95);
            this.listBoxInterests.TabIndex = 4;
            // 
            // textBoxInterest
            // 
            this.textBoxInterest.Location = new System.Drawing.Point(188, 212);
            this.textBoxInterest.Name = "textBoxInterest";
            this.textBoxInterest.Size = new System.Drawing.Size(100, 20);
            this.textBoxInterest.TabIndex = 5;
            // 
            // buttonAddInterest
            // 
            this.buttonAddInterest.Location = new System.Drawing.Point(201, 238);
            this.buttonAddInterest.Name = "buttonAddInterest";
            this.buttonAddInterest.Size = new System.Drawing.Size(75, 23);
            this.buttonAddInterest.TabIndex = 6;
            this.buttonAddInterest.Text = "Add Interest";
            this.buttonAddInterest.UseVisualStyleBackColor = true;
            this.buttonAddInterest.Click += new System.EventHandler(this.buttonAddInterest_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(36, 333);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(214, 95);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add Person";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listBoxPeople
            // 
            this.listBoxPeople.FormattingEnabled = true;
            this.listBoxPeople.Location = new System.Drawing.Point(322, 12);
            this.listBoxPeople.Name = "listBoxPeople";
            this.listBoxPeople.Size = new System.Drawing.Size(466, 290);
            this.listBoxPeople.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxPeople);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonAddInterest);
            this.Controls.Add(this.textBoxInterest);
            this.Controls.Add(this.listBoxInterests);
            this.Controls.Add(this.comboBoxAge);
            this.Controls.Add(this.textBoxLName);
            this.Controls.Add(this.textBoxFName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.ComboBox comboBoxAge;
        private System.Windows.Forms.ListBox listBoxInterests;
        private System.Windows.Forms.TextBox textBoxInterest;
        private System.Windows.Forms.Button buttonAddInterest;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listBoxPeople;
    }
}

