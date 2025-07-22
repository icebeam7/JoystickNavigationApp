//Credits: https://blog.ewers-peters.de/add-automatic-route-registration-to-your-net-maui-app

using JoystickNavigationApp.Helpers;

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
