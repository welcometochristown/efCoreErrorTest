using Microsoft.EntityFrameworkCore;

namespace ORM.Core.Contexts.SmtrSimple
{
    public class SmtrSimpleDbContext : SmtrSimpleContextBase
    {
        public SmtrSimpleDbContext(string connectionString) : this(GetOptions(connectionString))
        {
        }

        public SmtrSimpleDbContext(DbContextOptions<SmtrSimpleContextBase> options) : base(options)
        {
            //Disable change tracking since Stored Procedures are used to save the data
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        private static DbContextOptions<SmtrSimpleContextBase> GetOptions(string connectionString)
        {
            return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder<SmtrSimpleContextBase>(), connectionString).Options;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
