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
    public partial class SearchOptions : Form
    {
        public SearchOptions()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchFallCourses fallClassSearch = new SearchFallCourses();
            fallClassSearch.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchWinterCourses winterClassSearch = new SearchWinterCourses();

            winterClassSearch.ShowDialog();
            this.Hide();
            //this.Close();
            //System.Windows.Forms.Application.ExitThread();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 backButton = new Form2();
            backButton.ShowDialog();
            backButton.Hide();
        }
    }
}
