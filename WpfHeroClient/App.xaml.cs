using System.Windows;
using WpfHeroClient.Service;

namespace WpfHeroClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            // Configure Hero REST API client
            HeroServiceClient.ConfigureClient();

            // Create the startup window
            MainWindow wnd = new MainWindow();

            // Show the window
            wnd.Show();
        }
    }
}
