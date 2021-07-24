using Microsoft.EntityFrameworkCore;
using rush00.Data.Models;

namespace rush00.Data
{
    public class HabitDbContext: DbContext
    {
        public DbSet<Habit> Habits;
        public DbSet<HabitCheck> HabitChecks;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=habits.db");
        }
    }
}