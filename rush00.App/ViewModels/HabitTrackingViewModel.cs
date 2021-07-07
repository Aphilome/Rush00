using System;
using System.Collections.Generic;
using rush00.App.Models;

namespace rush00.App.ViewModels
{
    public class HabitTrackingViewModel: ViewModelBase
    {
        public List<HabitCheck> MyItems { get; set; } = new List<HabitCheck>()
        {
            new HabitCheck
            {
                Date = DateTime.Today,
                IsChecked = false
            },
            new HabitCheck
            {
                Date = DateTime.Today,
                IsChecked = false
            },
        };
    }
}