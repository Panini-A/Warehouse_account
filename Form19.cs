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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
            button1.Enabled = false;
            textBox2.Enabled = false;
            dateTimePicker1.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
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
            button1.Enabled = true;
        }

    }
}
