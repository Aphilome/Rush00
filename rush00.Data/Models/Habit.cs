using System;

namespace rush00.Data.Models
{
    public class Habit
    {
        public Guid Id { get; set; }
        
        public string Title { get; set; }
        
        public string Motivation { get; set; }
        
        public bool IsFinished { get; set; }
        
        public HabitCheck[] Checks { get; set; }
    }
}
