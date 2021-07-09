using System;
using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using rush00.App.ViewModels;

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

        private void ToggleButton_OnChecked(object? sender, RoutedEventArgs e)
        {
            var viewModel = DataContext as HabitTrackingViewModel;
            if (viewModel == null)
                throw new Exception("DataContext must be type of 'HabitTrackingViewModel'");
            var checkBox = (CheckBox) sender;
            if (checkBox.IsChecked == true && checkBox.DataContext == viewModel.HabitChecks.Last())
            {
                viewModel.HabitSetting.IsFinished = true;
            }
        }
    }
}