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
    public partial class Form2 : Form
    {
        bool close = false;
        public DataClasses1DataContext DC = new DataClasses1DataContext();
        public Form2()
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

        private void button1_Click(object sender, EventArgs e)
        {
            Заказчик_ГП ГП = new Заказчик_ГП
            {
                Наименование_заказчика = textBox1.Text,
                Наименование_товара = textBox2.Text,
                Количество = Convert.ToInt32(textBox3.Text),
                Единица_измерения = textBox4.Text,
                Адрес = textBox5.Text,
                Телефон = textBox6.Text
            };
            DC.Заказчик_ГП.InsertOnSubmit(ГП);
            try
            {
                DC.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);
                MessageBox.Show("Заказ был успешно добавлен", "Добавить заказ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                close = true;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Не удалось добавить заказ", "Добавить заказ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
        
    

