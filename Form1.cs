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
    }

}
