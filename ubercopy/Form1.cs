using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ubercopy
{
    public partial class Form1 : Form
    {
        public string srcpath;
        public string destpath;
        public string srcname;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSetSource_Click(object sender, EventArgs e)
        {
            openFileDialogSource.ShowDialog();
            srcpath = openFileDialogSource.FileName;
            srcname = Path.GetFileName(srcpath);
            textBoxSource.Text = srcpath;
        }

        private void buttonSetDest_Click(object sender, EventArgs e)
        {
            folderBrowserDialogSource.ShowDialog();
            destpath = $"{folderBrowserDialogSource.SelectedPath}{srcname}";
            textBoxDest.Text = destpath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.Copy(srcpath, destpath);
            MessageBox.Show("Files were copied", "Success");
        }
    }
}
