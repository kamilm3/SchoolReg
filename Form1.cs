using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SchoolReg
{
    public partial class Form1 : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public Form1()
        {
            InitializeComponent();


            myConnection = new SqlConnection("user id=admin3;" + // Username
                                  "password=admin;" + // Password
                                  "server=LAPTOP-6TEGHEN2;" + // Server name
                                  "TrustServerCertificate=True;" +
                                  "database=SchoolReg; " + // Database
                                  "connection timeout=30"); // Timeout in seconds


            /*
            myConnection = new SqlConnection("user id=admin;" + // Username
                                  "password=admin;" + // Password
                                  "server=Kamil\\MSSQLSERVER03;" + // Server name
                                  "TrustServerCertificate=True;" +
                                  "database=SchoolReg; " + // Database
                                  "connection timeout=30"); // Timeout in seconds
            */



            try
            {
                myConnection.Open(); // Open the connection
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection; // Link the command to the connection
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }
        }

        private void InitializeComponent()
        {
            emailAddressInput = new System.Windows.Forms.TextBox();
            label2 = new Label();
            label1 = new Label();
            studentIDInput = new System.Windows.Forms.TextBox();
            label3 = new Label();
            sqlCommand1 = new SqlCommand();
            nextButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // emailAddressInput
            // 
            emailAddressInput.Font = new Font("Segoe UI", 14F);
            emailAddressInput.Location = new Point(53, 240);
            emailAddressInput.Name = "emailAddressInput";
            emailAddressInput.Size = new Size(439, 39);
            emailAddressInput.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(53, 205);
            label2.Name = "label2";
            label2.Size = new Size(232, 32);
            label2.TabIndex = 6;
            label2.Text = "Enter Email Address";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 97);
            label1.Name = "label1";
            label1.Size = new Size(194, 32);
            label1.TabIndex = 0;
            label1.Text = "Enter Student ID";
            label1.Click += label1_Click;
            // 
            // studentIDInput
            // 
            studentIDInput.Font = new Font("Segoe UI", 14F);
            studentIDInput.Location = new Point(54, 132);
            studentIDInput.Name = "studentIDInput";
            studentIDInput.Size = new Size(439, 39);
            studentIDInput.TabIndex = 2;
            studentIDInput.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(192, 0, 0);
            label3.Location = new Point(53, 27);
            label3.Name = "label3";
            label3.Size = new Size(287, 41);
            label3.TabIndex = 4;
            label3.Text = "Course Registration";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // nextButton
            // 
            nextButton.BackColor = Color.FromArgb(192, 0, 0);
            nextButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nextButton.ForeColor = Color.White;
            nextButton.Location = new Point(53, 315);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(202, 44);
            nextButton.TabIndex = 5;
            nextButton.Text = "Next";
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += nextButton_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(526, 445);
            Controls.Add(emailAddressInput);
            Controls.Add(label2);
            Controls.Add(nextButton);
            Controls.Add(label3);
            Controls.Add(studentIDInput);
            Controls.Add(label1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void studentID_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private Label label1;

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private System.Windows.Forms.TextBox studentIDInput;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private System.Windows.Forms.TextBox emailAddressInput;
        private Label label2;
        private Label label3;
        private SqlCommand sqlCommand1;
        private System.Windows.Forms.Button nextButton;

        private void nextButton_Click(object sender, EventArgs e)
        {
            string studentIDBox = studentIDInput.Text.Trim();


            string emailAddressBox = emailAddressInput.Text.Trim();

            

            //convert input field of student ID to int
            //int studentID = int.Parse(studentIDInput.Text);
            //int studentID = int.Parse(studentIDBox);

            //MessageBox.Show("Test" + emailAddressBox + studentIDBox);

            if (string.IsNullOrEmpty(emailAddressBox) || string.IsNullOrEmpty(studentIDBox))
            {

                MessageBox.Show("Please enter email address and password");
                return;

            }
            else if (!int.TryParse(studentIDBox, out int studentID))
            {
                MessageBox.Show("Please enter numbers only for Student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int studentID = Convert.ToInt32(studentIDBox);

                //query to check if student ID and Email address exists in the database
                string query = "SELECT count(*) FROM Student WHERE StudentID = @studentID AND Email = @emailAddressBox";
                //MessageBox.Show("Test");

                //Create SQL command
                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
                    cmd.Parameters.AddWithValue("@emailAddressBox", emailAddressBox);
                    cmd.Parameters.AddWithValue("@studentID", studentID);

                    int value = (int)cmd.ExecuteScalar();

                    if (value > 0)
                    {
                        Form2 secondScreen = new Form2();
                        secondScreen.ShowDialog();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Invalid email address or student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //MessageBox.Show("tEst " + studentIDInput.Text);

        }


    }
}
