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
    public partial class Form2 : Form
    {
        private Form1 foAblak;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 ablak, NumericUpDown nud)
        {
            InitializeComponent();
            foAblak = ablak;
            label1.Text = ""+nud.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foAblak.Visible = true;
            this.Close();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            foAblak.Visible = true;
        }
    }
}
