using System.Linq;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Microsoft.EntityFrameworkCore;
using rush00.App.ViewModels;
using rush00.App.Views;
using rush00.Data;

namespace rush00.App
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
            
            // auto-migration
            using var context = new HabitDbContext();
            context.Database.EnsureCreated();
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                using (var context = new HabitDbContext())
                {
                    var habit = context.Habits
                        .Include(x => x.Checks)
                        .FirstOrDefault(x => !x.IsFinished);
                }
                
                desktop.MainWindow = new HabitSettingWindow
                {
                    DataContext = new HabitSettingViewModel(),
                };
            }
            base.OnFrameworkInitializationCompleted();
        }
    }
}