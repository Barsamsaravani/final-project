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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 f1 = new Form8();
                f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 f1 = new Form9();
            f1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form10 f1 = new Form10();
                f1.Show();
        }
    }
}
