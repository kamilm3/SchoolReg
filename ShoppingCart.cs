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

            if (Session.CurrentSession == null)
            {
                MessageBox.Show("Please login to add courses to your cart");
                return;
            }

            var query = "SELECT ShoppingCart.CourseID, CourseCode, CourseName, Year, Term FROM ShoppingCart JOIN Courses ON ShoppingCart.CourseID = Courses.CourseID WHERE StudentID = @StudentID";
            using var cmd = new SqlCommand(query, DbConnection.Connection);
            cmd.Parameters.AddWithValue("@StudentID", Session.CurrentSession.StudentID);
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
            }
            else
            {
                CartDataGridView.Visible = true;
                NoResultLabel.Visible = false;
                EnrollButton.Visible = true;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EnrollButton_Click(object sender, EventArgs e)
        {
            /* MATERIALIZED VIEW WE HAVE IN SCHEMA
            DROP VIEW IF EXISTS vwEnrollCapacity;
            GO

            CREATE VIEW vwEnrollCapacity
WITH SCHEMABINDING
AS
SELECT
    c.CourseID,
    c.Year,
    c.Term,
    cr.Capacity,
	COUNT_BIG(*) AS TotalRecords,
    COUNT_BIG(e.StudentID) AS EnrolledCount,
    COUNT_BIG(tc.CourseID) AS PrereqCoursesCompleted
FROM dbo.Courses c
JOIN dbo.Classroom cr ON c.ClassroomID = cr.ClassroomID-- capacity from Classroom table
JOIN dbo.Enroll e ON c.CourseID = e.CourseID-- countig enrolled students
JOIN dbo.TakenCourses tc ON e.StudentID = tc.StudentID-- counting prerequisites completed
GROUP BY c.CourseID, c.Year, c.Term, cr.Capacity;
            GO

            -- unique clustered index
            CREATE UNIQUE CLUSTERED INDEX IDX_vwEnrollCapacity_CourseID
ON vwEnrollCapacity(CourseID, Year, Term);
            GO
                */


            //verify all first by using the materialized view

            // VERIFY 

            // IF ANY COURSES NOT ALLOWED BASED ON MATERIALIZED VIEW, SHOW MESSAGE BOX WITH THE SPECIFIC ERROR AND RETURN


            //enroll all after all have been verified

            //... CODE TO ENROLL IN ALL

            MessageBox.Show("Courses successfully enrolled");
            this.Close();
        }
    }
}
