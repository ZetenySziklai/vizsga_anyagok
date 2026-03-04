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

namespace RobotPorszivok
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private int? szerkesztettErtekelesId = null;
        public MainWindow()
        {
            InitializeComponent();
            Loaded += async (s, e) =>
            {
                await ((AdatokViewModel)DataContext).RobotPorszivokBetoltese();
                await ((AdatokViewModel)DataContext).ErtekelesekBetoltese();
            };
        }

        private async void RobotPorszivoFrissites_Cick(object sender, RoutedEventArgs e)
        {
            await ((AdatokViewModel)DataContext).RobotPorszivokBetoltese();
        }   

        private async void ErtekelesFrissites_Click(object sender, RoutedEventArgs e)
        {
            await((AdatokViewModel)DataContext).ErtekelesekBetoltese();
        }
    }
}