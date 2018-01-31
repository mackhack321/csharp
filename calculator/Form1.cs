using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        List<string> boxInfo = new List<string> { };
        List<string> numOne = new List<string> { };
        List<string> numTwo = new List<string> { };
        public string operation;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) { boxInfo.Add("1"); textBoxNums.Text = String.Join("", boxInfo); }
        private void button2_Click(object sender, EventArgs e) { boxInfo.Add("2"); textBoxNums.Text = String.Join("", boxInfo); }
        private void button3_Click(object sender, EventArgs e) { boxInfo.Add("3"); textBoxNums.Text = String.Join("", boxInfo); }
        private void button4_Click(object sender, EventArgs e) { boxInfo.Add("4"); textBoxNums.Text = String.Join("", boxInfo); }
        private void button5_Click(object sender, EventArgs e) { boxInfo.Add("5"); textBoxNums.Text = String.Join("", boxInfo); }
        private void button6_Click(object sender, EventArgs e) { boxInfo.Add("6"); textBoxNums.Text = String.Join("", boxInfo); }
        private void button7_Click(object sender, EventArgs e) { boxInfo.Add("7"); textBoxNums.Text = String.Join("", boxInfo); }
        private void button8_Click(object sender, EventArgs e) { boxInfo.Add("8"); textBoxNums.Text = String.Join("", boxInfo); }
        private void button9_Click(object sender, EventArgs e) { boxInfo.Add("9"); textBoxNums.Text = String.Join("", boxInfo); }
        private void button0_Click(object sender, EventArgs e) { boxInfo.Add("0"); textBoxNums.Text = String.Join("", boxInfo); }
       
        private void buttonClear_Click(object sender, EventArgs e) { textBoxNums.Clear(); boxInfo.Clear(); numOne.Clear(); numTwo.Clear(); }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            operation = "x";
            foreach (string item in boxInfo)
            {
                numOne.Add(item);
            }
            textBoxNums.Clear(); boxInfo.Clear();
        }
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            operation = "/";
            foreach (string item in boxInfo)
            {
                numOne.Add(item);
            }
            textBoxNums.Clear(); boxInfo.Clear();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            operation = "+";
            foreach (string item in boxInfo)
            {
                numOne.Add(item);
            }
            textBoxNums.Clear(); boxInfo.Clear();
        }
        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            operation = "-";
            foreach (string item in boxInfo)
            {
                numOne.Add(item);
            }
            textBoxNums.Clear(); boxInfo.Clear();
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            foreach (string item in boxInfo)
            {
                numTwo.Add(item);
            }
            float numOneInt = float.Parse(string.Join("", numOne));
            float numTwoInt = float.Parse(string.Join("", numTwo));
            if (operation == "+")
            {
                textBoxNums.Text = (numOneInt + numTwoInt).ToString();
            }
            if (operation == "-")
            {
                textBoxNums.Text = (numOneInt - numTwoInt).ToString();
            }
            if (operation == "*")
            {
                textBoxNums.Text = (numOneInt * numTwoInt).ToString();
            }
            if (operation == "/")
            {
                textBoxNums.Text = (numOneInt / numTwoInt).ToString();
            }
        }
    }
}