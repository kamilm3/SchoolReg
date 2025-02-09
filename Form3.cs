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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 fallClassSearch = new Form4();
            fallClassSearch.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 winterClassSearch = new Form5();
            
            winterClassSearch.ShowDialog();
            //this.hide();
            //this.Close();
            //System.Windows.Forms.Application.ExitThread();

        }
    }
}
