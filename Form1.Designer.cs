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
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(170, 9);
            label1.Name = "label1";
            label1.Size = new Size(402, 37);
            label1.TabIndex = 0;
            label1.Text = "Students Management System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 118);
            label2.Name = "label2";
            label2.Size = new Size(174, 15);
            label2.TabIndex = 1;
            label2.Text = "Enter a first name to search for: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(238, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(136, 23);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(463, 114);
            button1.Name = "button1";
            button1.Size = new Size(85, 23);
            button1.TabIndex = 3;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Email, Column5 });
            dataGridView1.Location = new Point(58, 143);
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
            // button5
            // 
            button5.Location = new Point(577, 536);
            button5.Name = "button5";
            button5.Size = new Size(90, 38);
            button5.TabIndex = 12;
            button5.Text = "Refresh";
            button5.UseVisualStyleBackColor = true;

            // 
            // button4
            // 
            button4.Location = new Point(404, 536);
            button4.Name = "button4";
            button4.Size = new Size(90, 38);
            button4.TabIndex = 11;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(219, 536);
            button3.Name = "button3";
            button3.Size = new Size(90, 38);
            button3.TabIndex = 10;
            button3.Text = "Modify";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(58, 536);
            button2.Name = "button2";
            button2.Size = new Size(90, 38);
            button2.TabIndex = 9;
            button2.Text = "Insert";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 611);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Column5;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
    }
}
