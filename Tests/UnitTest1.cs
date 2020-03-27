using F1SeasonResult.Service;
using System;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
        ViewModel viewModel;
        DriverService driverService = new DriverService();
        string selectedYear = "1950";
        string urlDrivers = @"http://ergast.com/api/f1/" + selectedYear + "/driverstandings.json";
        string urlConstructors = @"http://ergast.com/api/f1/" + selectedYear + "/constructorstandings.json";
        driverService.GetDrivers(urlDrivers);
            driverService.GetConstructors(urlConstructors);
            viewModel = new ViewModel();
        }
}
}
