namespace StudentManagementApp
{
    partial class StudentModify
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            richTextBox1 = new RichTextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(77, 368);
            button1.Name = "button1";
            button1.Size = new Size(116, 56);
            button1.TabIndex = 27;
            button1.Text = "Modify Informations";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(328, 371);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 25;
            label7.Text = "Email :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(305, 99);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 24;
            label6.Text = "Birth Date :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(315, 239);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 22;
            label5.Text = "Address :";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(381, 169);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(209, 150);
            richTextBox1.TabIndex = 21;
            richTextBox1.Text = "";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(118, 248);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 20;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(118, 169);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 19;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(118, 107);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 251);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 17;
            label4.Text = "Last Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 172);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 16;
            label3.Text = "First Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 110);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 15;
            label2.Text = "StudentID :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(132, 23);
            label1.Name = "label1";
            label1.Size = new Size(357, 30);
            label1.TabIndex = 14;
            label1.Text = "Modify the Informations of a Student";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(376, 99);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(209, 23);
            textBox4.TabIndex = 26;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(381, 371);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(209, 23);
            textBox5.TabIndex = 28;
            // 
            // StudentModify
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 450);
            Controls.Add(textBox5);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(richTextBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StudentModify";
            Text = "StudentModify";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label7;
        private Label label6;
        private Label label5;
        private RichTextBox richTextBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}