using Microsoft.Win32;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _2025_03_20_Events;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MyViewModel();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        Button b = (Button)sender;
        MessageBox.Show(""+b.Content);
    }

    private void Kalapacs(object sender, RoutedEventArgs e)
    {
        ButtonBase? b = e.Source as ButtonBase;
        if (e.Source != null && b.GetType() == typeof(Button))
            MessageBox.Show("" + b.Content);

    }

    private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
    {
        SaveFileDialog sDialog = new SaveFileDialog();
        if (sDialog.ShowDialog() == true)
        {
            MessageBox.Show(sDialog.FileName);
        }
    }

    private void Window_KeyDown(object sender, KeyEventArgs e)
    {
        if (Keyboard.Modifiers == ModifierKeys.Control && e.Key == Key.D)
        {
            MessageBox.Show("control d kombináció");
        }
    }
}