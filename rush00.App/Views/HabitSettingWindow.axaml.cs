using System;
using System.Collections.Generic;
using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using rush00.App.ViewModels;
using rush00.Data.Models;

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
            var viewModel = DataContext as HabitSettingViewModel;
            if (viewModel == null)
                throw new Exception("DataContext must be type of 'HabitSettingViewModel'");
            var habitTrackingViewModel = new HabitTrackingViewModel();
            habitTrackingViewModel.HabitSetting = viewModel;
            habitTrackingViewModel.HabitChecks = new List<HabitCheck>((int)viewModel.HabitDayInput);
            for (int i = 0; i < viewModel.HabitDayInput; i++)
            {
                habitTrackingViewModel.HabitChecks.Add(
                    new HabitCheck
                    {
                        Date = viewModel.StartDate.DateTime.AddDays(i)
                    });
            }
            if (DateTime.Today > habitTrackingViewModel.HabitChecks.Last().Date)
            {
                viewModel.IsFinished = true;
            }
            
            Hide();
            var habitTracking = new HabitTrackingWindow();
            habitTracking.DataContext = habitTrackingViewModel;
            habitTracking.Show();
            Close();
        }
    }
}