using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace translator
{
    public partial class Form1 : Form
    {
        public IDictionary<string, string> languageCodes = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
            comboBoxInput.DropDownStyle = ComboBoxStyle.DropDownList; // so user cannot type their own input
            comboBoxOutput.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxInput.Items.Add("English");
            comboBoxInput.Items.Add("Spanish");
            comboBoxOutput.Items.Add("English");
            comboBoxOutput.Items.Add("Spanish");
            languageCodes.Add("English", "en");
            languageCodes.Add("Spanish", "es");
        }

        private void buttonTranslate_Click(object sender, EventArgs e)
        {
            textBoxOutput.Enabled = true;
            textBoxOutput.Text = $"Sample Text in {languageCodes[comboBoxOutput.Text]}";
        }
    }
}
