using Microsoft.EntityFrameworkCore;
using ORM.Core.Contexts.SmtrSimple;

namespace Tests.Fakes
{
    public class FakeSmtrSimpleContext : SmtrSimpleDbContext
    {
        public FakeSmtrSimpleContext(DbContextOptions<SmtrSimpleContextBase> options) : base(options)
        {
            this.X_Account_Scope.Add(FakeAccountScope.SmtrSimplePublic);
            this.Account_Master.Add(FakeAccount.SmtrSimpleDummyAccount);

            SaveChanges();
        }

        public override void Dispose()
        {
            Database.EnsureDeleted();
            base.Dispose();
        }
    }
}
