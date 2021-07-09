using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using rush00.App.ViewModels;
using rush00.App.Views;

namespace rush00.App
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new HabitSettingWindow
                {
                    DataContext = new HabitSettingViewModel(),
                };
            }
            base.OnFrameworkInitializationCompleted();
        }
    }
}