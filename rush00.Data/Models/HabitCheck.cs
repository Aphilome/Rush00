using System;

namespace rush00.Data.Models
{
    public class HabitCheck
    {
        public Guid Id { get; set; }
        
        public DateTime Date { get; set; }
        
        public bool IsChecked { get; set; }
    }
}