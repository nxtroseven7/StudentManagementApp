using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO; // Make sure you have this for File methods
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementApp
{
    public partial class StudentModify : Form
    {
        string filePath = "C:\\Users\\Admin\\source\\repos\\StudentManagementApp\\data.txt";
        private string originalID; // <-- Added this declaration to fix the missing variable error

        public StudentModify()
        {
            InitializeComponent();
        }

        public StudentModify(string id, string firstName, string lastName, string birthDate, string address,string email)
        {
            InitializeComponent();

            originalID = id;

            textBox1.Text = id;
            textBox2.Text = firstName;
            textBox3.Text = lastName;
            textBox4.Text = birthDate;
            richTextBox1.Text = address;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Step 1: Parse the birth date from the TextBox safely
            // Expecting format "dd/MM/yyyy"
            DateTime birthDate;
            if (!DateTime.TryParseExact(
                textBox4.Text,
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out birthDate))
            {
                // Show an error message if the date format is incorrect
                MessageBox.Show("Please enter a valid date in dd/MM/yyyy format.");
                return; // Stop saving if the date is invalid
            }

            // Step 2: Load all student records from the file into an array
            string[] lines = File.ReadAllLines(filePath);

            // Step 3: Flag to check if we actually updated a line
            bool updated = false;

            // Step 4: Loop through all lines to find the student to update
            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');

                // Match the student by original ID
                if (parts[0] == originalID)
                {
                    // Replace this line with the updated values
                    lines[i] =
                        textBox1.Text + "," +                   // Student ID
                        textBox2.Text + "," +                   // First Name
                        textBox3.Text + "," +                   // Last Name
                        birthDate.ToShortDateString() + "," +   // Birth Date as string
                        richTextBox1.Text + ",";                      // email

                    updated = true; // Mark as updated
                    break; // Exit loop since we found the student
                }
            }

            // Step 5: If no matching ID was found, show a message
            if (!updated)
            {
                MessageBox.Show("Student ID not found. Update failed.");
                return;
            }

            // Step 6: Write all lines back to the file (overwrite the file)
            File.WriteAllLines(filePath, lines);

            // Step 7: Return OK to main form
            this.DialogResult = DialogResult.OK;

            // Step 8: Close the modification form
            this.Close();
        }
    }
}