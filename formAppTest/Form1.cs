using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace formAppTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
   
        private void button1_Click(object sender, EventArgs e)
        {
            string getText = textBox1.Text;

            if (getText.Length == 0)
            {
                MessageBox.Show("Cannot save empty field!", "Error");
            }
            else
            {
                try
                {
                    var file = new SaveFileDialog();
                    file.DefaultExt = "txt";
                    file.Filter = "Text Files (*.txt)|*.txt";
                    file.AddExtension = true;
                    file.ShowDialog();
                    var path = Path.GetFullPath(file.FileName);
                    StreamWriter sw = new StreamWriter(path, append: true);
                    var date = dateTimePicker1.Value.Date;
                    if (checkIncludeDate.Checked)
                    {
                        sw.WriteLine($"{getText} on {date}");
                        sw.Close();            
                    }
                    else
                    {
                        sw.WriteLine($"{getText}");
                        sw.Close();
                    }
                    MessageBox.Show($"Input saved to {path}", "Save Notification");
                }
                catch (System.ArgumentException)
                {

                }
                
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var date = dateTimePicker1.Value;
        }

        private void buttonColorPick_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox1.ForeColor = colorDialog1.Color;
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                var file = new OpenFileDialog();
                file.DefaultExt = "txt";
                file.Filter = "Text Files (*.txt)|*.txt";
                file.AddExtension = true;
                file.ShowDialog();
                try
                {
                    var path = Path.GetFullPath(file.FileName);
                    StreamReader sr = new StreamReader(path);
                    textBox1.Text = sr.ReadToEnd();
                    sr.Close();
                }
                catch (System.ArgumentException)
                {
                    
                }  
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("File not found", "Error");
            }
        }

        private void buttonErase_Click(object sender, EventArgs e)
        {
            var file = new OpenFileDialog();
            file.DefaultExt = "txt";
            file.Filter = "Text Files (*.txt)|*.txt";
            file.AddExtension = true;
            file.ShowDialog();
            try
            {
                var path = Path.GetFullPath(file.FileName);
                StreamWriter sw = new StreamWriter(path);
                sw.Write(String.Empty);
                sw.Close();
                MessageBox.Show($"File {path} has been cleared", "Clear Notification");
            }
            catch (System.ArgumentException)
            {

            }   
        }
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(dateTimePicker1, "Use this to add a date to your entry");
        }

        private void buttonPasswd_Click(object sender, EventArgs e)
        {
            textBoxPasswd.Visible = true;
            buttonPasswdOk.Visible = true;
            textBoxPasswd.MaxLength = 30;
            textBoxPasswd.PasswordChar = '*';

        }

        private void checkPasswd()
        {
            var passwd = textBoxPasswd.Text;
            if (passwd == "password")
            {
                pictureBox1.Visible = true;
            }
            else
            {
                MessageBox.Show("You are not worthy", "Password Invalid");
            }
        }

        private void buttonPasswdOk_Click(object sender, EventArgs e)
        {
            checkPasswd();
        }

        private void buttonFontPick_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            textBox1.Font = fontDialog1.Font;
        }

        private void textBoxPasswd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                checkPasswd();
            }
        }
    }
}
