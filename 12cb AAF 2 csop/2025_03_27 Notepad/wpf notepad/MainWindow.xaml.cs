using Microsoft.Win32;
using System.IO;
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

namespace wpf_notepad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MyViewModel(tabcontrol);
            GyorsParancsok();
        }

        private void GyorsParancsok()
        {
            string exitKey = "Q";
            menuItemExit.InputGestureText = "Ctrl+" + exitKey;

        }

        private void Save_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog sDialog = new SaveFileDialog();
            if (sDialog.ShowDialog() == true)
            {
                using (StreamWriter sw = new StreamWriter(sDialog.FileName))
                {
                    TabItem tabitem = (TabItem)tabcontrol.SelectedItem;
                    RichTextBox richTextBox = (RichTextBox)tabitem.Content;
                    TextRange textRange = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
                    sw.Write(textRange.Text);
                    //sw.Close();
                }
            }
        }

        private void Open_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog sDialog = new OpenFileDialog();
            if (sDialog.ShowDialog() == true)
            {
                using (StreamReader sr = new StreamReader(sDialog.FileName))
                {
                    TabItem tabitem = (TabItem)tabcontrol.SelectedItem;
                    RichTextBox richTextBox = (RichTextBox)tabitem.Content;
                    string text = sr.ReadToEnd();
                    richTextBox.AppendText(text);                    
                    sr.Close();
                }
            }
        }

        private void Close_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }

        private void TabItem_MouseDown(object sender, MouseButtonEventArgs e)
        {

            if (tabcontrol.Items.Count > 1 && e.ChangedButton == MouseButton.Middle) { 
                tabcontrol.Items.RemoveAt(tabcontrol.SelectedIndex);
            }
        }
    }
}