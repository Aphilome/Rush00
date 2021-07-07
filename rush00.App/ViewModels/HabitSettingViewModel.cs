using System;
using System.Collections.Generic;
using System.Text;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace rush00.App.ViewModels
{
    public class HabitSettingWindowViewModel : ViewModelBase
    {
        public HabitSettingWindowViewModel()
        {
            
        }
        
        public string HabitSet => "Set a habit to track:";
        
        public string MotivationSet => "What would be a motivation:";
        
        public string StartDateHabitSet => "When will you start:";
        
        public string DaysQuantitySet => "How many days you want to challenge yourself for:";
        
        public string LetsStartButton => "Let's start!";

        private DateTimeOffset? _startDate = new DateTimeOffset(new DateTime(1950, 1, 1));
        public DateTimeOffset? StartDate
        {
            get => _startDate == null ? null : new DateTimeOffset(_startDate.Value.DateTime);
            set
            {
                _startDate = value;
            }
        }
    }
}
