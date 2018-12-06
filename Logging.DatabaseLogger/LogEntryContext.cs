using System.Data.Entity;

using Logging.Config;

namespace Logging.DatabaseLogger
{
    public class LogEntryContext : DbContext
    {
        public LogEntryContext() : base($"name={ConfigValues.LogDbName}")
        {            
        }

        public DbSet<LogEntry> LogEntries { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new LogEntryConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
