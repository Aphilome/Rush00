using System;
using System.Collections.Generic;
using System.Text;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace rush00.App.ViewModels
{
    public class HabitSettingViewModel : CustomViewModelBase
    {
        public string HabitSet => "Set a habit to track:";
        
        private string _habitNameInput;
        public string HabitNameInput 
        { 
            get => _habitNameInput;
            set
            {
                _habitNameInput = value;
                OnPropertyChanged(nameof(IsButtonShow));
            }
        }

        public string MotivationSet => "What would be a motivation:";

        private string _habitMotivationInput;
        public string HabitMotivationInput 
        { 
            get => _habitMotivationInput;
            set
            {
                _habitMotivationInput = value;
                OnPropertyChanged(nameof(IsButtonShow));
            }
        }
        
        public string StartDateHabitSet => "When will you start:";
        
        public string DaysQuantitySet => "How many days you want to challenge yourself for:";

        private uint _habitDayInput;
        public uint HabitDayInput 
        { 
            get => _habitDayInput;
            set
            {
                _habitDayInput = value;
                OnPropertyChanged(nameof(IsButtonShow));
            }
        }
        
        public string LetsStartButton => "Let's start!";

        private DateTimeOffset _startDate = new(DateTime.Today);
        public DateTimeOffset StartDate
        {
            get => new(_startDate.DateTime);
            set => _startDate = value;
        }

        public bool IsButtonShow => !(HabitDayInput <= 0
                                     || string.IsNullOrWhiteSpace(HabitNameInput)
                                     || string.IsNullOrWhiteSpace(HabitMotivationInput));
        
        public bool IsFinished { get; set; }
    }
}
