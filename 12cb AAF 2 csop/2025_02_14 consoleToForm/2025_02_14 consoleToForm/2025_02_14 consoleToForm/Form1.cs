using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2024_02_06_FutoversenyProjekt;

namespace _2025_02_14_consoleToForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            VersenyzokFelvetele();
        }
        

        private void VersenyzokFelvetele()
        {
            Versenyzo versenyzo = new Versenyzo("123D", "Béla", true);
            Futas f1 = new Futas("01:20:15", "01:28:05");
            Futas f2 = new Futas("01:20:15", "02:15:05");
            Versenytipus vt = new Versenytipus("123kl", 100, new DateTime(2025, 02, 06));
            Versenytipus vt2 = new Versenytipus("987hv", 20000, new DateTime(2025, 02, 07));

            versenyzo.VersenyzoEredmenye(vt, f1);
            versenyzo.VersenyzoEredmenye(vt2, f2);

            Futtathato.VersenyzoFelvetele(versenyzo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Futtathato.versenyzok.ForEach(x =>
                listBox1.Items.Add(x)
            );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index > -1)
            {
                Versenyzo v = Futtathato.versenyzok[index];
                MessageBox.Show(Futtathato.LegjobbEredmenye(v));
            }
            else
            {
                MessageBox.Show("Nincs elem kijelölve!");
            }
        }
    }
}
