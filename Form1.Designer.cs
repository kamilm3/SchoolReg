namespace SchoolReg
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
            button2 = new Button();
            textBox1 = new TextBox();
            studentID = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(422, 440);
            button2.Name = "button2";
            button2.Size = new Size(316, 53);
            button2.TabIndex = 1;
            button2.Text = "Enter";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14F);
            textBox1.Location = new Point(422, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(316, 39);
            textBox1.TabIndex = 2;
            // 
            // studentID
            // 
            studentID.AutoSize = true;
            studentID.Font = new Font("Myanmar Text", 14F);
            studentID.Location = new Point(481, 46);
            studentID.Name = "studentID";
            studentID.Size = new Size(195, 43);
            studentID.TabIndex = 3;
            studentID.Text = "Enter Student ID";
            studentID.Click += studentID_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Myanmar Text", 14F);
            label1.Location = new Point(548, 168);
            label1.Name = "label1";
            label1.Size = new Size(65, 43);
            label1.TabIndex = 5;
            label1.Text = "Year";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14F);
            textBox2.Location = new Point(422, 214);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(316, 39);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Myanmar Text", 14F);
            label2.Location = new Point(539, 294);
            label2.Name = "label2";
            label2.Size = new Size(74, 43);
            label2.TabIndex = 7;
            label2.Text = "Term";
            label2.Click += label2_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 14F);
            textBox3.Location = new Point(422, 340);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(316, 39);
            textBox3.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 629);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(studentID);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private TextBox textBox1;
        private Label studentID;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
    }
}
