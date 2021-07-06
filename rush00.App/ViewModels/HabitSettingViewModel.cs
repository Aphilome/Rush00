using System;
using System.Collections.Generic;
using System.Text;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace rush00.App.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string HabitSet => "Set a habit to track:";
        public string MotivationSet => "What would be a motivation:";
        public string StartDateHabitSet => "When will you start:";
        public string DaysQuantitySet => "How many days you want to challenge yourself for:";
        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            //this.Close();
        }
    }
}
