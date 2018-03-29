using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.IO;
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

        public bool checkForWin(string player)
        {
            return (buttonTopLt.Text == player && buttonTopMid.Text == player && buttonTopRt.Text == player) ||
                   (buttonMidLt.Text == player && buttonMidMid.Text == player && buttonMidRt.Text == player) ||
                   (buttonBotLt.Text == player && buttonBotMid.Text == player && buttonBotRt.Text == player) ||
                   (buttonTopLt.Text == player && buttonMidLt.Text == player && buttonBotLt.Text == player) ||
                   (buttonTopMid.Text == player && buttonMidMid.Text == player && buttonBotMid.Text == player) ||
                   (buttonTopRt.Text == player && buttonMidRt.Text == player && buttonBotRt.Text == player) ||
                   (buttonTopLt.Text == player && buttonMidMid.Text == player && buttonBotRt.Text == player) ||
                   (buttonTopRt.Text == player && buttonMidMid.Text == player && buttonBotLt.Text == player);
        }

        public void reset()
        {
            Button[] buttons = new Button[] { buttonTopLt, buttonTopMid, buttonTopRt,
                                                buttonMidLt, buttonMidMid, buttonMidRt,
                                                buttonBotLt, buttonBotMid, buttonBotRt};
            foreach(Button button in buttons)
            {
                button.Text = "";
                button.BackColor = Color.Transparent;
            }
        }

        public Button getGoodButton()
        {
            Button[] buttons = new Button[] { buttonTopLt, buttonTopMid, buttonTopRt,
                                                buttonMidLt, buttonMidMid, buttonMidRt,
                                                buttonBotLt, buttonBotMid, buttonBotRt};
            Random rand = new Random();
            foreach (int i in Enumerable.Range(0, buttons.Count()))
            {
                int randindex = rand.Next(0,buttons.Count());
                Button randbutton = buttons[randindex];
                if (randbutton.Text != "X" && randbutton.Text != "O") { return randbutton; }
            }
            return null;
        }

        public void doPlayerTurn(Button button)
        {
            if (button.Text == "O" || button.Text == "X") { MessageBox.Show("Spot already taken.  You lose a turn...", "Error"); return; }
            button.Text = "X";
            button.BackColor = Color.Green;
            if (checkForWin("X")) { MessageBox.Show("You Win!", "Winner"); reset(); }
        }
        
        public void doAITurn()
        {
            Button goodButton = getGoodButton();
            if (goodButton is null) { MessageBox.Show("It's a Tie!", "Tie Game"); reset(); return; }
            goodButton.Text = "O";
            goodButton.BackColor = Color.Gold;

            if (checkForWin("O")) { MessageBox.Show("You Lose...", "Loser"); reset(); }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAnyClick(object sender, EventArgs e)
        {
            doPlayerTurn(sender as Button);
            doAITurn();
        }
    }
}
