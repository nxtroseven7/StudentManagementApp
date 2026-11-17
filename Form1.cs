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

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                string[] parts = line.Split(','); // or your separator
                dataGridView1.Rows.Add(parts);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMemoFile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormInsert f = new FormInsert();

            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadMemoFile();
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            // Step 1: Check if any row is selected
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            // Step 2: Get the selected row
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            // Step 3: Get the student ID
            string studentID = selectedRow.Cells[0].Value.ToString();

            // Step 4: Show a confirmation dialog to the user
            DialogResult result = MessageBox.Show(
                "Do you really want to delete this student?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            // Step 5: If user clicks Yes, delete the record
            if (result == DialogResult.Yes)
            {
                // Read all lines from the file
                string[] lines = File.ReadAllLines(filePath);
                List<string> updatedLines = new List<string>();

                // Copy all lines except the one to delete
                foreach (string line in lines)
                {
                    if (!line.StartsWith(studentID + ",")) // skip the line with the selected ID
                    {
                        updatedLines.Add(line);
                    }
                }

                // Write the updated lines back to the file
                File.WriteAllLines(filePath, updatedLines.ToArray());

                // Step 6: Refresh the DataGridView
                LoadMemoFile(); // This method reloads the grid from the file

                MessageBox.Show("Student deleted successfully.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
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
            }

            // Step 6: Show message if no matches found
            if (!found)
            {
                MessageBox.Show("No student found with the first name: " + searchName);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // Reloads data.txt into your view
                Form1_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
