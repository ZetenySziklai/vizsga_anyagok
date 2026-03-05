using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Allatgyogyaszat_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AdatokViewModel vm = new AdatokViewModel();
        List<Gazda> gazdak = new List<Gazda>();
        public MainWindow()
        {
            InitializeComponent();
            AdatokBetoltese();
            
        }

        private void CombobocbaKeruletek()
        {
            List<int> keruletek = gazdak.Select(c => c.Kerulet).Distinct().OrderByDescending(x=>x).ToList();
            keruletek.ForEach(x=> comboKerulet.Items.Add(x));

        }
        private void AdatokListboxba(List<Gazda> gazdak)
        {
            listbox.Items.Clear();
            foreach (var item in gazdak)
            {
                listbox.Items.Add(item);
            }
        }

        private async void AdatokBetoltese()
        {
            await vm.GazdakBetoltese();
            gazdak = vm.Gazdak.ToList();
            AdatokListboxba(gazdak);
            CombobocbaKeruletek(); 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AdatokBetoltese();
        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {
            string nev = txtAdatsor.Text;
            if (nev.Length != 0)
            {
                List<Gazda> szurt = gazdak.Where(c => c.Nev.Length >= nev.Length && c.Nev.Substring(0, nev.Length).ToLower() == nev.ToLower()).ToList();
                AdatokListboxba(szurt);
            }
            else
            {
                AdatokListboxba(gazdak);
            }
        }

        private void comboKerulet_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int kerulet = Convert.ToInt16(comboKerulet.SelectedItem);
            List<Gazda> szurt = gazdak.Where(x=>x.Kerulet == kerulet).ToList();
            AdatokListboxba(szurt);
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            groupUj.Visibility = Visibility.Visible;
        }
        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            groupUj.Visibility = Visibility.Collapsed;
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string[] st = txtAdatsor.Text.Split(";");
            Gazda g = new Gazda()
            {
                Nev = st[0],
                Telefon = st[1],
                Email = st[2],
                Kerulet = Convert.ToInt32(st[3])
            };
            bool valasz = await vm.GazdaFeltoltese(g);
            if (valasz)
            {
                MessageBox.Show("Sikeres FELTOLTESD");
            }
            else
            {
                MessageBox.Show("Sikertelen");
            }
        }
        private void  listbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Gazda g = (Gazda)listbox.SelectedItem;
            GazdaWindw gw = new GazdaWindw(g);
            gw.Show();
        }
    }
}