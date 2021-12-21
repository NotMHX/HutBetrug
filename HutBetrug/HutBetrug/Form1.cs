using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HutBetrug
{
    public partial class Form1 : Form
    {
        public int anzCoins;
        public int selectedHat;
        /*  0 = standard Hat
            1 = grayHat
            2 = greenHat
            3 = purpleHat
            4 = redHat        */

        public Form1()
        {
            InitializeComponent();
            selectedHat = 0;
            try
            {
                var lines = File.ReadAllLines("data.txt");
                foreach (var line in lines)
                {
                    anzCoins = Convert.ToInt32(lines[0]);
                }
            }
            catch { anzCoins = 100; }
            label2.Text = Convert.ToString(anzCoins);
            StandardLayout(hut1, hut2, hut3, button1, label4, textBox1, pictureBox1, pictureBox2, pictureBox3, coin1, coin2, coin3);
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int anzCoins = Convert.ToInt32(label2.Text);
                try
                {
                    // Easter-Egg
                    if(textBox1.Text == "GOD")
                    {
                        anzCoins += 100000;
                        label2.Text = Convert.ToString(anzCoins);

                        using (TextWriter writer = File.CreateText("data.txt"))
                        {
                            writer.WriteLine(anzCoins + "\n");
                        }
                    }
                    else if (Convert.ToInt32(textBox1.Text) > anzCoins || anzCoins < 0 || textBox1.Text == "0" || 0 > Convert.ToInt32(textBox1.Text))
                    {
                        MessageBox.Show("Error, mögliche Fehler:\nSie haben zu viele Coins eingegeben! (oder Sie haben keine mehr :P)");
                    }
                    else
                    {
                        try
                        {
                            int anzahlCoins = Convert.ToInt32(label2.Text);
                            anzahlCoins = anzahlCoins - Convert.ToInt32(textBox1.Text);
                            label2.Text = Convert.ToString(anzahlCoins);
                            UpdateData(anzCoins);

                        }
                        catch { MessageBox.Show("Error; Prüfe den input"); }

                        int random = new Random().Next(1, 4);
                        label5.Text = Convert.ToString(random);
                        StandardLayout(hut1, hut2, hut3, button1, label4, textBox1, pictureBox1, pictureBox2, pictureBox3, coin1, coin2, coin3);
                        button1.Visible = false;
                        label4.Visible = false;
                        textBox1.Visible = false;
                        hut1.Visible = true;
                        hut2.Visible = true;
                        hut3.Visible = true;
                    }
                }

                catch
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Keine Wette gesetzt!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            anzCoins = Convert.ToInt32(label2.Text);
            Form2 settingsForm = new Form2(this);
            settingsForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "100";
            UpdateData(anzCoins);
            StandardLayout(hut1, hut2, hut3, button1, label4, textBox1, pictureBox1, pictureBox2, pictureBox3, coin1, coin2, coin3);
            selectedHat = 0;
            pictureBox1.BackgroundImage = System.Drawing.Image.FromFile(@"icons\1 (1).png");
            pictureBox2.BackgroundImage = System.Drawing.Image.FromFile(@"icons\1 (2).png");
            pictureBox3.BackgroundImage = System.Drawing.Image.FromFile(@"icons\1 (3).png");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void hut1_Click(object sender, EventArgs e)
        {
            int anzCoins = Convert.ToInt32(label2.Text);
            int gesetzt = Convert.ToInt32(textBox1.Text);
            pictureBox1.Visible = false;
            if (label5.Text == "1")
            {
                coin1.Visible = true;
                anzCoins = gesetzt * 2;
                UpdateData(anzCoins);
                MessageBox.Show($"Du hast {anzCoins } dazugewonnen");

                int temp = Convert.ToInt32(label2.Text);
                label2.Text = Convert.ToString(temp + anzCoins);
                StandardLayout(hut1, hut2, hut3, button1, label4, textBox1, pictureBox1, pictureBox2, pictureBox3, coin1, coin2, coin3);
            }
            else
            {
                MessageBox.Show("Du hast verloren :(");
                StandardLayout(hut1, hut2, hut3, button1, label4, textBox1, pictureBox1, pictureBox2, pictureBox3, coin1, coin2, coin3);
                UpdateData(anzCoins);
            }
        }
        private void hut2_Click(object sender, EventArgs e)
        {
            int anzCoins = Convert.ToInt32(label2.Text);
            int gesetzt = Convert.ToInt32(textBox1.Text);
            pictureBox2.Visible = false;
            if (label5.Text == "2")
            {
                coin1.Visible = true;
                anzCoins = gesetzt * 2;
                MessageBox.Show($"Du hast {anzCoins } dazugewonnen");
                this.anzCoins = anzCoins;
                UpdateData(anzCoins);

                int temp = Convert.ToInt32(label2.Text);
                label2.Text = Convert.ToString(temp + anzCoins);
                StandardLayout(hut1, hut2, hut3, button1, label4, textBox1, pictureBox1, pictureBox2, pictureBox3, coin1, coin2, coin3);
            }
            else
            {
                MessageBox.Show("Du hast verloren :(");
                StandardLayout(hut1, hut2, hut3, button1, label4, textBox1, pictureBox1, pictureBox2, pictureBox3, coin1, coin2, coin3);
            }
        }

        private void hut3_Click(object sender, EventArgs e)
        {
            int anzCoins = Convert.ToInt32(label2.Text);
            int gesetzt = Convert.ToInt32(textBox1.Text);
            pictureBox3.Visible = false;
            if (label5.Text == "3")
            {
                coin1.Visible = true;
                anzCoins = gesetzt * 2;
                MessageBox.Show($"Du hast {anzCoins } dazugewonnen");
                this.anzCoins = anzCoins;
                UpdateData(anzCoins);

                int temp = Convert.ToInt32(label2.Text);
                label2.Text = Convert.ToString(temp + anzCoins);
                StandardLayout(hut1, hut2, hut3, button1, label4, textBox1, pictureBox1, pictureBox2, pictureBox3, coin1, coin2, coin3);
            }
            else
            {
                MessageBox.Show("Du hast verloren :(");
                StandardLayout(hut1, hut2, hut3, button1, label4, textBox1, pictureBox1, pictureBox2, pictureBox3,coin1,coin2,coin3);
            }
        }


        static void StandardLayout(
            Button hut1, Button hut2, Button hut3, Button button1, Label label4, TextBox textBox1,PictureBox pictureBox1, PictureBox pictureBox2, PictureBox pictureBox3, PictureBox coin1, PictureBox coin2, PictureBox coin3)
        {
            hut1.Visible = false;
            hut2.Visible = false;
            hut3.Visible = false;
            button1.Visible = true;
            label4.Visible = true;
            textBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            coin1.Visible = false;
            coin2.Visible = false;
            coin3.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            string filePath = @"data.txt";
            string content = label2.Text;
            using (StreamWriter outputFile = new StreamWriter(filePath))
            {
                outputFile.WriteLine(content);
            }
        }
        static void UpdateData(int anzCoins)
        {
            using (TextWriter writer = File.CreateText("data.txt"))
            {
                writer.WriteLine(anzCoins + "\n");
            }
        }

        private void hatPicTimer_Tick(object sender, EventArgs e)
        {
            anzCoins = Convert.ToInt32(label2.Text);
            if (selectedHat == 1)
            {
                pictureBox1.BackgroundImage = System.Drawing.Image.FromFile(@"icons\hat 1 Blau.png");
                pictureBox2.BackgroundImage = System.Drawing.Image.FromFile(@"icons\hat 2 blau.png");
                pictureBox3.BackgroundImage = System.Drawing.Image.FromFile(@"icons\hat 3 blau.png");
            }
            else if (selectedHat == 2)
            {
                pictureBox1.BackgroundImage = System.Drawing.Image.FromFile(@"icons\hat 1 star.png");
                pictureBox2.BackgroundImage = System.Drawing.Image.FromFile(@"icons\hat 2 star.png");
                pictureBox3.BackgroundImage = System.Drawing.Image.FromFile(@"icons\hat 3 star.png");

            }
            else if (selectedHat == 3)
            {
                pictureBox1.BackgroundImage = System.Drawing.Image.FromFile(@"icons\hat 1 sunset.png");
                pictureBox2.BackgroundImage = System.Drawing.Image.FromFile(@"icons\hat 2 sunset.png");
                pictureBox3.BackgroundImage = System.Drawing.Image.FromFile(@"icons\hat 3 sunset.png");

            }
            else if (selectedHat == 4)
            {
                pictureBox1.BackgroundImage = System.Drawing.Image.FromFile(@"icons\hat 1 twillight.png");
                pictureBox2.BackgroundImage = System.Drawing.Image.FromFile(@"icons\hat 2 twillight.png");
                pictureBox3.BackgroundImage = System.Drawing.Image.FromFile(@"icons\hat 3 twillight.png");

            }
            else if (selectedHat == 0)
            {
                pictureBox1.BackgroundImage = System.Drawing.Image.FromFile(@"icons\1 (1).png");
                pictureBox2.BackgroundImage = System.Drawing.Image.FromFile(@"icons\1 (2).png");
                pictureBox3.BackgroundImage = System.Drawing.Image.FromFile(@"icons\1 (3).png");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            anzCoins = Convert.ToInt32(label2.Text);
            Form3 Highscores = new Form3(this);
            Highscores.Show();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
