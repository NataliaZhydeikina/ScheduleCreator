using Microsoft.EntityFrameworkCore;
namespace ScheduleCreator.Models
{
    public class ScheduleContext: DbContext
    {
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Schedule> Schedules { get; set; }

        public ScheduleContext(DbContextOptions<ScheduleContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
