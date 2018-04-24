using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rating
{
    public partial class Form1 : Form
    {
        private List<PictureBox> stars = new List<PictureBox>();

        public Form1()
        {
            InitializeComponent();
            stars.Add(pictureBox1); stars.Add(pictureBox2); stars.Add(pictureBox3); stars.Add(pictureBox4); stars.Add(pictureBox5);
        }

        private PictureBox getControlByStringName(string name)
        {
            foreach (PictureBox item in stars)
            {
                if (name == item.Name){ return item; }
            }
            throw new Exception("getControlByStringName() failed!");
        }

        private void resetStars()
        {
            foreach (PictureBox item in stars)
            {
                item.Image = Properties.Resources.star;
                item.Tag = "empty";
            }
        }

        private bool starIsNotFilled(PictureBox pictureBox)
        {
            return pictureBox.Tag.ToString() == "empty";
        }

        private void pictureBox1_Click(object sender, EventArgs e) // called when ANY star is clicked
        {
            Console.WriteLine(starIsNotFilled((PictureBox)sender));
            if (starIsNotFilled((PictureBox)sender))
            {
                string name = ((PictureBox)sender).Name;
                int index = stars.IndexOf(getControlByStringName(name));
                for (int i = index; i >= 0; i--)
                {
                    stars[i].Image = Properties.Resources.starfilled;
                    stars[i].Tag = "filled";
                }
            }
            else { resetStars(); }
        }
    }
}
