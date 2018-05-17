using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace charmony
{
    public partial class Form1 : Form
    {
        public List<Person> people = new List<Person>();
        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i < 100; i++) { comboBoxAge.Items.Add(i); }
            //people.Add(new Person("Mack", 16, new List<string>{ "coding" }));
        }

        public Person GetPerson(string name)
        {
            foreach (Person person in people)
            {
                if (person.name == name)
                {
                    return person;
                }
            }
            throw new Exception($"ERROR: Person with name '{name}' could not be found!");
        }

        private void buttonAddInterest_Click(object sender, EventArgs e)
        {
            if (!listBoxInterests.Items.Contains(textBoxInterest.Text) && textBoxInterest.Text != "")
            {
                listBoxInterests.Items.Add(textBoxInterest.Text);
            }
            textBoxInterest.Text = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Person newperson = new Person(textBoxFName.Text, textBoxLName.Text, (int)comboBoxAge.SelectedItem, listBoxInterests.Items.Cast<String>().ToList());
            people.Add(newperson); listBoxPeople.Items.Add(newperson.ToString());
        }
    }

    public class Person
    {
        public string name;
        public string fname;
        public string lname;
        public int age;
        public List<string> interests = new List<string>();
        public Person(string _fname, string _lname, int _age, List<string> _interests)
        {
            fname = _fname; lname = _lname; age = _age; name = $"{fname} {lname}";
            foreach (string interest in _interests) { interests.Add(interest); }
        }

        public override string ToString()
        {
            return $"Name: {name}, Age: {age}, Interests: {}";
        }
    }
}
