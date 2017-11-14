using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace movieLabFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (int i in Enumerable.Range(1, 100))
            {
                ageDropdown.Items.Add(i);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            IDictionary<string, string> movies = new Dictionary<string, string>
            {
                { "IT", "R" },
                { "Jaws", "PG" },
                { "The SpongeBob Movie: Sponge Out of Water", "PG" },
                { "Killer Joe", "NC-17" },
                { "The Lion King", "G" },
                { "Thor: Ragnarok", "PG-13" }
            };
            try
            {
                int age = int.Parse(ageDropdown.Text);
                string usrMovie = listBox1.Text;
                string usrRating = movies[usrMovie];
                if (usrRating == "R" && age < 17)
                {
                    MessageBox.Show("You must be accompanied by a parent or guardian to watch this film", "Advisory");
                }
                else if (usrRating == "NC-17" && age < 18)
                {
                    MessageBox.Show("You are not permitted to watch this film", "Advisory");
                }
                else if (usrRating == "PG-13" && age < 13)
                {
                    MessageBox.Show("Parents are urged to be cautious of permitting their pre-teen to watch this film", "Advisory");
                }
                else
                {
                    MessageBox.Show("Enjoy the film", "Notification");
                }
            }
            catch (Exception ex)
            {
                if (listBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a movie", "Error");
                }
                else if (ageDropdown.SelectedIndex == -1)
                {
                    MessageBox.Show("Please enter your age", "Error");
                }
            }

        }
    }
}
