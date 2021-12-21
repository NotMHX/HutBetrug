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
    public partial class Form2 : Form
    {
        public Form1 mother;
        public Form2(Form1 mother)
        {
            InitializeComponent();
            button8.ForeColor = Color.Green;
            this.mother = mother;
            label2.Text = Convert.ToString(mother.anzCoins);
            mother.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int coins = mother.anzCoins;
            if(coins >= 100 && coins < 200)
            {
                button4.ForeColor = Color.Green;
            }
            else if (coins >= 200 && coins < 400)
            {
                button4.ForeColor = Color.Green;
                button5.ForeColor = Color.Green;
            }
            else if (coins >= 400 && coins < 1000)
            {
                button4.ForeColor = Color.Green;
                button5.ForeColor = Color.Green;
                button6.ForeColor = Color.Green;
            }
            else if (coins >= 1000)
            {
                button4.ForeColor = Color.Green;
                button5.ForeColor = Color.Green;
                button6.ForeColor = Color.Green;
                button7.ForeColor = Color.Green;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.ForeColor == Color.Green)
            {
                mother.selectedHat = 0;
                button8.ForeColor = Color.Green;
                label2.Text = Convert.ToString(mother.anzCoins);
                UnSelectAll(button8, button7, button6, button5, button4);
                button8.Text = "Ausgewählt";
            }
        }

        private void hut1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(button4.ForeColor == Color.Green)
            {
                mother.selectedHat = 1;
                mother.anzCoins = mother.anzCoins - 100;
                label2.Text = Convert.ToString(mother.anzCoins);
                UnSelectAll(button8, button7, button6, button5, button4);
                button4.Text = "Ausgewählt";
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            mother.anzCoins = Convert.ToInt32(label2.Text);
            mother.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.ForeColor == Color.Green)
            {
                mother.selectedHat = 2;
                mother.anzCoins = mother.anzCoins - 200;
                label2.Text = Convert.ToString(mother.anzCoins);
                UnSelectAll(button8, button7, button6, button5, button4);
                button5.Text = "Ausgewählt";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.ForeColor == Color.Green)
            {
                mother.selectedHat = 3;
                mother.anzCoins = mother.anzCoins - 100;
                label2.Text = Convert.ToString(mother.anzCoins);
                UnSelectAll(button8, button7, button6, button5, button4);
                button6.Text = "Ausgewählt";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.ForeColor == Color.Green)
            {
                mother.selectedHat = 4;
                mother.anzCoins = mother.anzCoins - 100;
                label2.Text = Convert.ToString(mother.anzCoins);
                UnSelectAll(button8, button7, button6, button5, button4);
                button7.Text = "Ausgewählt";
            }
        }
        static void UnSelectAll(Button button8, Button button7, Button button6, Button button5, Button button4)
        {
            button8.Text = "Standarthut auswählen";
            button7.Text = "Auswählen";
            button6.Text = "Auswählen";
            button5.Text = "Auswählen";
            button4.Text = "Auswählen";
        }
    }
}
