using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HutBetrug
{
    public partial class Form4 : Form
    {
        public int count;
        public Form1 brother;

        public Form4()
        {
            InitializeComponent();
            timer1.Enabled = true;
            count = 5;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count--;
            if (count == 0)
            {
                pictureBox1.Enabled = false;
                this.Hide();
                Form1 mainForm = new Form1();
                mainForm.Show();

            }
        }
    }
}
