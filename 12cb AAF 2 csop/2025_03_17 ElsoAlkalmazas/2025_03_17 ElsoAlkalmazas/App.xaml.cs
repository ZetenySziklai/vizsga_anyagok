using System.Configuration;
using System.Data;
using System.Windows;

namespace _2025_03_17_ElsoAlkalmazas
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private Mutex instanceMutex = null;

        protected override void OnStartup(StartupEventArgs e)
        {
            bool createdNew;
            instanceMutex = new Mutex(true, "EgyediNev", out createdNew);
            if (!createdNew)
            {
                MessageBox.Show("Az alkalmazás már fut egy példányban.");
                Application.Current.Shutdown();
                return;
            }


            base.OnStartup(e);
        }

    }
}
