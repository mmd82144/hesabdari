﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text;
                string family = textBox2.Text;
                string tel = textBox3.Text;
                string line = name + "," + family + "," + tel + "\n";
                File.AppendAllText("sample.csv", line);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }






        }



    }
}


