using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using dogs;

namespace dogregistry
{
    public partial class Registry : Form
    {
        public List<Dog> dogls = new List<Dog>();
        public bool hasLoaded = false;
        public bool hasDumped = false;

        public Registry()
        {
            InitializeComponent();
            comboBoxAge.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRating.DropDownStyle = ComboBoxStyle.DropDownList;
            for (int i = 1; i <=100; i++) { comboBoxAge.Items.Add(i); } // populate age box
            for (int i = 0; i <= 10; i++) { comboBoxRating.Items.Add(i); } // populate rating box
            loadDogs();
        }

        public Dog findDog(string name)
        {
            foreach (Dog dog in dogls)
            {
                if (dog.name == name) { return dog; }
            }
            return null;
        }

        public void dumpDogs()
        {
            if (!hasDumped)
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("Dogfile.woof", FileMode.Create, FileAccess.Write, FileShare.None);
                foreach (Dog dog in dogls)
                {
                    formatter.Serialize(stream, dog);
                }
                stream.Close();
            }
        }

        public void loadDogs()
        {
            if (!hasLoaded)
            {
                IFormatter formatter = new BinaryFormatter();
                try
                {
                    Stream stream = new FileStream("Dogfile.woof", FileMode.Open, FileAccess.Read, FileShare.Read);
                    while (stream.Position != stream.Length)
                    {
                        Dog dog = (Dog)formatter.Deserialize(stream);
                        listBoxDogs.Items.Add(dog.name);
                        dogls.Add(dog);
                    }
                    stream.Close();
                } catch (FileNotFoundException) {  }
            }
        }

        private void listBoxDogs_DoubleClick(object sender, EventArgs e)
        {
            Dog selected = findDog(listBoxDogs.SelectedItem.ToString());
            MessageBox.Show($"Name: {selected.name}\nAge: {selected.age}\nRating: {selected.rating}/10", "Dog Registry");
        }

        private void buttonDump_Click(object sender, EventArgs e)
        {
            dumpDogs();
            hasDumped = true;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            loadDogs();
            hasLoaded = true;
        }

        private void listBoxDogs_Click(object sender, EventArgs e)
        {
            try
            {
                Dog s = findDog(listBoxDogs.SelectedItem.ToString());
                labelSelAge.Text = comboBoxAge.Text = s.age.ToString();
                labelSelName.Text = textBoxName.Text = s.name;
                labelSelRating.Text = $"{s.rating}/10"; comboBoxRating.Text = s.rating.ToString();
                labelSelAge.Visible = true; labelSelName.Visible = true; labelSelRating.Visible = true;
            } catch (NullReferenceException) { }           
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            if (findDog(name) == null)
            {
                int age = int.Parse(comboBoxAge.SelectedItem.ToString());
                int rating = int.Parse(comboBoxRating.SelectedItem.ToString());
                Dog newdog = new Dog(name, age, rating);
                listBoxDogs.Items.Add(newdog.name);
                dogls.Add(newdog);
            }
            else
            {
                Dog dog = findDog(name);
                dog.age = int.Parse(comboBoxAge.SelectedItem.ToString()); dog.rating = int.Parse(comboBoxRating.SelectedItem.ToString());
            }
        }

        private void Registry_FormClosing(object sender, FormClosingEventArgs e)
        {
            dumpDogs();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            Dog s = findDog(listBoxDogs.SelectedItem.ToString());
            dogls.Remove(s); listBoxDogs.Items.Remove(s.name);
        }
    }
}
