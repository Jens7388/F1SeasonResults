using System;
using System.Collections.Generic;
using System.Linq;
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
        public MainWindow()
        {
            InitializeComponent();
            for(int i = 1950; i < 2020; i++)
            {
                comboBoxSelectYear.Items.Add(i);
            }
        }

        private void buttonShowResults_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(comboBoxSelectYear.SelectedItem.ToString(), out int selectedYear);
        }

        private void comboBoxSelectYear_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            buttonShowResults.IsEnabled = true;
        }
    }
}
