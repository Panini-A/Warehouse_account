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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "складDataSet.Склад_СиМ". При необходимости она может быть перемещена или удалена.
            this.склад_СиМTableAdapter.Fill(this.складDataSet.Склад_СиМ);

        }
    }
}
