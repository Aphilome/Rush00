using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace rush00.App.Views
{
    public class HabitTrackingWindow : Window
    {
        public HabitTrackingWindow()
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
    }
}