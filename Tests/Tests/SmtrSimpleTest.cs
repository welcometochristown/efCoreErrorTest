using ORM.Core.Contexts.SmtrSimple;
using Xunit;

namespace Tests.Tests
{
    public class SmtrSimpleTest
    {
        public readonly SmtrSimpleDbContext SmtrContext;

        public SmtrSimpleTest(SmtrSimpleDbContext smtrContext)
        {
            SmtrContext = smtrContext;
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
