using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMPT391_Project;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SchoolReg
{
    public partial class Verification : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public static int studentId;
        public static string studentEmail;
        public Verification()
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
            }
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Verification));
            emailAddressInput = new System.Windows.Forms.TextBox();
            label2 = new Label();
            label1 = new Label();
            studentIDInput = new System.Windows.Forms.TextBox();
            header = new Label();
            sqlCommand1 = new SqlCommand();
            nextButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // emailAddressInput
            // 
            resources.ApplyResources(emailAddressInput, "emailAddressInput");
            emailAddressInput.Name = "emailAddressInput";
            emailAddressInput.UseWaitCursor = true;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            label1.Click += label1_Click;
            // 
            // studentIDInput
            // 
            resources.ApplyResources(studentIDInput, "studentIDInput");
            studentIDInput.Name = "studentIDInput";
            studentIDInput.TextChanged += textBox1_TextChanged;
            // 
            // header
            // 
            header.BackColor = Color.Brown;
            resources.ApplyResources(header, "header");
            header.ForeColor = Color.White;
            header.Name = "header";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // nextButton
            // 
            nextButton.BackColor = Color.FromArgb(192, 0, 0);
            resources.ApplyResources(nextButton, "nextButton");
            nextButton.ForeColor = Color.White;
            nextButton.Name = "nextButton";
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += nextButton_Click;
            // 
            // Verification
            // 
            BackColor = SystemColors.ControlLight;
            resources.ApplyResources(this, "$this");
            Controls.Add(emailAddressInput);
            Controls.Add(label2);
            Controls.Add(nextButton);
            Controls.Add(header);
            Controls.Add(studentIDInput);
            Controls.Add(label1);
            Name = "Verification";
            WindowState = FormWindowState.Maximized;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private Label label2;
        private Label header;
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

                        //public static int studentId;
                        //public static string studentEmail;

                        studentId = studentID;
                        studentEmail = emailAddressBox;

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

        }

   
        

        public System.Windows.Forms.TextBox studentIDInput;
        public System.Windows.Forms.TextBox emailAddressInput;
    }
}
