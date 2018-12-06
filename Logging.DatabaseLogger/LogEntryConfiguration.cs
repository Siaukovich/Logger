using System.Data.Entity.ModelConfiguration;

namespace Logging.DatabaseLogger
{
    internal class LogEntryConfiguration : EntityTypeConfiguration<LogEntry>
    {
        public LogEntryConfiguration()
        {
            ToTable("logEntries");
            HasKey(e => e.Id);
            Property(e => e.Level).IsRequired();
            Property(e => e.LogTime).IsRequired();
            Property(e => e.Message).IsUnicode().IsRequired();
            Property(e => e.ExceptionInfo).IsUnicode().IsOptional();
        }
    }
}
