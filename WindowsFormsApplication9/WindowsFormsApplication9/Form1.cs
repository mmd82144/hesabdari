using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 cs = new Form2();
            cs.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {


            ShowCustomers sc = new ShowCustomers();
            sc.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form4 sc = new Form4();
            sc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 sc = new Form5();
            sc.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }
    }
}