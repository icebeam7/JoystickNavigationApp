namespace JoystickNavigationApp.Helpers
{
    public static class DirectionHelper
    {
        public static string GetDirection(double x, double y)
        {
            if (Math.Abs(x) > Math.Abs(y))
                return x > 20 ? Routes.Right : x < -20 ? Routes.Left : Routes.None;
            else
                return y > 20 ? Routes.Down : y < -20 ? Routes.Up : Routes.None;
        }
    }
}
