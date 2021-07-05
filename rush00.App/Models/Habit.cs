
namespace rush00.App.Models
{
    public class Habit
    {
        public string Title { get; set; }
        public string Motivation { get; set; }
        public HabitCheck[]? Checks { get; set; }
        public bool IsFinished { get; set; }
    }
}