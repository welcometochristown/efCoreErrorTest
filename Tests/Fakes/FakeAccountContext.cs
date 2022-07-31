using Microsoft.EntityFrameworkCore;
using ORM.Core.Contexts;
using ORM.Core.Contexts.Account;

namespace Tests.Fakes
{
    public class FakeAccountContext : AccountDbContext
    {
        public FakeAccountContext(DbContextOptions<AccountContextBase> options) : base(options)
        {
            this.AccountScope.Add(FakeAccountScope.Public);
            this.Account.Add(FakeAccount.DummyAccount);

            SaveChanges();
        }

        public override void Dispose()
        {
            Database.EnsureDeleted();
            base.Dispose();
        }
    }
}
