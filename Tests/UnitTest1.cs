using F1SeasonResult.Service;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestMethods()
        {
            ViewModel viewModel;
            DriverService driverService = new DriverService();
            string selectedYearString = "1950";
            string urlDrivers = @"http://ergast.com/api/f1/" + selectedYearString + "/driverstandings.json";
            string urlConstructors = @"http://ergast.com/api/f1/" + selectedYearString + "/constructorstandings.json";
            driverService.GetDrivers(urlDrivers);
            driverService.GetConstructors(urlConstructors);
            viewModel = new ViewModel();
        }

        [Fact]
        public void TestYear()
        {
            DriverService driverService = new DriverService();
            string selectedYearString = "1957";
            string urlConstructors = @"http://ergast.com/api/f1/" + selectedYearString + "/constructorstandings.json";
            Assert.True(driverService.GetConstructors(urlConstructors) == null);
        }
    }
}
