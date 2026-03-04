using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024_05_29_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("körte");
            listBox1.Items.Add("alma");
            listBox1.Items.Add("ribizli");
            //textBox1.Text = listBox1.Items[0].ToString();
            bool vanePipa = checkBox1.Checked;
            numericUpDown1.Visible = vanePipa;
            button4.Enabled = vanePipa;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* HF
             * Ne lehessen kétszer ugyan azt a szöveget felvenni a listába!
             * listBox1.Items[i].ToString()*/

            string ujAdat = textBox1.Text;
            if (ujAdat.Length == 0)
                MessageBox.Show("Nincs kitöltve a beviteli mező!", "Figyelmeztetés!");
            else
                listBox1.Items.Add(ujAdat);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
                textBox1.Text = listBox1.SelectedItem.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /* Használd a házi feladatban megírt eldöntés, arra hogy már meglévő elemre ne lehessen módosítani!*/ 

            int index = listBox1.SelectedIndex;
            listBox1.Items[index] = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(index);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool vanePipa = checkBox1.Checked;
            numericUpDown1.Visible = vanePipa;
            button4.Enabled = vanePipa;
        }
    }
}
