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
    public partial class Form3 : Form
    {
        bool close = false;
        public DataClasses1DataContext DC = new DataClasses1DataContext();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "складDataSet.Заказчик_ГП". При необходимости она может быть перемещена или удалена.
            this.заказчик_ГПTableAdapter.Fill(this.складDataSet.Заказчик_ГП);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DC.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);
                MessageBox.Show("Изменения успешно сохранены", "Список заказов", MessageBoxButtons.OK, MessageBoxIcon.Information);
                close = true;
            }
            catch
            {
                MessageBox.Show("Не удалось выполнить сохранение", "Список заказов", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form3_Closing(object sender, FormClosingEventArgs e)
        {
            if (!close)
            {
                var result = MessageBox.Show("Все изменения будут потеряны\nВы действительно хотите закрыть окно?", "Список заказов", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    e.Cancel = true;
            }
        }
    }
}
