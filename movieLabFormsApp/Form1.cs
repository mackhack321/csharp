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
        IDictionary<string, string> movies = new Dictionary<string, string>
            {
                { "IT", "R" },
                { "Jaws", "PG" },
                { "The SpongeBob Movie: Sponge Out of Water", "PG" },
                { "Killer Joe", "NC-17" },
                { "The Lion King", "G" },
                { "Thor: Ragnarok", "PG-13" },
                { "Madea's Family Reunion", "PG-13" },
                { "Ace Ventura: Pet Detective", "PG-13" },
                { "Deadpool", "R" }
            };

        public Form1()
        {
            InitializeComponent();
            ageDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (string i in movies.Keys)
            {
                listBoxMovies.Items.Add(i);
            }
            foreach (int i in Enumerable.Range(1, 100))
            {
                ageDropdown.Items.Add(i);
            }
        }
        
        private void run()
        {
            try
            {
                int age = int.Parse(ageDropdown.Text);
                string usrMovie = listBoxMovies.Text;
                string usrRating = movies[usrMovie];
                if (usrRating == "R" && age < 17)
                {
                    MessageBox.Show("You must be accompanied by a parent or guardian to watch this film", "This film is rated R");
                }
                else if (usrRating == "NC-17" && age < 18)
                {
                    MessageBox.Show("You are not permitted to watch this film", "This film is rated NC-17");
                }
                else if (usrRating == "PG-13" && age < 13)
                {
                    MessageBox.Show("Parents are urged to be cautious of permitting their pre-teen to watch this film", "This film is rated PG-13");
                }
                else
                {
                    MessageBox.Show("Enjoy the film", $"This film is rated {usrRating}");
                }

            }
            catch
            {
                if (listBoxMovies.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a movie", "Error");
                }
                else if (ageDropdown.SelectedIndex == -1)
                {
                    MessageBox.Show("Please enter your age", "Error");
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelRatingLetter.Text = movies[Convert.ToString(listBoxMovies.SelectedItem)];
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            run();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxMovies_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            run();
        }

        private void listBoxMovies_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData is Keys.Return)
            {
                run();
            }
        }
    }
}
