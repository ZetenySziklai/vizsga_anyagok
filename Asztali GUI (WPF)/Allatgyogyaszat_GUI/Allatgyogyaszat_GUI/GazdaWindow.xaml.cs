using Allatgyogyaszat_GUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Allatgyogyaszat_GUI
{
    /// <summary>
    /// Interaction logic for KutyakWindow.xaml
    /// </summary>
    public partial class GazdaWindw : Window
    {
        private Gazda gazda;
        public GazdaWindw(Gazda g)
        {
            InitializeComponent();
            gazda = g;
            AdatokInputokba();
        }

        private void AdatokInputokba()
        {
            txtNev.Text = gazda.Nev;
            txtTelefon.Text = gazda.Telefon;
            txtEmail.Text = gazda.Email;
            txtKerulet.Text = ""+gazda.Kerulet;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            AdatokViewModel vm = new AdatokViewModel();
            Gazda g = new Gazda()
            {
                Nev = txtNev.Text,
                Telefon = txtTelefon.Text,
                Email = txtEmail.Text,
                Kerulet = Convert.ToInt16(txtKerulet.Text),
                Id = gazda.Id,
            };
            bool valasz = await vm.GazdaModositas(gazda.Id,g);
            if (valasz)
            {
                MessageBox.Show("Sikeres mód");
            }
            else
            {
                MessageBox.Show("Sikertelen");
            }
            Close();
        }
    }
}
