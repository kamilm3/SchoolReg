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
            SearchCourses fallClassSearch = new SearchCourses(2025, "Fall");
            fallClassSearch.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchCourses winterClassSearch = new SearchCourses(2026, "Winter");

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
