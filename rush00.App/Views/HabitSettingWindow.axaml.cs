using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using rush00.App.ViewModels;

namespace rush00.App.Views
{
    public partial class HabitSettingWindow : Window
    {
        public HabitSettingWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void Button_OnClick(object? sender, RoutedEventArgs e)
        {
            Hide();
            var habitTracking = new HabitTrackingWindow();
            habitTracking.DataContext = new HabitTrackingViewModel();
            habitTracking.Show();
            Close();
        }
    }
}