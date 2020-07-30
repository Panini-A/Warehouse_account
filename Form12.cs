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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "СкладDataSet.Информация_по_товарам". При необходимости она может быть перемещена или удалена.
            this.Информация_по_товарамTableAdapter.Fill(this.СкладDataSet.Информация_по_товарам);

            this.reportViewer1.RefreshReport();
        }
    }
}
