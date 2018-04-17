using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace greeneCollegeTuition
{
    public partial class Form1 : Form
    {
        public static List<double> tuitions = new List<double>();
        public static double initTuition = 6000;

        public Form1()
        {
            InitializeComponent();

            tuitions.Add(initTuition);
            listBoxTuition.Items.Add(initTuition);

            for (int i = 0; i < 5; i++)
            {
                double newTuition = Math.Round(tuitions[i] * 1.02,2);
                tuitions.Add(newTuition);
                listBoxTuition.Items.Add(newTuition);
            }
        }
    }
}
