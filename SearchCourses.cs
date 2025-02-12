using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void button1_Click(object sender, EventArgs e)
        {
            SearchOptions backButton = new SearchOptions();
            backButton.ShowDialog();
            this.Hide();
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
                string searchQuery = "Select CourseCode, CourseName, Year, Term from Courses where CourseName like @courseName and Term = @term";


                using var cmd = new SqlCommand(searchQuery, DbConnection.Connection);
                cmd.Parameters.AddWithValue("@courseName", "%" + courseName + "%");
                cmd.Parameters.AddWithValue("@term", Term);

                var adapter = new SqlDataAdapter(cmd);
                var dt = new DataTable();

                try
                {
                    adapter.Fill(dt);

                    CoursesTable.DataSource = dt;

                    if (CoursesTable.Rows.Count == 0)
                    {
                        noResultMessage.Text = "There are no results for " + courseName;
                        noResultMessage.Visible = true;
                    }
                    else
                    {
                        CoursesTable.Visible = true;
                        noResultMessage.Visible = false;
                        addCartButton.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
