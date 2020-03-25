
using F1SeasonResult.Service;
using F1SeasonResults.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
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
                comboBoxSelectYear.Items.Add(i);
            }
            DataContext = viewModel;
        }

        private void buttonShowResults_Click(object sender, RoutedEventArgs e)
        {
            string selectedYear = comboBoxSelectYear.SelectedItem.ToString();
            string url = @"http://ergast.com/api/f1/" + selectedYear + "/driverstandings.json";
            driverService.GetDrivers(url);
            viewModel = new ViewModel();
            DataContext = viewModel;
        }

        private void comboBoxSelectYear_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            buttonShowResults.IsEnabled = true;
        }
        
    }
}