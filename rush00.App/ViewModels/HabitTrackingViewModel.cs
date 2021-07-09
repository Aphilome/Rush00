using System;
using System.Collections.Generic;
using rush00.App.Models;

namespace rush00.App.ViewModels
{
    public class HabitTrackingViewModel: ViewModelBase
    {
        public HabitSettingViewModel HabitSetting { get; set; }
        
        public List<HabitCheck> HabitChecks { get; set; }
    }
}