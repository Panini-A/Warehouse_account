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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form2 f2;
        Form3 f3;
        Form4 f4;
        Form5 f5;
        Form6 f6;
        Form7 f7;
        Form8 f8;
        Form9 f9;
        Form10 f10;
        Form11 f11;
        Form12 f12;
        Form13 f13;
        Form14 f14;
        Form15 f15;
        Form16 f16;
        Form17 f17;
        Form18 f18;
        Form19 f19;
        Form20 f20;

        private void добавитьЗаказToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f2 == null)
            {
                f2 = new Form2();
                f2.MdiParent = this;
                f2.FormClosed += new FormClosedEventHandler(f2_FormClosed);
                f2.Show();
            }
            else
                f2.Activate(); 
        }

        void f2_FormClosed(object sender, FormClosedEventArgs e) 
        {
            f2 = null;
        }

        private void списокЗаказовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f3 == null)
            {
                f3 = new Form3();
                f3.MdiParent = this;
                f3.FormClosed += new FormClosedEventHandler(f3_FormClosed);
                f3.Show();
            }
            else
                f3.Activate();
        }

        void f3_FormClosed(object sender, FormClosedEventArgs e)
        {
            f3 = null;
        }

        private void списокВсехПоставщиковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f4 == null)
            {
                f4 = new Form4();
                f4.MdiParent = this;
                f4.FormClosed += new FormClosedEventHandler(f4_FormClosed);
                f4.Show();
            }
            else
                f4.Activate();
        }

        void f4_FormClosed(object sender, FormClosedEventArgs e)
        {
            f4 = null;
        }

        private void операцииПоСкладуСиМToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f5 == null)
            {
                f5 = new Form5();
                f5.MdiParent = this;
                f5.FormClosed += new FormClosedEventHandler(f5_FormClosed);
                f5.Show();
            }
            else
                f5.Activate();
        }

        void f5_FormClosed(object sender, FormClosedEventArgs e)
        {
            f5 = null;
        }

        private void добавитьПоставщикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f6 == null)
            {
                f6 = new Form6();
                f6.MdiParent = this;
                f6.FormClosed += new FormClosedEventHandler(f6_FormClosed);
                f6.Show();
            }
            else
                f6.Activate();
        }
        void f6_FormClosed(object sender, FormClosedEventArgs e)
        {
            f6 = null;
        }

        private void списокПоставщиковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f7 == null)
            {
                f7 = new Form7();
                f7.MdiParent = this;
                f7.FormClosed += new FormClosedEventHandler(f7_FormClosed);
                f7.Show();
            }
            else
                f7.Activate();
        }
        void f7_FormClosed(object sender, FormClosedEventArgs e)
        {
            f7 = null;
        }

        private void добавитьОперациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f8 == null)
            {
                f8 = new Form8();
                f8.MdiParent = this;
                f8.FormClosed += new FormClosedEventHandler(f8_FormClosed);
                f8.Show();
            }
            else
                f8.Activate();
        }
        void f8_FormClosed(object sender, FormClosedEventArgs e)
        {
            f8 = null;
        }

        private void списокСырьяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f9 == null)
            {
                f9 = new Form9();
                f9.MdiParent = this;
                f9.FormClosed += new FormClosedEventHandler(f9_FormClosed);
                f9.Show();
            }
            else
                f9.Activate();
        }
        void f9_FormClosed(object sender, FormClosedEventArgs e)
        {
            f9 = null;
        }

        private void товарыНаСкладеГПToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f10 == null)
            {
                f10 = new Form10();
                f10.MdiParent = this;
                f10.FormClosed += new FormClosedEventHandler(f10_FormClosed);
                f10.Show();
            }
            else
                f10.Activate();
        }
        void f10_FormClosed(object sender, FormClosedEventArgs e)
        {
            f10 = null;
        }

        private void отчетОЗаказахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f11 == null)
            {
                f11 = new Form11();
                f11.MdiParent = this;
                f11.FormClosed += new FormClosedEventHandler(f11_FormClosed);
                f11.Show();
            }
            else
                f11.Activate();
        }
        void f11_FormClosed(object sender, FormClosedEventArgs e)
        {
            f11 = null;
        }

        private void спецификацииТоваровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f12 == null)
            {
                f12 = new Form12();
                f12.MdiParent = this;
                f12.FormClosed += new FormClosedEventHandler(f12_FormClosed);
                f12.Show();
            }
            else
                f12.Activate();
        }
        void f12_FormClosed(object sender, FormClosedEventArgs e)
        {
            f12 = null;
        }

        private void списокСиМToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f13 == null)
            {
                f13 = new Form13();
                f13.MdiParent = this;
                f13.FormClosed += new FormClosedEventHandler(f13_FormClosed);
                f13.Show();
            }
            else
                f13.Activate();
        }
        void f13_FormClosed(object sender, FormClosedEventArgs e)
        {
            f13 = null;
        }

        private void товарыНаСкладеСиМToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f14 == null)
            {
                f14 = new Form14();
                f14.MdiParent = this;
                f14.FormClosed += new FormClosedEventHandler(f14_FormClosed);
                f14.Show();
            }
            else
                f14.Activate();
        }
        void f14_FormClosed(object sender, FormClosedEventArgs e)
        {
            f14 = null;
        }

        private void списокГПToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f15 == null)
            {
                f15 = new Form15();
                f15.MdiParent = this;
                f15.FormClosed += new FormClosedEventHandler(f15_FormClosed);
                f15.Show();
            }
            else
                f15.Activate();
        }
        void f15_FormClosed(object sender, FormClosedEventArgs e)
        {
            f15 = null;
        }

        private void операцииПоСкладуГПToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f16 == null)
            {
                f16 = new Form16();
                f16.MdiParent = this;
                f16.FormClosed += new FormClosedEventHandler(f16_FormClosed);
                f16.Show();
            }
            else
                f16.Activate();
        }
        void f16_FormClosed(object sender, FormClosedEventArgs e)
        {
            f16 = null;
        }

        private void операцииПоЦехуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f17 == null)
            {
                f17 = new Form17();
                f17.MdiParent = this;
                f17.FormClosed += new FormClosedEventHandler(f17_FormClosed);
                f17.Show();
            }
            else
                f17.Activate();
        }
        void f17_FormClosed(object sender, FormClosedEventArgs e)
        {
            f17 = null;
        }

        private void операцииПоГПToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f18 == null)
            {
                f18 = new Form18();
                f18.MdiParent = this;
                f18.FormClosed += new FormClosedEventHandler(f18_FormClosed);
                f18.Show();
            }
            else
                f18.Activate();
        }
        void f18_FormClosed(object sender, FormClosedEventArgs e)
        {
            f18 = null;
        }

        private void добавитьОперациюToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (f19 == null)
            {
                f19 = new Form19();
                f19.MdiParent = this;
                f19.FormClosed += new FormClosedEventHandler(f19_FormClosed);
                f19.Show();
            }
            else
                f19.Activate();
        }
        void f19_FormClosed(object sender, FormClosedEventArgs e)
        {
            f19 = null;
        }

        private void добавитьОперациюToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (f20 == null)
            {
                f20 = new Form20();
                f20.MdiParent = this;
                f20.FormClosed += new FormClosedEventHandler(f20_FormClosed);
                f20.Show();
            }
            else
                f20.Activate();
        }
        void f20_FormClosed(object sender, FormClosedEventArgs e)
        {
            f20 = null;
        }
    }
}
