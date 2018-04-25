using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YandexTranslateCSharpSdk;

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
            languageCodes.Add("English", "en");
            languageCodes.Add("Spanish", "es");
            foreach (string key in languageCodes.Keys) // populate dropdowns
            {
                comboBoxInput.Items.Add(key);
                comboBoxOutput.Items.Add(key);
            }
        }

        private async void buttonTranslate_ClickAsync(object sender, EventArgs e)
        {
            textBoxOutput.Enabled = true;
            await translate(textBoxInput.Text, $"{languageCodes[comboBoxInput.Text]}-{languageCodes[comboBoxOutput.Text]}");
        }

        public async Task translate(string text, string lang)
        {
            YandexTranslateSdk wrapper = new YandexTranslateSdk
            { ApiKey = "trnsl.1.1.20180425T020912Z.749ad2de84bbafee.4ad82b8ab6d6f4b37d3d3b49b966ef528e7f73a0" };
            string translated = await wrapper.TranslateText(textBoxInput.Text, lang);
            textBoxOutput.Text = translated;
        }
    }
}
