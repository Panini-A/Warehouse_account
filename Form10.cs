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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "СкладDataSet.Склад_ГП". При необходимости она может быть перемещена или удалена.
            this.Склад_ГПTableAdapter.Fill(this.СкладDataSet.Склад_ГП);

            this.reportViewer1.RefreshReport();
        }
    }
}
