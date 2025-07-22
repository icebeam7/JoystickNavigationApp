using JoystickNavigationApp.Helpers;

namespace JoystickNavigationApp.Controls;

public partial class JoystickControl : ContentView
{
    private double _radius = 40;

    public JoystickControl()
	{
		InitializeComponent();

        var panGesture = new PanGestureRecognizer();
        panGesture.PanUpdated += OnPanUpdated;
        this.GestureRecognizers.Add(panGesture);
    }

    private void OnPanUpdated(object sender, PanUpdatedEventArgs e)
    {
        switch (e.StatusType)
        {
            case GestureStatus.Running:
                double x = Math.Clamp(e.TotalX, -_radius, _radius);
                double y = Math.Clamp(e.TotalY, -_radius, _radius);
                Thumb.TranslationX = x;
                Thumb.TranslationY = y;
                break;

            case GestureStatus.Completed:
                var direction = DirectionHelper.GetDirection(Thumb.TranslationX, Thumb.TranslationY);
                Navigate(direction);
                ResetThumb();
                break;
        }
    }

    private async void Navigate(string direction)
    {
        if (direction != Routes.None)
            await Shell.Current.GoToAsync(direction);
    }

    private async void ResetThumb()
    {
        await Thumb.TranslateTo(0, 0, 100, Easing.CubicOut);
    }
}