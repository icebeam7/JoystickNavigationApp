using JoystickNavigationApp.Controls;
using JoystickNavigationApp.Helpers;
using JoystickNavigationApp.Views;

namespace JoystickNavigationApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            foreach (var route in Routes.RouteTypeMap)
                Routing.RegisterRoute(route.Key, route.Value);
        }
    }
}
