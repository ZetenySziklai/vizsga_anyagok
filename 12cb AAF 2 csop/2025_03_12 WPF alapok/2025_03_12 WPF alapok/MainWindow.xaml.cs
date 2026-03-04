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

namespace _2025_03_12_WPF_alapok
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Kiskutyus(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("kis ablak");
            //Button b = (Button)sender;
            //b.Background = Brushes.Red;

            label1.Background = Brushes.Green;
        }

        private void Nagykutyus(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("főablak");
            label1.Background = Brushes.Red;
        }
    }
}