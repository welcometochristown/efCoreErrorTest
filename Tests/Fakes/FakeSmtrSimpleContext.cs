using Microsoft.EntityFrameworkCore;
using ORM.Core.Contexts.SmtrSimple;
using System.Linq;

namespace Tests.Fakes
{
    public class FakeSmtrSimpleContext : SmtrSimpleDbContext
    {
        public FakeSmtrSimpleContext(DbContextOptions<SmtrSimpleContextBase> options) : base(options)
        {
            System.Diagnostics.Debug.WriteLine($"Constructing New Instance Of {nameof(FakeSmtrSimpleContext)}");

            PrintDebug();

            this.X_Account_Scope.Add(FakeAccountScope.SmtrSimplePublic);

            PrintDebug();

            this.Account_Master.Add(FakeAccount.SmtrSimpleDummyAccount);

            PrintDebug();

            SaveChanges();

            PrintDebug();
        }

        private void PrintDebug() => System.Diagnostics.Debug.WriteLine($"{this.Account_Master.Count()} accounts, {this.Account_Master.Local.Count()} local accounts");

        public override void Dispose()
        {
            Database.EnsureDeleted();
            base.Dispose();
        }
    }
}
