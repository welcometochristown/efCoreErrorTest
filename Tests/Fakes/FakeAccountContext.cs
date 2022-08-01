using Microsoft.EntityFrameworkCore;
using ORM.Core.Contexts;
using ORM.Core.Contexts.Account;
using System.Linq;

namespace Tests.Fakes
{
    public class FakeAccountContext : AccountDbContext
    {
        public FakeAccountContext(DbContextOptions<AccountContextBase> options) : base(options)
        {
            System.Diagnostics.Debug.WriteLine($"Constructing New Instance Of {nameof(FakeAccountContext)}");

            PrintDebug();

            this.AccountScope.Add(FakeAccountScope.Public);

            PrintDebug();

            this.Account.Add(FakeAccount.DummyAccount);

            PrintDebug();

            SaveChanges();

            PrintDebug();
        }

        private void PrintDebug() => System.Diagnostics.Debug.WriteLine($"{this.Account.Count()} accounts, {this.Account.Local.Count()} local accounts");


        public override void Dispose()
        {
            Database.EnsureDeleted();
            base.Dispose();
        }
    }
}
