using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementApp
{
    public partial class FormInsert : Form
    {
        public FormInsert()
        {
            InitializeComponent();
        }

        string filePath = "C:\\Users\\Admin\\source\\repos\\StudentManagementApp\\data.txt";

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Student ID cannot be empty.");
                return;
            }

            if (!int.TryParse(textBox1.Text, out int newStudentId))
            {
                MessageBox.Show("Student ID must be a valid number.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("First Name cannot be empty.");
                return;
            }
            else if (!textBox2.Text.All(char.IsLetter))
            {
                MessageBox.Show("Please enter letters only for the First Name (no numbers, spaces, or symbols).");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Last Name cannot be empty.");
                return;
            }
            else if (!textBox3.Text.All(char.IsLetter))
            {
                MessageBox.Show("Please enter letters only for the Last Name (no numbers, spaces, or symbols).");
                return;
            }

            DateTime birthDate = dateTimePicker1.Value.Date;
            DateTime today = DateTime.Today;

            if (birthDate > today)
            {
                MessageBox.Show("Birth date cannot be in the future.");
                dateTimePicker1.Focus();
                return;
            }

            int age = today.Year - birthDate.Year;
            if (birthDate > today.AddYears(-age))
            {
                age--;
            }

            if (age < 17 || age > 30)
            {
                MessageBox.Show("The student's age must be between 17 and 30 years old.");
                dateTimePicker1.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                MessageBox.Show("Address cannot be empty.");
            }

            if (!textBox4.Text.EndsWith("@ensia.edu.dz", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Email must end with @ensia.edu.dz!");
                return;
            }


            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string existingLine in lines)
                {
                    string[] parts = existingLine.Split(',');
                    if (parts.Length > 0 && parts[0] == textBox1.Text)
                    {
                        MessageBox.Show("A student with this ID already exists!");
                        textBox1.Focus();
                        return;
                    }
                }
            }

            string line =
                textBox1.Text + "," +                        // StudentID
                textBox2.Text + "," +                        // First Name
                textBox3.Text + "," +                        // Last Name
                birthDate.ToShortDateString() + "," +         // BirthDate
                richTextBox1.Text + "," +                    // Address
                textBox4.Text;                                       // Email


            File.AppendAllText(filePath, line + Environment.NewLine);


            this.DialogResult = DialogResult.OK;
            this.Close();
        }


    }
}
