using System;
using System.Collections.Generic;

namespace rush00.Data.Models
{
    public class Habit
    {
        public Guid Id { get; set; }
        
        public string Title { get; set; }
        
        public string Motivation { get; set; }
        
        public bool IsFinished { get; set; }

        public List<HabitCheck> Checks { get; set; }
    }
}
