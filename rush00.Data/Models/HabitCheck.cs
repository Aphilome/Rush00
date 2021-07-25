using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace rush00.Data.Models
{
    public class HabitCheck
    {
        public Guid Id { get; set; }
        
        public DateTime Date { get; set; }
        
        public bool IsChecked { get; set; }
        
        public Guid HabitId { get; set; }
        
        [ForeignKey(nameof(HabitId))]
        public Habit Habit { get; set; }
    }
}