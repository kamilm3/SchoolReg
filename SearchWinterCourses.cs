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
    public partial class SearchWinterCourses : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public SearchWinterCourses()
        {
            InitializeComponent();

            myConnection = new SqlConnection("user id=admin3;" + // Username
                                  "password=admin;" + // Password
                                  "server=LAPTOP-6TEGHEN2;" + // Server name
                                  "TrustServerCertificate=True;" +
                                  "database=SchoolReg; " + // Database
                                  "connection timeout=30"); // Timeout in seconds

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
                string searchQuery = "Select CourseName, Year, Term from Courses where CourseName like @courseName and Term = 'Winter'";


                using (SqlCommand cmd = new SqlCommand(searchQuery, myConnection))
                {
                    cmd.Parameters.AddWithValue("@courseName", "%" + courseName + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    try
                    {
                        myConnection.Open();
                        adapter.Fill(dt);

                        WinterCourses.DataSource = dt;
                        

                        if(WinterCourses.Rows.Count == 1)
                        {
                            noResultMessage.Text = "There are no results for " + courseName;
                            noResultMessage.Visible = true;
                        }

                        else
                        {
                            WinterCourses.Visible = true;
                        }
                    }
                    catch (Exception ex)
                    {
                    }





                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
