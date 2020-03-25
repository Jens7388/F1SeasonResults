using F1SeasonResults.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace F1SeasonResult.Service
{
    public class ViewModel
    {
        DriverService driverService;
        public ViewModel()
        {
            driverService = new DriverService();
            List<DriverStanding> drivers = driverService.GetAll();
            Drivers = new ObservableCollection<DriverStanding>(drivers);
        }

        public ObservableCollection<DriverStanding> Drivers { get; set; }
    }
}
