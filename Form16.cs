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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "СкладDataSet.Операции_по_складу_ГП". При необходимости она может быть перемещена или удалена.
            this.Операции_по_складу_ГПTableAdapter.Fill(this.СкладDataSet.Операции_по_складу_ГП);

            this.reportViewer1.RefreshReport();
        }
    }
}
