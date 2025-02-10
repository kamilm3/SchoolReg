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
    public partial class Form2 : Form


    {
        //public Form2(int studentID, string emailAddress)
        public Form2()


        {
            InitializeComponent();
            string studentEmail = Verification.studentEmail;
            //MessageBox.Show("Passed email address: " + studentEmail);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShoppingCart cartPage = new ShoppingCart();
            cartPage.ShowDialog();

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchOptions classSearchPage = new SearchOptions();
            classSearchPage.Show();
            this.Hide();
        }


    }
}
