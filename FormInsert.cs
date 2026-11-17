using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            // Build one line of text representing a student.
            // Each field is separated by a comma.
            string line =
                textBox1.Text + "," +                //StudentID
                textBox2.Text + "," +                //First Name
                textBox3.Text + "," +                //Last Name
                dateTimePicker1.Value.ToShortDateString() + "," + //BirthDate
                richTextBox1.Text + "," +            //Address
                textBox4.Text;                       //Email

            // Append the new student record to the memo file.
            // A new line is added at the end so the next record appears on the next line.
            File.AppendAllText(filePath, line + Environment.NewLine);

            // Close the form and return OK to indicate that insertion was successful.
            this.DialogResult = DialogResult.OK; //sends DialogResult.OK
            this.Close();
        }
    }
}
