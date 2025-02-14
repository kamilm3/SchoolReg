using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace SchoolReg
{
    public partial class SearchCourses : Form
    {
        public int Year { get; set; }
        public string Term { get; set; }

        public SearchCourses(int year, string term)
        {
            Year = year;
            Term = term;

            InitializeComponent();

            TitleLabel.Text = TitleLabel.Text.Replace("%year%", Year.ToString()).Replace("%term%", Term.ToString());
        }

        private void ChangeTermButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string courseName = searchInput.Text;

            if (string.IsNullOrEmpty(courseName))
            {
                MessageBox.Show("Enter a course name");
                return;
            }

            try
            {
                //SQL query to pass to server
                string searchQuery = "Select CourseID, CourseCode, CourseName, Year, Term from Courses where (CourseName LIKE @userInput OR CourseCode LIKE @userInput) AND Term = @term";


                using var cmd = new SqlCommand(searchQuery, DbConnection.Connection);
                cmd.Parameters.AddWithValue("@userInput", "%" + courseName + "%");
                cmd.Parameters.AddWithValue("@term", Term);

                var adapter = new SqlDataAdapter(cmd);
                var dt = new DataTable();

                adapter.Fill(dt);

                CoursesTable.DataSource = dt;

                CoursesTable.Columns["CourseID"].Visible = false;

                if (CoursesTable.Rows.Count == 0)
                {
                    NoResultLabel.Text = "There are no results for " + courseName;
                    NoResultLabel.Visible = true;

                    CoursesTable.Visible = false;
                    addCartButton.Visible = false;
                    ViewCartButton.Visible = false;
                }
                else
                {
                    NoResultLabel.Visible = false;

                    CoursesTable.Visible = true;
                    addCartButton.Visible = true;
                    ViewCartButton.Visible = true;
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void addCartButton_Click(object sender, EventArgs e)
        {
            var successCourseCodes = new List<string>();
            var existingCourseMessages = new List<string>();
            var conflictMessages = new List<string>();

            foreach (DataGridViewRow row in CoursesTable.SelectedRows)
            {
                string courseCode = "";
                try
                {
                    var courseId = (int)row.Cells["CourseID"].Value;
                    courseCode = (string)row.Cells["CourseCode"].Value;
                    var year = Year;
                    var term = Term;

                    using var cmd = new SqlCommand("spCheckEnrollment", DbConnection.Connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StudentID", Session.CurrentSession!.StudentID);
                    cmd.Parameters.AddWithValue("@CourseID", courseId);
                    cmd.Parameters.AddWithValue("@Year", year);
                    cmd.Parameters.AddWithValue("@Term", term);

                    try
                    {
                        // Execute stored procedure to check prereqs and conflicts only
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        conflictMessages.Add($"Cannot add {courseCode}: {ex.Message}");
                        continue;
                    }

                    // Only add to ShoppingCart if it passes checks
                    var query = "INSERT INTO ShoppingCart (StudentID, CourseID, Time) VALUES (@StudentID, @CourseID, @Time)";
                    using var cartCmd = new SqlCommand(query, DbConnection.Connection);
                    cartCmd.Parameters.AddWithValue("@StudentID", Session.CurrentSession!.StudentID);
                    cartCmd.Parameters.AddWithValue("@CourseID", courseId);
                    cartCmd.Parameters.AddWithValue("@Time", DateTime.UtcNow);
                    cartCmd.ExecuteNonQuery();

                    successCourseCodes.Add(courseCode);
                }
                catch (SqlException ex) when (ex.Number == 2627)
                {
                    existingCourseMessages.Add($"{courseCode} is already in your cart");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (conflictMessages.Count > 0)
            {
                MessageBox.Show(string.Join("\n", conflictMessages), "Conflict Detected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (existingCourseMessages.Count > 0)
            {
                MessageBox.Show(string.Join("\n", existingCourseMessages), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (successCourseCodes.Count > 0)
            {
                MessageBox.Show($"Added {string.Join(", ", successCourseCodes)} to your cart", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }




        private void ViewCartButton_Click(object sender, EventArgs e)
        {
            var cartPage = new ShoppingCart();
            this.Hide();
            cartPage.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
