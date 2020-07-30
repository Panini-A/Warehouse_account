using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storage
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            button1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox3.Enabled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox4.Enabled = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox5.Enabled = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox6.Enabled = true;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
    }
}
