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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "складDataSet.Склад_ГП". При необходимости она может быть перемещена или удалена.
            this.склад_ГПTableAdapter.Fill(this.складDataSet.Склад_ГП);

        }
    }
}
