﻿using System;
using System.Collections.Generic;
using System.Linq;
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
                { "WALL-E", "G" },
                { "Madea's Family Reunion", "PG-13" },
                { "Finding Nemo", "G" },
                { "Ace Ventura: Pet Detective", "PG-13" },
                { "Deadpool", "R" },
                { "Wonder", "PG" },
                { "Wonder Woman", "PG-13" },                
                { "Monsters, Inc.", "G" }
            };

        public Form1()
        {
            InitializeComponent();
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
                if (listBoxMovies.SelectedIndex == -1 && ageDropdown.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a movie and your age", "Error");
                }
                else if (listBoxMovies.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a movie", "Error");
                }
                else if (ageDropdown.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select your age", "Error");
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {           
            try
            {
                labelRatingLetter.Text = movies[Convert.ToString(listBoxMovies.SelectedItem)];
            }
            catch (KeyNotFoundException)
            {
                labelRatingLetter.Text = "";
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            ageDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            for (int index = 0; index < movies.Count; index++)
            {
                listBoxMovies.Items.Add(movies.ElementAt(index).Key);
            }
            for (int i = 1; i < 101; i++)
            {
                ageDropdown.Items.Add(i);
            }
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

        private void ageDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            int age = int.Parse(ageDropdown.Text);
            for (int index = 0; index < movies.Count; index++)
            {
                string rating = movies.ElementAt(index).Value;
                if (rating is "R")
                {
                    if (age < 17)
                    {
                        listBoxMovies.Items.Remove(movies.ElementAt(index).Key);
                    }
                    else
                    {
                        if (!listBoxMovies.Items.Contains(movies.ElementAt(index).Key))
                        {
                            listBoxMovies.Items.Add(movies.ElementAt(index).Key);
                        }
                    }
                }
                if (rating is "NC-17")
                {
                    if (age < 17)
                    {
                        listBoxMovies.Items.Remove(movies.ElementAt(index).Key);
                    }
                    else
                    {
                        if (!listBoxMovies.Items.Contains(movies.ElementAt(index).Key))
                        {
                            listBoxMovies.Items.Add(movies.ElementAt(index).Key);
                        }
                    }
                }
            }
        }
    }
}
