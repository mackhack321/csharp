namespace ubercopy
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
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.openFileDialogSource = new System.Windows.Forms.OpenFileDialog();
            this.buttonSetSource = new System.Windows.Forms.Button();
            this.textBoxDest = new System.Windows.Forms.TextBox();
            this.buttonSetDest = new System.Windows.Forms.Button();
            this.folderBrowserDialogSource = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Super Duper Copying Program";
            // 
            // textBoxSource
            // 
            this.textBoxSource.Location = new System.Drawing.Point(12, 55);
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.ReadOnly = true;
            this.textBoxSource.Size = new System.Drawing.Size(231, 20);
            this.textBoxSource.TabIndex = 1;
            // 
            // openFileDialogSource
            // 
            this.openFileDialogSource.FileName = "openFileDialog1";
            // 
            // buttonSetSource
            // 
            this.buttonSetSource.Location = new System.Drawing.Point(249, 53);
            this.buttonSetSource.Name = "buttonSetSource";
            this.buttonSetSource.Size = new System.Drawing.Size(75, 23);
            this.buttonSetSource.TabIndex = 2;
            this.buttonSetSource.Text = "Pick Files";
            this.buttonSetSource.UseVisualStyleBackColor = true;
            this.buttonSetSource.Click += new System.EventHandler(this.buttonSetSource_Click);
            // 
            // textBoxDest
            // 
            this.textBoxDest.Location = new System.Drawing.Point(12, 179);
            this.textBoxDest.Name = "textBoxDest";
            this.textBoxDest.ReadOnly = true;
            this.textBoxDest.Size = new System.Drawing.Size(231, 20);
            this.textBoxDest.TabIndex = 3;
            // 
            // buttonSetDest
            // 
            this.buttonSetDest.Location = new System.Drawing.Point(249, 176);
            this.buttonSetDest.Name = "buttonSetDest";
            this.buttonSetDest.Size = new System.Drawing.Size(75, 23);
            this.buttonSetDest.TabIndex = 4;
            this.buttonSetDest.Text = "Set Output";
            this.buttonSetDest.UseVisualStyleBackColor = true;
            this.buttonSetDest.Click += new System.EventHandler(this.buttonSetDest_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 65);
            this.button1.TabIndex = 5;
            this.button1.Text = "Copy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 377);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSetDest);
            this.Controls.Add(this.textBoxDest);
            this.Controls.Add(this.buttonSetSource);
            this.Controls.Add(this.textBoxSource);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ubercopy V1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSource;
        private System.Windows.Forms.OpenFileDialog openFileDialogSource;
        private System.Windows.Forms.Button buttonSetSource;
        private System.Windows.Forms.TextBox textBoxDest;
        private System.Windows.Forms.Button buttonSetDest;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogSource;
        private System.Windows.Forms.Button button1;
    }
}

