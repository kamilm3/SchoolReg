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

            /*
            myConnection = new SqlConnection("user id=admin3;" + // Username
                                  "password=admin;" + // Password
                                  "server=LAPTOP-6TEGHEN2;" + // Server name
                                  "TrustServerCertificate=True;" +
                                  "database=Project_291; " + // Database
                                  "connection timeout=30"); // Timeout in seconds
            
            */
            
            myConnection = new SqlConnection("user id=admin;" + // Username
                                  "password=admin;" + // Password
                                  "server=Kamil\\MSSQLSERVER03;" + // Server name
                                  "TrustServerCertificate=True;" +
                                  "database=SchoolReg; " + // Database
                                  "connection timeout=30"); // Timeout in seconds
            
            

            // Initialize the connection
            /*
            myConnection = new SqlConnection("user id=Memoh;" + // Username
                                              "password=memoh4321;" + // Password
                                              "server=Memoh;" + // Server name
                                              "TrustServerCertificate=True;" +
                                              "database=project291; " + // Database
                                              "connection timeout=30"); // Timeout in seconds
            */

            /*
            myConnection = new SqlConnection("user id=admin3;" + // Username
                                             "password=admin;" + // Password
                                             "server=DESKTOP-6QG008O;" + // Server name
                                             "TrustServerCertificate=True;" +
                                             "database=project291; " + // Database
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

        }

        private void studentID_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
