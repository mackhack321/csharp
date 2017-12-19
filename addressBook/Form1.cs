using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace addressBook
{
    public partial class Form1 : Form
    {
        //this sets up the personal information of each entry
        class data
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string age { get; set; }
            public string phone { get; set; }
        }

        //this function prints the first name of each entry to the console when called
        public void debug() 
        {
            foreach (var entry in dictionary) { if (entry != null) { Console.WriteLine(entry.firstName);} }
        }

        //this inits an array of entries with 100 slots
        data[] dictionary = new data[100]; 

        public Form1()
        {
            InitializeComponent();
            //this fills the age dropdown with numbers 1-100
            for (int i = 0; i < 101; i++) { comboBoxAge.Items.Add(i); } 
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (textBoxFName.Text is "" || textBoxLName.Text is "" || textBoxPhone.Text is "" || comboBoxAge.Text is "")
            {
                //if any field is empty, show an error box
                MessageBox.Show("Please fill in all fields", "Error"); 
            }

            //if all fields are filled
            else
            {
                for (int i = 0; i < 101; i++)
                {
                    //checks for empty slots in the array
                    if (dictionary[i] is null)
                    {
                        //inits a new instance of the data class
                        dictionary[i] = new data 
                        {
                            //sets data class objects to data from each field
                            firstName = textBoxFName.Text,
                            lastName = textBoxLName.Text, 
                            age = comboBoxAge.Text,
                            phone = textBoxPhone.Text
                        };
                        //adds new entry to grid view
                        dataGridView1.Rows.Add(dictionary[i].firstName, dictionary[i].lastName, dictionary[i].phone, dictionary[i].age);
                        //empties fields
                        textBoxFName.Clear(); textBoxLName.Clear(); textBoxPhone.Clear(); comboBoxAge.Text = "";
                        //stop checking for empty slots
                        break;
                    }
                }
            }
            debug();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {           
            try
            {
                //sets index of selected row to int var for easy reference
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                                
                for (int i = 0; i < 101; i++)
                {
                    //checks for occupied slots in array
                    if (dictionary[i] != null)
                    {
                        //sets phone number of entry on selected row to string var
                        string phoneToDel = dataGridView1[2, selectedRowIndex].Value.ToString();
                        //sets entry in array to null if phone in array matches phone in row
                        if (dictionary[i].phone == phoneToDel) { dictionary[i] = null; }
                        break;
                    }
                }
                //removes entry from grid view
                dataGridView1.Rows.RemoveAt(selectedRowIndex);
            }           
            //throw error box if no row is selected
            catch (ArgumentOutOfRangeException){ MessageBox.Show("Please select a row", "Error"); }
            //throw error box if selected row is the bottom new row
            catch (InvalidOperationException) { MessageBox.Show("Cannot delete new row", "Error"); }
            debug();
        }
    }
}
