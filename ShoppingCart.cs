using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Security.Cryptography.Xml;
using System.Windows.Forms;
using System;
using System.Data;
using System.Diagnostics.Metrics;
using System.Reflection;

namespace SchoolReg
{
    public partial class ShoppingCart : Form
    {
        public ShoppingCart()
        {
            InitializeComponent();

            LoadCart();
        }

        private void LoadCart()
        {
            var query = "SELECT ShoppingCart.CourseID, CourseCode, CourseName, Year, Term FROM ShoppingCart JOIN Courses ON ShoppingCart.CourseID = Courses.CourseID WHERE StudentID = @StudentID";
            var cmd = new SqlCommand(query, DbConnection.Connection);
            cmd.Parameters.AddWithValue("@StudentID", Session.CurrentSession!.StudentID);
            cmd.ExecuteNonQuery();

            var adapter = new SqlDataAdapter(cmd);
            var dt = new DataTable();

            adapter.Fill(dt);

            CartDataGridView.DataSource = dt;

            CartDataGridView.Columns["CourseID"].Visible = false;

            if (CartDataGridView.Rows.Count == 0)
            {
                NoResultLabel.Text = "There are no courses in your shopping cart";
                NoResultLabel.Visible = true;

                CartDataGridView.Visible = false;
                EnrollButton.Visible = false;
                RemoveSelectedButton.Visible = false;
            }
            else
            {
                NoResultLabel.Visible = false;

                CartDataGridView.Visible = true;
                EnrollButton.Visible = true;
                RemoveSelectedButton.Visible = true;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EnrollButton_Click(object sender, EventArgs e)
        {
            // Ensure there are courses in the cart
            if (CartDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("There are no courses in your cart to enroll in");
                return;
            }

            var transaction = DbConnection.Connection.BeginTransaction();

            // Loop through each course in the DataGridView
            foreach (DataGridViewRow row in CartDataGridView.Rows)
            {
                // Retrieve course details from the row
                var courseID = (int)row.Cells["CourseID"].Value;
                var courseCode = (string)row.Cells["CourseCode"].Value;
                var courseName = (string)row.Cells["CourseName"].Value;
                var year = (int)row.Cells["Year"].Value;
                var term = (string)row.Cells["Term"].Value;

                using var cmd = new SqlCommand("spEnrollment", DbConnection.Connection, transaction);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StudentID", Session.CurrentSession!.StudentID);
                cmd.Parameters.AddWithValue("@CourseID", courseID);
                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@Term", term);

                try
                {
                    // Execute the stored procedure for this course
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    // If the stored procedure throws an error (e.g., prerequisite not met, scheduling conflict, or full course),
                    // display the error and exit without processing further courses.
                    MessageBox.Show($"Error enrolling in {courseCode}: {ex.Message}");
                    transaction.Rollback();
                    return;
                }
            }

            transaction.Commit();

            // If all stored procedure calls succeeded, notify the user
            MessageBox.Show("Courses successfully enrolled");
            this.Close();
        }

        private void RemoveSelectedButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Loop through each course in the DataGridView
                foreach (DataGridViewRow row in CartDataGridView.SelectedRows)
                {
                    // Retrieve course details from the row
                    var courseID = (int)row.Cells["CourseID"].Value;

                    var query = "DELETE FROM ShoppingCart WHERE StudentID = @StudentID AND CourseID = @CourseID";
                    using var cmd = new SqlCommand(query, DbConnection.Connection);
                    cmd.Parameters.AddWithValue("@StudentID", Session.CurrentSession!.StudentID);
                    cmd.Parameters.AddWithValue("@CourseID", courseID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadCart();
        }
    }
}
