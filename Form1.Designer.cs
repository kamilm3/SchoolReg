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

namespace CMPT291_Project
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
            /*
            myConnection = new SqlConnection("user id=admin3;" + // Username
                                  "password=admin;" + // Password
                                  "server=Kamil\\MSSQLSERVER03;" + // Server name
                                  "TrustServerCertificate=True;" +
                                  "database=project291; " + // Database
                                  "connection timeout=30"); // Timeout in seconds
            
            */

            // Initialize the connection
            /*
            myConnection = new SqlConnection("user id=Memoh;" + // Username
                                              "password=memoh4321;" + // Password
                                              "server=DESKTOP-H6FU9US\\MSSQLSERVER01;" + // Server name
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
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
        }

        #endregion
    }
}
