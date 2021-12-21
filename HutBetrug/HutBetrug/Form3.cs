using System;
using System.IO;
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
    
    public partial class Form3 : Form
    {
        public Form1 daddy;
        string path = @"test.txt";
        public Form3(Form1 daddy)
        {
            InitializeComponent();
            daddy.Hide();
            this.daddy = daddy;
            string fileRead = File.ReadAllText(path);
            richTextBox1.Text = fileRead;
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           
            string nameHighscore = eingabeHighscore.Text;

            if (nameHighscore == "")
            {
                nameHighscore = "Unbekannt";
            }
           
            string documentText = $"{nameHighscore}: {daddy.anzCoins} Coins\nHinzugefügt am {DateTime.Now}{Environment.NewLine}";
            File.AppendAllText(path, documentText);

            richTextBox1.Text += documentText;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            daddy.Show();
            this.Hide();
        }
    }
}
