using System.Windows;
using System.Windows.Controls;
using WpfHeroClient.Models;
using WpfHeroClient.Service;

namespace WpfHeroClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // TODO: Still need to implement the following features:
            // Delete hero
            // Create/Update Hero
            // Show details another place than the form
            // Ability to switch between list and create form?
            InitializeComponent();

            lvHeroes.SelectionChanged += new SelectionChangedEventHandler(lvHeroes_SelectionChanged);

            // Populate the listview with heroes from the REST api
            lvHeroes.ItemsSource = HeroServiceClient.GetHeroes();
        }

        // Show details of the selected hero in the create/update form
        private void lvHeroes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tbName.Text = ((Hero)lvHeroes.SelectedValue).Name;
            tbStrength.Text = ((Hero)lvHeroes.SelectedValue).Strength.ToString();
        }
    }
}
