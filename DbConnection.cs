using Microsoft.Data.SqlClient;

namespace SchoolReg
{
    public class DbConnection
    {

        public static SqlConnection Connection { get; private set; }
        public static SqlCommand Command { get; private set; }
        //DEFINE SQL DATA READER INLINE AT POINT OF USE
        //FOR EXAMPLE: using var reader = cmd.ExecuteReader();
        //public static SqlDataReader Reader { get; private set; }


        static DbConnection()
        {
            /*
            Connection = new SqlConnection("user id=admin3;" + // Username
                                 "password=admin;" + // Password
                                  "server=LAPTOP-6TEGHEN2;" + // Server name
                                  "TrustServerCertificate=True;" +
                                  "database=SchoolReg; " + // Database
                                 "connection timeout=30"); // Timeout in seconds
            */

            /*
            Connection = new SqlConnection("user id=admin;" + // Username
                      "password=password123;" + // Password
                      "server=BUBBLES\\BUBBLES;" + // Server name
                      "TrustServerCertificate=True;" +
                      "database=SchoolReg; " + // Database
                      "connection timeout=3"); // Timeout in seconds
            */
           


            
            Connection = new SqlConnection("user id=admin;" + // Username
                                  "password=admin;" + // Password
                                  "server=Kamil\\MSSQLSERVER03;" + // Server name
                                  "TrustServerCertificate=True;" +
                                  "database=SchoolReg; " + // Database
                                  "connection timeout=30"); // Timeout in seconds
            


            try
            {
                Connection.Open(); // Open the connection
                Command = new SqlCommand();
                Command.Connection = Connection; // Link the command to the connection
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                throw new Exception("Error connecting to the database");
            }
        }

        private DbConnection()
        {
        }
    }

}
