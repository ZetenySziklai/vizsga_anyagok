using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024_05_22_FormAlapok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green;
            label1.Text = "Ez egy label (címke)";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Font = new Font(button1.Font.FontFamily, 12);
            string txt = textBox1.Text;
            label1.Text = txt;
            button1.Size = new Size(200, 70);
            //MessageBox.Show("Ez egy felugró üzenet.");
            MessageBox.Show("Ez egy felugró üzenet.","Ez egy ablak");

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            Random r = new Random();
            button1.Text = "Egér ráhúzás";
           //button1.Location = new Point(r.Next(500),r.Next(500));


        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            //Random r = new Random();
            //button1.Location = new Point(r.Next(500), r.Next(500));

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string kivalasztottSzoveg = comboBox2.Text;
            string kivalasztottSzoveg = comboBox2.SelectedItem.ToString();
            //int kivalasztottIndex = comboBox2.SelectedIndex;
            //MessageBox.Show("Kiválasztott elem: "+kivalasztottSzoveg);
            MessageBox.Show("Kiválasztott elem indexe: "+kivalasztottSzoveg);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Add(textBox1.Text);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //this - Form ablakra vonatkozó beállítások meghívásához
            this.BackColor = Color.Green;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                MessageBox.Show(checkBox1.Text);
        }
    }
}
