namespace JoystickNavigationApp.Helpers
{
    public static class DirectionHelper
    {
        private static double sensitivity = 20;

        public static string GetDirection(double x, double y)
        {
            if (Math.Abs(x) > Math.Abs(y))
                return x > sensitivity ? Routes.Right : x < -sensitivity ? Routes.Left : Routes.None;
            else
                return y > sensitivity ? Routes.Down : y < -sensitivity ? Routes.Up : Routes.None;
        }
    }
}
