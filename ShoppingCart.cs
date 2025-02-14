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

            var adapter = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            adapter.Fill(dt);

            // Ensure UI update happens on the main thread
            if (CartDataGridView.InvokeRequired)
            {
                CartDataGridView.Invoke(new Action(() =>
                {
                    UpdateCartUI(dt);
                }));
            }
            else
            {
                UpdateCartUI(dt);
            }
        }

        private void UpdateCartUI(DataTable dt)
        {
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

        private async void EnrollButton_Click(object sender, EventArgs e)
        {
            if (CartDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("There are no courses in your cart to enroll in");
                return;
            }

            using var transaction = DbConnection.Connection.BeginTransaction();
            var succeededCourseCodes = new List<string>();

            try
            {
                foreach (DataGridViewRow row in CartDataGridView.Rows)
                {
                    var courseID = (int)row.Cells["CourseID"].Value;
                    var courseCode = (string)row.Cells["CourseCode"].Value;

                    // Check if student is already enrolled
                    using var checkCmd = new SqlCommand("SELECT COUNT(*) FROM Enroll WHERE StudentID = @StudentID AND CourseID = @CourseID", DbConnection.Connection, transaction);
                    checkCmd.Parameters.AddWithValue("@StudentID", Session.CurrentSession!.StudentID);
                    checkCmd.Parameters.AddWithValue("@CourseID", courseID);

                    int existingCount = (int)await checkCmd.ExecuteScalarAsync();
                    if (existingCount > 0)
                    {
                        MessageBox.Show($"{courseCode} is already enrolled", "Enrollment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        continue;
                    }

                    // Insert into enrollment
                    using var cmd = new SqlCommand("INSERT INTO Enroll (StudentID, CourseID) VALUES (@StudentID, @CourseID)", DbConnection.Connection, transaction);
                    cmd.Parameters.AddWithValue("@StudentID", Session.CurrentSession!.StudentID);
                    cmd.Parameters.AddWithValue("@CourseID", courseID);

                    await cmd.ExecuteNonQueryAsync();
                    succeededCourseCodes.Add(courseCode);
                }

                await transaction.CommitAsync();

                if (succeededCourseCodes.Count > 0)
                {
                    MessageBox.Show($"Successfully enrolled in: {string.Join(", ", succeededCourseCodes)}", "Enrollment Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Refresh UI asynchronously to prevent UI lag
                await Task.Run(() => LoadCart());

                // Close only after UI update
                this.BeginInvoke(new Action(() => this.Close()));
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
