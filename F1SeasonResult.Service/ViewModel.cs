using F1SeasonResults.Entities;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace F1SeasonResult.Service
{
    public class ViewModel
    {
        DriverService driverService;

        public ViewModel()
        {
            driverService = new DriverService();
            List<DriverStanding> drivers = driverService.GetAllDrivers();
            List<ConstructorStanding> constructors = driverService.GetAllConstructors();
            Drivers = new ObservableCollection<DriverStanding>(drivers);

            if(constructors != null)
            {
                Constructors = new ObservableCollection<ConstructorStanding>(constructors);
            }
        }

        public ObservableCollection<DriverStanding> Drivers { get; set; }
        public ObservableCollection<ConstructorStanding> Constructors { get; set; }
    }
}