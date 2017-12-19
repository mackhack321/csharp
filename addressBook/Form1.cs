using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace addressBook
{
    public partial class Form1 : Form
    {
        class data
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string age { get; set; }
            public string phone { get; set; }
        }

        data[] dictionary = new data[100];

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 101; i++) { comboBoxAge.Items.Add(i); }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (textBoxFName.Text is "" || textBoxLName.Text is "" || textBoxPhone.Text is "" || comboBoxAge.Text is "")
            {
                MessageBox.Show("Please fill in all fields", "Error");
            }

            else
            {
                for (int i = 0; i < 101; i++)
                {
                    if (dictionary[i] is null)
                    {
                        dictionary[i] = new data
                        {
                            firstName = textBoxFName.Text,
                            lastName = textBoxLName.Text,
                            age = comboBoxAge.Text,
                            phone = textBoxPhone.Text
                        };
                        dataGridView1.Rows.Add(dictionary[i].firstName, dictionary[i].lastName, dictionary[i].phone, dictionary[i].age);
                        textBoxFName.Clear(); textBoxLName.Clear(); textBoxPhone.Clear(); comboBoxAge.Text = "";
                        break;
                    }
                }
            }
        }
    }
}
