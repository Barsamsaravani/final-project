using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectfinall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int counterpic = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            counterpic++;
            switch(counterpic)
            {
                case 1:pictureBox1.Image = Properties.Resources._1;break;
                case 2: pictureBox1.Image = Properties.Resources._2; break;
                case 3: pictureBox1.Image = Properties.Resources._3; break;
                case 4: pictureBox1.Image = Properties.Resources._4; break;
                case 5: pictureBox1.Image = Properties.Resources._5; break;
                case 6: pictureBox1.Image = Properties.Resources._6;counterpic = 0; break;
            }
        }

        private void محصولاتبرودتیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void دربارهپارسToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f4 = new Form3();
            f4.Show();
        }

        private void تاریخپهشرکتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f3 = new Form4();
            f3.Show();
        }

        private void تصاویرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void اصلیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void درخواستنصبمحصولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form14 f1 = new Form14();
            f1.Show();
        }

        private void درخواستنمایندگیخدماتToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void فرصتهایهمکاریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f1 = new Form6();
            f1.Show();
        }

        private void اخبارچارسToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 f1 = new Form11();
            f1.Show();
        }

        private void سوالاتمتداولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f1 = new Form7();
            f1.Show();
        }

        private void لباسشویوظرقشویToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 f1 = new Form12();
            f1.Show();
        }

        private void جاروبرقیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 f1 = new Form13();
            f1.Show();
        }

        private void مزایدهومناقصهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form17 f1 = new Form17();
            f1.Show();
        }

        private void سنجشرضایتمشتریانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form15 f1 = new Form15();
            f1.Show();
        }

        private void فروشاقساطیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form16 f1 = new Form16();
            f1.Show();
        }

        private void فرمپیگیریشکایاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form18 f1 = new Form18();
            f1.Show();
        }

        private void کولرآبیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form20 f1 = new Form20();
            f1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form21 f1 = new Form21();
            f1.Show();
        }
    }
}
