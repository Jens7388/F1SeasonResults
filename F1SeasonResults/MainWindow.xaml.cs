using F1SeasonResult.Service;
using System.Windows;
using System.Windows.Controls;

namespace F1SeasonResults
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow: Window
    {
        private ViewModel viewModel;
        public static DriverService driverService = new DriverService();

        public MainWindow()
        {
            InitializeComponent();
            for(int i = 1950; i < 2020; i++)
            {
                ComboBoxSelectYear.Items.Add(i);
            }
        }

        private void ButtonShowResults_Click(object sender, RoutedEventArgs e)
        {
            string selectedYearString = ComboBoxSelectYear.SelectedItem.ToString();
            int.TryParse(selectedYearString, out int selectedYear);
            if(selectedYear < 1958)
            {
                MessageBox.Show("Note: There was no constructors championship until 1958, so no constructors will be shown!");
            }

            string urlDrivers = @"http://ergast.com/api/f1/" + selectedYearString + "/driverstandings.json";
            string urlConstructors = @"http://ergast.com/api/f1/" + selectedYearString + "/constructorstandings.json";
            driverService.GetDrivers(urlDrivers);
            driverService.GetConstructors(urlConstructors);         
            viewModel = new ViewModel();
            DataContext = viewModel;
        }

        private void ComboBoxSelectYear_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ButtonShowResults.IsEnabled = true;
        }      
    }
}