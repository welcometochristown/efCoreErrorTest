using ORM.Core.Contexts.Account;
using ORM.Core.Contexts.SmtrSimple;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.Fakes
{
    public static class FakeAccount
    {
        public static Account DummyAccount = new Account
        {
            NUMBER_INT = 1,
            SCOPE_CHR = FakeAccountScope.Public.SCOPE_CHR
        };


        public static Account_Master SmtrSimpleDummyAccount => new Account_Master
        {
            NUMBER_INT = 1,
            SCOPE_CHR = FakeAccountScope.SmtrSimplePublic.SCOPE_CHR,
        };
    }
}
