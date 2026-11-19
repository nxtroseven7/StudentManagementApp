using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace StudentManagementApp
{
    public partial class StudentModify : Form
    {
        private readonly string filePath = @"C:\Users\Admin\source\repos\StudentManagementApp\data.txt";
        private readonly string originalID;

        public StudentModify()
        {
            InitializeComponent();
        }

        public StudentModify(string id, string firstName, string lastName, string birthDate, string address, string email)
        {
            InitializeComponent();

            originalID = id;
            textBox1.Text = id;
            textBox2.Text = firstName;
            textBox3.Text = lastName;
            textBox4.Text = birthDate;
            richTextBox1.Text = address;
            textBox5.Text = email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idText = textBox1.Text.Trim();
            string firstName = textBox2.Text.Trim();
            string lastName = textBox3.Text.Trim();
            string dateText = textBox4.Text.Trim();
            string address = richTextBox1.Text.Trim();
            string email = textBox5.Text.Trim();


            if (!int.TryParse(idText, out int newStudentId))
            {
                MessageBox.Show("Please enter a valid numeric Student ID.");
                textBox1.Focus();
                return;
            }

            if (string.IsNullOrEmpty(firstName) || !firstName.All(char.IsLetter))
            {
                MessageBox.Show("First Name must contain letters only.");
                textBox2.Focus();
                return;
            }

            if (string.IsNullOrEmpty(lastName) || !lastName.All(char.IsLetter))
            {
                MessageBox.Show("Last Name must contain letters only.");
                textBox3.Focus();
                return;
            }

            if (!DateTime.TryParseExact(dateText, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime birthDate))
            {
                MessageBox.Show("Enter a valid date in dd/MM/yyyy format.");
                textBox4.Focus();
                return;
            }

            DateTime today = DateTime.Today;
            if (birthDate.Date > today)
            {
                MessageBox.Show("Birth date cannot be in the future.");
                textBox4.Focus();
                return;
            }

            int age = today.Year - birthDate.Year;
            if (birthDate.Date > today.AddYears(-age))
            {
                age--;
            }

            if (age < 17 || age > 30)
            {
                MessageBox.Show("Age must be between 17 and 30.");
                textBox4.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Address cannot be empty.");
                richTextBox1.Focus();
                return;
            }

            if (!email.EndsWith("@ensia.edu.dz", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Email must end with @ensia.edu.dz.");
                textBox5.Focus();
                return;
            }

  
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Data file not found.");
                return;
            }

            string[] lines = File.ReadAllLines(filePath);
            string newIdString = newStudentId.ToString();
            bool updated = false;

            for (int i = 0; i < lines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i])) continue;

                string[] parts = lines[i].Split(',');
                string currentId = parts[0].Trim();

                // Block if changing to an ID already used by another student
                if (newIdString != originalID?.Trim() && currentId == newIdString)
                {
                    MessageBox.Show("A student with this Student ID already exists.");
                    textBox1.Focus();
                    return;
                }

                if (currentId == originalID?.Trim())
                {
                    string cleanAddress = address.Replace("\r", " ").Replace("\n", " ");
                    lines[i] = $"{newIdString},{firstName},{lastName},{birthDate:dd/MM/yyyy},{cleanAddress},{email}";
                    updated = true;
                }
            }

            if (!updated)
            {
                MessageBox.Show("Student ID not found.");
                return;
            }

            File.WriteAllLines(filePath, lines);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}