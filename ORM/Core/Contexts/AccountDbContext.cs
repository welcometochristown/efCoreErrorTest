using Microsoft.EntityFrameworkCore;

namespace ORM.Core.Contexts.Account
{
    public class AccountDbContext : AccountContextBase
    {
        public AccountDbContext(string connectionString) : this(GetOptions(connectionString))
        {
        }

        public AccountDbContext(DbContextOptions<AccountContextBase> options) : base(options)
        {
            //Disable change tracking since Stored Procedures are used to save the data
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        private static DbContextOptions<AccountContextBase> GetOptions(string connectionString)
        {
            return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder<AccountContextBase>(), connectionString).Options;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
        }
    }
}
