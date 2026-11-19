namespace StudentManagementApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            comboBox1 = new ComboBox();
            label3 = new Label();
            panel6 = new Panel();
            button15 = new Button();
            label5 = new Label();
            textBox1 = new TextBox();
            panel7 = new Panel();
            panel1 = new Panel();
            ExportButton = new Button();
            ImportButton = new Button();
            panel2 = new Panel();
            button5 = new Button();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.CornflowerBlue;
            label1.Font = new Font("Segoe UI Symbol", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.AliceBlue;
            label1.Location = new Point(298, 27);
            label1.Name = "label1";
            label1.Size = new Size(402, 37);
            label1.TabIndex = 0;
            label1.Text = "Students Management System⁭";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.RoyalBlue;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Email, Column5 });
            dataGridView1.Location = new Point(12, 105);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(644, 369);
            dataGridView1.TabIndex = 4;
            // 
            // Column1
            // 
            Column1.HeaderText = "StudentID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "FirstName";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "LastName";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "BirthDate";
            Column4.Name = "Column4";
            // 
            // Email
            // 
            Email.HeaderText = "Address";
            Email.Name = "Email";
            // 
            // Column5
            // 
            Column5.HeaderText = "Email";
            Column5.Name = "Column5";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "All Informations", "StudentID", "FirstName", "LastName", "BirthDate", "Address", "Email" });
            comboBox1.Location = new Point(88, 7);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(232, 23);
            comboBox1.TabIndex = 13;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(-2, 10);
            label3.Name = "label3";
            label3.Size = new Size(89, 17);
            label3.TabIndex = 14;
            label3.Text = "Enter to Sort :";
            // 
            // panel6
            // 
            panel6.BackColor = Color.RoyalBlue;
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(button15);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(textBox1);
            panel6.Location = new Point(665, 458);
            panel6.Name = "panel6";
            panel6.Size = new Size(330, 128);
            panel6.TabIndex = 20;
            // 
            // button15
            // 
            button15.Location = new Point(117, 67);
            button15.Name = "button15";
            button15.Size = new Size(90, 38);
            button15.TabIndex = 3;
            button15.Text = "Search";
            button15.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(103, 7);
            label5.Name = "label5";
            label5.Size = new Size(104, 17);
            label5.TabIndex = 1;
            label5.Text = "Enter to Search :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(312, 23);
            textBox1.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.BackColor = Color.RoyalBlue;
            panel7.BorderStyle = BorderStyle.Fixed3D;
            panel7.Controls.Add(label3);
            panel7.Controls.Add(comboBox1);
            panel7.Location = new Point(665, 105);
            panel7.Name = "panel7";
            panel7.Size = new Size(330, 165);
            panel7.TabIndex = 20;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(ExportButton);
            panel1.Controls.Add(ImportButton);
            panel1.Location = new Point(668, 290);
            panel1.Name = "panel1";
            panel1.Size = new Size(330, 128);
            panel1.TabIndex = 21;
            // 
            // ExportButton
            // 
            ExportButton.Location = new Point(55, 38);
            ExportButton.Name = "ExportButton";
            ExportButton.Size = new Size(90, 38);
            ExportButton.TabIndex = 1;
            ExportButton.Text = "Export";
            ExportButton.UseVisualStyleBackColor = true;
            ExportButton.Click += ExportButton_Click;
            // 
            // ImportButton
            // 
            ImportButton.Location = new Point(183, 38);
            ImportButton.Name = "ImportButton";
            ImportButton.Size = new Size(90, 38);
            ImportButton.TabIndex = 0;
            ImportButton.Text = "Import";
            ImportButton.UseVisualStyleBackColor = true;
            ImportButton.Click += ImportButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(12, 480);
            panel2.Name = "panel2";
            panel2.Size = new Size(644, 106);
            panel2.TabIndex = 22;
            // 
            // button5
            // 
            button5.Location = new Point(492, 32);
            button5.Name = "button5";
            button5.Size = new Size(90, 38);
            button5.TabIndex = 2;
            button5.Text = "Refresh";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(180, 32);
            button3.Name = "button3";
            button3.Size = new Size(90, 38);
            button3.TabIndex = 1;
            button3.Text = "Modify";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.Location = new Point(340, 32);
            button4.Name = "button4";
            button4.Size = new Size(90, 38);
            button4.TabIndex = 1;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(30, 32);
            button2.Name = "button2";
            button2.Size = new Size(90, 38);
            button2.TabIndex = 0;
            button2.Text = "Insert";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1010, 598);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel6);
            Controls.Add(panel7);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Student Management Application";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Column5;
        private ComboBox comboBox1;
        private Label label3;
        private Panel panel6;
        private Button button15;
        private Label label5;
        private TextBox textBox1;
        private Panel panel7;
        private Panel panel1;
        private Button ImportButton;
        private Button ExportButton;
        private Panel panel2;
        private Button button5;
        private Button button3;
        private Button button4;
        private Button button2;
    }
}
