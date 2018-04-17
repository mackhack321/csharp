using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace greeneMagicDate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int month = int.Parse(textBoxMonth.Text);
            int day = int.Parse(textBoxDay.Text);
            int year = int.Parse(textBoxYear.Text);

            if (month * day == year) { MessageBox.Show("Congrats, your date is magical!"); }
            else { MessageBox.Show("Sorry, there's no magic in your date :("); }
        }
    }
}
