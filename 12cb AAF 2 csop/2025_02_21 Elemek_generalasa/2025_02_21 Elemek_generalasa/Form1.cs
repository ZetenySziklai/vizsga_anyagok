using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2025_02_21_Elemek_generalasa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Button gomb = new Button();
                    gomb.Text = "" + (i * 3 + j + 1);
                    gomb.Name = "ujGomb"+(i * 3 + j + 1);
                    gomb.Width = 30;
                    gomb.Height = 30;
                    gomb.Location = new Point(200+j*35, 10+i*35);
                    gomb.Click += new EventHandler(GombClick);
                    Controls.Add(gomb);
                }
            }            
        }

        private void GombClick(object sender, EventArgs e)
        {
            Button gombSajatMaga = (Button) sender;
            MessageBox.Show(gombSajatMaga.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            //this.Close();
            Form2 UjAblak = new Form2(this, numericUpDown1);
            UjAblak.Show();
        }
    }
}
