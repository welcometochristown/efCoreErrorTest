using ORM.Core.Contexts.Account;
using Xunit;

namespace Tests.Tests
{
    public class AccountTest
    {
        public readonly AccountDbContext AcountContext;

        public AccountTest(AccountDbContext accountContext)
        {
            AcountContext = accountContext;
        }

        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        public void Test2()
        {
            Assert.True(true);
        }
    }
}
