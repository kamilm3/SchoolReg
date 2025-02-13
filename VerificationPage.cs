using Microsoft.Data.SqlClient;

namespace SchoolReg
{
    public partial class Verification : Form
    {
        public static int studentId;
        public static string studentEmail;
        public Verification()
        {
            InitializeComponent();
            //DbConnection.Connection;

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


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            string studentIDBox = studentIDInput.Text.Trim();


            string emailAddressBox = emailAddressInput.Text.Trim();





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
                using (SqlCommand cmd = new SqlCommand(query, DbConnection.Connection))
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

                        // Initialize session
                        Session.CurrentSession.Email = emailAddressBox;
                        Session.CurrentSession.StudentID = studentID;

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

        private void button1_Click(object sender, EventArgs e)
        {
            studentIDInput.Text = "1";
            emailAddressInput.Text = "alice@university.edu";
        }
    }
}
