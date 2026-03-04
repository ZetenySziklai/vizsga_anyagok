using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _2026_01_26_HttpClient_Filmek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private FilmekViewModel vm;
        private bool mentesGomb = true;
        public MainWindow()
        {
            InitializeComponent();
            BtnMentes.Visibility = Visibility.Visible;
            BtnModositas.Visibility = Visibility.Collapsed;

            Loaded += async (s, e) =>
            {
                AdatokFrissitese();
            };
        }

        private async void AdatokFrissitese()
        {
            vm = (FilmekViewModel)DataContext;
            await vm.AdatokBetoltese();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TxtCim.Text.Length > 0 && TxtErtekeles.Text.Length > 0 && TxtHossz.Text.Length > 0)
            {
                Megjelenites();
            }
            else
            {
                MessageBox.Show("Töltse ki mindhárom sort! (Cím, hossz, értékelés)");
            }
        }

        private async void Megjelenites()
        {
            int a;
            if (int.TryParse(TxtHossz.Text, out a))
            {
                Film film = new Film
                {
                    Cim = TxtCim.Text,
                    Hossz = a,
                    Ertekeles = double.Parse(TxtErtekeles.Text)
                };

                //ApiService apis = new ApiService();
                //bool siker = await apis.AddFilmekAsync(film);
                bool siker = await vm.AdatokFeltoltese(film);
                if (siker)
                {
                    MessageBox.Show("Sikeres mentés!");
                    AdatokFrissitese();
                    TxtCim.Clear();
                    TxtErtekeles.Clear();
                    TxtHossz.Clear();
                }
                else
                {
                    MessageBox.Show("Hiba történt a mentés során!");
                }
            }
            else
                MessageBox.Show("A hossz-nál lévő érték nem alakítható számmá!");
        }

        private async void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            //Button sajatmagam = (Button)sender;
            //sajatmagam.DataContext
            string cim = TxtDeleteCim.Text;
            bool siker = await vm.AdatTorlese(cim);
            if (siker)
            {
                MessageBox.Show("Sikeres törlés!");
                AdatokFrissitese();
                TxtDeleteCim.Clear();
            }
            else {
                MessageBox.Show("Hiba történt a törlés során!");
            }
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = (DataGrid)sender; 
            BtnMentes.Visibility = Visibility.Collapsed;
            BtnModositas.Visibility = Visibility.Visible;
            TxtCim.IsEnabled = false;
            if (dg.SelectedItem is Film item)
            {
                //MessageBox.Show(item.Cim);
                TxtCim.Text = item.Cim;
                TxtHossz.Text = ""+item.Hossz;
                TxtErtekeles.Text = ""+item.Ertekeles;
                
            }

        }

        private async void Button_Click_Modositas(object sender, RoutedEventArgs e)
        {
            string cim =  ((Film)DataGrid_Filmek.SelectedItem).Cim;
            Film film = new Film
            {
                Cim = TxtCim.Text,
                Hossz = int.Parse(TxtHossz.Text),
                Ertekeles = double.Parse(TxtErtekeles.Text)
            };
            bool siker = await vm.AdatModositas(cim, film);
            if (siker)
            {
                MessageBox.Show("Sikeres módosítás!");
                AdatokFrissitese();
            }
            else
            {
                MessageBox.Show("Hiba történt a módosítás során!");
            }
            TxtCim.Clear();
            TxtHossz.Clear();
            TxtErtekeles.Clear();
            TxtCim.IsEnabled = true;
            BtnMentes.Visibility = Visibility.Visible;
            BtnModositas.Visibility = Visibility.Collapsed;
        }

        private async void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            Button gomb = (Button)sender;
            Film film = (Film)gomb.DataContext;
            //Button gomb = sender as Button;
            //Film film = gomb.DataContext as Film;

            if (film != null)
            {
                var valasz = MessageBox.Show($"Biztosan akarod törölni a {film.Cim} adatait?","Törlés megerősítése",MessageBoxButton.YesNo);
                if (valasz == MessageBoxResult.Yes)
                {
                    await vm.AdatTorlese(film.Cim);
                    await vm.AdatokBetoltese();
                }
            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Button gomb = (Button)sender;
            Film film = (Film)gomb.DataContext;

            TxtCim.Text = film.Cim.ToString();
            TxtHossz.Text = film.Hossz.ToString();
            TxtErtekeles.Text = film.Ertekeles.ToString();

            BtnMentes.Visibility = Visibility.Collapsed;
            BtnModositas.Visibility = Visibility.Visible;
        }
    }
}