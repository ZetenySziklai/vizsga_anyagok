using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2025_01_31_FormAlapok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void szinezesBtn_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Aqua;
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //decimal osszeg = szam1NUD.Value + szam2NUD.Value;
            //int osszeg = (int)(szam1NUD.Value + szam2NUD.Value);
            double eredmeny = 0;
            //switch(MuveletCombo.SelectedIndex)
            switch ("" + MuveletCombo.Text)
            {
                //case 0: 
                case "+":
                    eredmeny = (double)(szam1NUD.Value + szam2NUD.Value);
                    break;
                case "-":
                    eredmeny = (double)(szam1NUD.Value - szam2NUD.Value);
                    break;
                case "*":
                    eredmeny = (double)(szam1NUD.Value * szam2NUD.Value);
                    break;
                case "/":
                    eredmeny = (double)(szam1NUD.Value / szam2NUD.Value);
                    break;
                case "maradék":
                    eredmeny = (double)(szam1NUD.Value % szam2NUD.Value);
                    break;
                case "hatvány":
                    eredmeny = Math.Pow((double)szam1NUD.Value ,(double) szam2NUD.Value);
                    break;
            }

            EredmenyLabel.Text = "" + eredmeny;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MuveletCombo.Text = ""+MuveletCombo.Items[0];
        }

        private void EredmenyLabel_Click(object sender, EventArgs e)
        {

        }

        private void szam2NUD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void szam1NUD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MuveletCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //foreach (var item in this.Controls)
            //{
            //    item.ForeColor = Color.Red;
            //}
            label3.ForeColor = Color.Red;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Green;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Blue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains(textBox1.Text))
                MessageBox.Show("Van már ilyen elem!");
            else
                listBox1.Items.Add(textBox1.Text);
        }
    }
}
