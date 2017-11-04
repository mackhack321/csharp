namespace formAppTest
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
            this.components = new System.ComponentModel.Container();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonColorPick = new System.Windows.Forms.Button();
            this.checkIncludeDate = new System.Windows.Forms.CheckBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonErase = new System.Windows.Forms.Button();
            this.buttonPasswd = new System.Windows.Forms.Button();
            this.textBoxPasswd = new System.Windows.Forms.TextBox();
            this.buttonPasswdOk = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.buttonFontPick = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(424, 408);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(78, 24);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AcceptsTab = true;
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(886, 340);
            this.textBox1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(372, 438);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            this.dateTimePicker1.MouseHover += new System.EventHandler(this.dateTimePicker1_MouseHover);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // colorDialog1
            // 
            this.colorDialog1.AllowFullOpen = false;
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.SolidColorOnly = true;
            // 
            // buttonColorPick
            // 
            this.buttonColorPick.Location = new System.Drawing.Point(270, 379);
            this.buttonColorPick.Name = "buttonColorPick";
            this.buttonColorPick.Size = new System.Drawing.Size(96, 23);
            this.buttonColorPick.TabIndex = 7;
            this.buttonColorPick.Text = "Text Color Picker";
            this.buttonColorPick.UseVisualStyleBackColor = true;
            this.buttonColorPick.Click += new System.EventHandler(this.buttonColorPick_Click);
            // 
            // checkIncludeDate
            // 
            this.checkIncludeDate.AutoSize = true;
            this.checkIncludeDate.Location = new System.Drawing.Point(508, 413);
            this.checkIncludeDate.Name = "checkIncludeDate";
            this.checkIncludeDate.Size = new System.Drawing.Size(85, 17);
            this.checkIncludeDate.TabIndex = 8;
            this.checkIncludeDate.Text = "Include date";
            this.checkIncludeDate.UseVisualStyleBackColor = true;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(424, 379);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(78, 23);
            this.buttonOpen.TabIndex = 9;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonErase
            // 
            this.buttonErase.Location = new System.Drawing.Point(508, 379);
            this.buttonErase.Name = "buttonErase";
            this.buttonErase.Size = new System.Drawing.Size(75, 23);
            this.buttonErase.TabIndex = 10;
            this.buttonErase.Text = "Clear File";
            this.buttonErase.UseVisualStyleBackColor = true;
            this.buttonErase.Click += new System.EventHandler(this.buttonErase_Click);
            // 
            // buttonPasswd
            // 
            this.buttonPasswd.Location = new System.Drawing.Point(638, 379);
            this.buttonPasswd.Name = "buttonPasswd";
            this.buttonPasswd.Size = new System.Drawing.Size(123, 23);
            this.buttonPasswd.TabIndex = 11;
            this.buttonPasswd.Text = "Enter Password";
            this.buttonPasswd.UseVisualStyleBackColor = true;
            this.buttonPasswd.Click += new System.EventHandler(this.buttonPasswd_Click);
            // 
            // textBoxPasswd
            // 
            this.textBoxPasswd.Location = new System.Drawing.Point(638, 411);
            this.textBoxPasswd.Name = "textBoxPasswd";
            this.textBoxPasswd.Size = new System.Drawing.Size(123, 20);
            this.textBoxPasswd.TabIndex = 12;
            this.textBoxPasswd.Visible = false;
            this.textBoxPasswd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPasswd_KeyDown);
            // 
            // buttonPasswdOk
            // 
            this.buttonPasswdOk.Location = new System.Drawing.Point(767, 409);
            this.buttonPasswdOk.Name = "buttonPasswdOk";
            this.buttonPasswdOk.Size = new System.Drawing.Size(55, 23);
            this.buttonPasswdOk.TabIndex = 13;
            this.buttonPasswdOk.Text = "Ok";
            this.buttonPasswdOk.UseVisualStyleBackColor = true;
            this.buttonPasswdOk.Visible = false;
            this.buttonPasswdOk.Click += new System.EventHandler(this.buttonPasswdOk_Click);
            // 
            // buttonFontPick
            // 
            this.buttonFontPick.Location = new System.Drawing.Point(270, 407);
            this.buttonFontPick.Name = "buttonFontPick";
            this.buttonFontPick.Size = new System.Drawing.Size(96, 23);
            this.buttonFontPick.TabIndex = 14;
            this.buttonFontPick.Text = "Text Font Picker";
            this.buttonFontPick.UseVisualStyleBackColor = true;
            this.buttonFontPick.Click += new System.EventHandler(this.buttonFontPick_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "https://bloximages.newyork1.vip.townnews.com/williamsonherald.com/content/tncms/a" +
    "ssets/v3/editorial/f/07/f073f72c-eecd-11e6-8532-57f323130db9/589c72571fb92.image" +
    ".jpg";
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(886, 340);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 504);
            this.Controls.Add(this.buttonFontPick);
            this.Controls.Add(this.buttonPasswdOk);
            this.Controls.Add(this.textBoxPasswd);
            this.Controls.Add(this.buttonPasswd);
            this.Controls.Add(this.buttonErase);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.checkIncludeDate);
            this.Controls.Add(this.buttonColorPick);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Mack\'s App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonColorPick;
        private System.Windows.Forms.CheckBox checkIncludeDate;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonErase;
        private System.Windows.Forms.Button buttonPasswd;
        private System.Windows.Forms.TextBox textBoxPasswd;
        private System.Windows.Forms.Button buttonPasswdOk;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button buttonFontPick;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

