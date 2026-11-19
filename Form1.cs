using System.Globalization;

namespace StudentManagementApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string filePath = "C:\\Users\\Admin\\source\\repos\\StudentManagementApp\\data.txt";


        private void LoadMemoFile()
        {
            dataGridView1.Rows.Clear();

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
                return;
            }

            string[] lines = File.ReadAllLines(filePath);
            string choice = comboBox1.Text.Trim();

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                if (line.Count(c => c == ',') != 5) continue;

                string[] parts = line.Split(',');

                switch (choice)
                {
                    case "StudentID":
                        dataGridView1.Rows.Add(parts[0].Trim(), "", "", "", "", "");
                        break;

                    case "FirstName":
                        dataGridView1.Rows.Add("", parts[1].Trim(), "", "", "", "");
                        break;

                    case "LastName":
                        dataGridView1.Rows.Add("", "", parts[2].Trim(), "", "", "");
                        break;

                    case "Birthdate":
                        dataGridView1.Rows.Add("", "", "", parts[3].Trim(), "", "");
                        break;

                    case "Address":
                        dataGridView1.Rows.Add("", "", "", "", parts[4].Trim(), "");
                        break;

                    case "Email":
                        dataGridView1.Rows.Add("", "", "", "", "", parts[5].Trim());
                        break;

                    default:
                        dataGridView1.Rows.Add(
                            parts[0].Trim(),
                            parts[1].Trim(),
                            parts[2].Trim(),
                            parts[3].Trim(),
                            parts[4].Trim(),
                            parts[5].Trim()
                        );
                        break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMemoFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Step 1: Get the search term from the TextBox
            string searchName = textBox1.Text.Trim();

            // Step 2: Validate input
            if (string.IsNullOrEmpty(searchName))
            {
                MessageBox.Show("Please enter a first name to search.");
                return;
            }

            // Step 3: Clear the DataGridView to show only results
            dataGridView1.Rows.Clear();

            // Step 4: Read all lines from the file
            string[] lines = File.ReadAllLines(filePath);

            // Step 5: Loop through each line to find matches
            bool found = false; // flag to check if any matches exist
            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                // Split the line into fields
                string[] parts = line.Split(',');

                // parts[1] is First Name (ID=0, First Name=1)
                if (parts[1].Equals(searchName, StringComparison.OrdinalIgnoreCase))
                {
                    // Add the matching row to the DataGridView
                    dataGridView1.Rows.Add(parts);
                    found = true;
                }

                if (parts[2].Equals(searchName, StringComparison.OrdinalIgnoreCase))
                {
                    // Add the matching row to the DataGridView
                    dataGridView1.Rows.Add(parts);
                    found = true;
                }

                if (parts[5].Equals(searchName, StringComparison.OrdinalIgnoreCase))
                {
                    // Add the matching row to the DataGridView
                    dataGridView1.Rows.Add(parts);
                    found = true;
                }
            }

            // Step 6: Show message if no matches found
            if (!found)
            {
                MessageBox.Show("No student found with the first name: " + searchName);
            }
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMemoFile();
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                LoadMemoFile();
            }
            else
            {
                MessageBox.Show("Error in the import of the Data file!");
            }

        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                List<string> lines = new List<string>();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                        lines.Add(string.Join(",", row.Cells.Cast<DataGridViewCell>().Select(c => c.Value?.ToString() ?? "")));
                }

                File.WriteAllLines(sfd.FileName, lines);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FormInsert f = new FormInsert();

            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadMemoFile();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to modify.");
                return;
            }

            DataGridViewRow row = dataGridView1.SelectedRows[0];

            // Pass all values to the edit form
            StudentModify f = new StudentModify(
                row.Cells[0].Value.ToString(), // StudentID
                row.Cells[1].Value.ToString(), // First Name
                row.Cells[2].Value.ToString(), // Last Name
                row.Cells[3].Value.ToString(), // Birth Date
                row.Cells[4].Value.ToString(),
                row.Cells[5].Value.ToString()// Address
                                             // Email
            );

            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadMemoFile(); // Refresh grid with updated data
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            string studentID = selectedRow.Cells[0].Value.ToString();

            DialogResult result = MessageBox.Show(
                "Do you really want to delete this student?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                string[] lines = File.ReadAllLines(filePath);
                List<string> updatedLines = new List<string>();


                foreach (string line in lines)
                {
                    if (!line.StartsWith(studentID + ","))
                    {
                        updatedLines.Add(line);
                    }
                }

                File.WriteAllLines(filePath, updatedLines.ToArray());

                LoadMemoFile();

                MessageBox.Show("Student deleted successfully.");
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                Form1_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
