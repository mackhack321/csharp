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
            this.buttonSave.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.buttonSave.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AcceptsTab = true;
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(895, 328);
            this.textBox1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(372, 438);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
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
            this.buttonColorPick.Location = new System.Drawing.Point(413, 350);
            this.buttonColorPick.Name = "buttonColorPick";
            this.buttonColorPick.Size = new System.Drawing.Size(109, 23);
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
            this.buttonErase.Location = new System.Drawing.Point(518, 379);
            this.buttonErase.Name = "buttonErase";
            this.buttonErase.Size = new System.Drawing.Size(75, 23);
            this.buttonErase.TabIndex = 10;
            this.buttonErase.Text = "Clear File";
            this.buttonErase.UseVisualStyleBackColor = true;
            this.buttonErase.Click += new System.EventHandler(this.buttonErase_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 504);
            this.Controls.Add(this.buttonErase);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.checkIncludeDate);
            this.Controls.Add(this.buttonColorPick);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonSave);
            this.Name = "Form1";
            this.Text = "Mack\'s App";
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
    }
}

