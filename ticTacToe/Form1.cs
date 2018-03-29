using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ticTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public bool checkForXWin()
        {
            return (buttonTopLt.Text == "X" && buttonTopMid.Text == "X" && buttonTopRt.Text == "X") ||
                   (buttonMidLt.Text == "X" && buttonMidMid.Text == "X" && buttonMidRt.Text == "X") ||
                   (buttonBotLt.Text == "X" && buttonBotMid.Text == "X" && buttonBotRt.Text == "X") ||
                   (buttonTopLt.Text == "X" && buttonMidLt.Text == "X" && buttonBotLt.Text == "X") ||
                   (buttonTopMid.Text == "X" && buttonMidMid.Text == "X" && buttonBotMid.Text == "X") ||
                   (buttonTopRt.Text == "X" && buttonMidRt.Text == "X" && buttonBotRt.Text == "X") ||
                   (buttonTopLt.Text == "X" && buttonMidMid.Text == "X" && buttonBotRt.Text == "X") ||
                   (buttonTopRt.Text == "X" && buttonMidMid.Text == "X" && buttonBotLt.Text == "X");
        }

        public bool checkForOWin()
        {
            return (buttonTopLt.Text == "O" && buttonTopMid.Text == "O" && buttonTopRt.Text == "O") ||
                   (buttonMidLt.Text == "O" && buttonMidMid.Text == "O" && buttonMidRt.Text == "O") ||
                   (buttonBotLt.Text == "O" && buttonBotMid.Text == "O" && buttonBotRt.Text == "O") ||
                   (buttonTopLt.Text == "O" && buttonMidLt.Text == "O" && buttonBotLt.Text == "O") ||
                   (buttonTopMid.Text == "O" && buttonMidMid.Text == "O" && buttonBotMid.Text == "O") ||
                   (buttonTopRt.Text == "O" && buttonMidRt.Text == "O" && buttonBotRt.Text == "O") ||
                   (buttonTopLt.Text == "O" && buttonMidMid.Text == "O" && buttonBotRt.Text == "O") ||
                   (buttonTopRt.Text == "O" && buttonMidMid.Text == "O" && buttonBotLt.Text == "O");
        }

        public void reset()
        {
            Control[] buttons = new Control[] { buttonTopLt, buttonTopMid, buttonTopRt,
                                                buttonMidLt, buttonMidMid, buttonMidRt,
                                                buttonBotLt, buttonBotMid, buttonBotRt};
            foreach(Control button in buttons)
            {
                button.Text = "Z";
            }
        }

        public Control getGoodButton()
        {
            Control[] buttons = new Control[] { buttonTopLt, buttonTopMid, buttonTopRt,
                                                buttonMidLt, buttonMidMid, buttonMidRt,
                                                buttonBotLt, buttonBotMid, buttonBotRt};
            Random rand = new Random();
            bool good = false;
            while (good is false)
            {
                int randindex = rand.Next(buttons.Count());
                Control randbutton = buttons[randindex];
                if (randbutton.Text != "X" && randbutton.Text != "O") { good = true; return randbutton; }
            }
            return null;
        }
        
        public void doAITurn()
        {
            getGoodButton().Text = "O";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonTopLt_Click(object sender, EventArgs e)
        {
            buttonTopLt.Text = "X";
            if (checkForXWin()) { MessageBox.Show("You Win!", "Winner"); reset(); }
            doAITurn();
            if (checkForOWin()) { MessageBox.Show("You Lose...", "Loser"); reset(); }                    
        }

        private void buttonTopMid_Click(object sender, EventArgs e)
        {
            buttonTopMid.Text = "X";
            if (checkForXWin()) { MessageBox.Show("You Win!","Winner"); reset(); }
            doAITurn();
            if (checkForOWin()) { MessageBox.Show("You Lose...", "Loser"); reset(); }  
        }

        private void buttonTopRt_Click(object sender, EventArgs e)
        {
            buttonTopRt.Text = "X";
            if (checkForXWin()) { MessageBox.Show("You Win!", "Winner"); reset(); }
            doAITurn();
            if (checkForOWin()) { MessageBox.Show("You Lose...", "Loser"); reset(); }
        }

        private void buttonMidLt_Click(object sender, EventArgs e)
        {
            buttonMidLt.Text = "X";
            if (checkForXWin()) { MessageBox.Show("You Win!", "Winner"); reset(); }
            doAITurn();
            if (checkForOWin()) { MessageBox.Show("You Lose...", "Loser"); reset(); }
        }

        private void buttonMidMid_Click(object sender, EventArgs e)
        {
            buttonMidMid.Text = "X";
            if (checkForXWin()) { MessageBox.Show("You Win!", "Winner"); reset(); }
            doAITurn();
            if (checkForOWin()) { MessageBox.Show("You Lose...", "Loser"); reset(); }
        }

        private void buttonMidRt_Click(object sender, EventArgs e)
        {
            buttonMidRt.Text = "X";
            if (checkForXWin()) { MessageBox.Show("You Win!", "Winner"); reset(); }
            doAITurn();
            if (checkForOWin()) { MessageBox.Show("You Lose...", "Loser"); reset(); }
        }

        private void buttonBotLt_Click(object sender, EventArgs e)
        {
            buttonBotLt.Text = "X";
            if (checkForXWin()) { MessageBox.Show("You Win!", "Winner"); reset(); }
            if (checkForOWin()) { MessageBox.Show("You Lose...", "Loser"); reset(); }
            doAITurn(); 
        }

        private void buttonBotMid_Click(object sender, EventArgs e)
        {
            buttonBotMid.Text = "X";
            if (checkForXWin()) { MessageBox.Show("You Win!", "Winner"); reset(); }
            doAITurn();
            if (checkForOWin()) { MessageBox.Show("You Lose...", "Loser"); reset(); }
        }

        private void buttonBotRt_Click(object sender, EventArgs e)
        {
            buttonBotRt.Text = "X";
            if (checkForXWin()) { MessageBox.Show("You Win!", "Winner"); reset(); }
            doAITurn();
            if (checkForOWin()) { MessageBox.Show("You Lose...", "Loser"); reset(); }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
