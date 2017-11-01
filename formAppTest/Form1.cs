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
                buttonSave.Text = "Saved!";
                var file = new SaveFileDialog();
                file.ShowDialog();
                var path = Path.GetFullPath(file.FileName);
                StreamWriter sw = new StreamWriter(path,append: true);
                var date = dateTimePicker1.Value;
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
                MessageBox.Show($"Input saved to out.txt", "Save Notification");
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            buttonSave.Text = "Click to save";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            buttonSave.Text = "Save";
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
                var file = new SaveFileDialog();
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
            StreamWriter sw = new StreamWriter("out.txt");
            sw.Write(String.Empty);
            sw.Close();
            MessageBox.Show("File out.txt has been cleared", "Clear Notification");
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
