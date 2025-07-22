//Credits: https://blog.ewers-peters.de/add-automatic-route-registration-to-your-net-maui-app

using System.Collections.ObjectModel;
using JoystickNavigationApp.Views;

namespace JoystickNavigationApp.Helpers
{
    public static class Routes
    {
        public const string Up = "up";
        public const string Down = "down";
        public const string Left = "left";
        public const string Right = "right";
        public const string None = "none";

        private static Dictionary<string, Type> routeTypeMap = new()
        {
            { Up, typeof(UpView) },
            { Down, typeof(DownView) },
            { Left, typeof(LeftView) },
            { Right, typeof(RightView) }
        };

        public static ReadOnlyDictionary<string, Type> RouteTypeMap => routeTypeMap.AsReadOnly();
    }
}
