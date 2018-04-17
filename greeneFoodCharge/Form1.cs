using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace greeneFoodCharge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cost = double.Parse(textBox1.Text);
            double tax = Math.Round(cost * .07, 2);
            double tip = Math.Round(cost * .15, 2);
            double total = cost + tax + tip;
            MessageBox.Show($"Tax: {tax}, Tip: {tip}, Final Cost: {total}");
        }
    }
}
