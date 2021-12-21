
namespace HutBetrug
{
    partial class Form3
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.eingabeHighscore = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.highscoreTable = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(150, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Highscores";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(11, 307);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(557, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gib deinen Namen ein, um deinen momentan Punktestand hinzuzufügen:";
            // 
            // eingabeHighscore
            // 
            this.eingabeHighscore.Location = new System.Drawing.Point(165, 329);
            this.eingabeHighscore.Margin = new System.Windows.Forms.Padding(2);
            this.eingabeHighscore.Name = "eingabeHighscore";
            this.eingabeHighscore.Size = new System.Drawing.Size(231, 27);
            this.eingabeHighscore.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 360);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Hinzufügen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // highscoreTable
            // 
            this.highscoreTable.AutoSize = true;
            this.highscoreTable.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.highscoreTable.Location = new System.Drawing.Point(195, 75);
            this.highscoreTable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.highscoreTable.Name = "highscoreTable";
            this.highscoreTable.Size = new System.Drawing.Size(179, 20);
            this.highscoreTable.TabIndex = 4;
            this.highscoreTable.Text = "Die Liste ist noch leer!";
            this.highscoreTable.Click += new System.EventHandler(this.label3_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(104, 98);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(383, 196);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(616, 422);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.highscoreTable);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.eingabeHighscore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox eingabeHighscore;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label highscoreTable;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

