using ORM.Core.Contexts.Account;
using ORM.Core.Contexts.SmtrSimple;

namespace Tests.Fakes
{
    public static class FakeAccountScope
    {
        public static AccountScope Private = new AccountScope
        {
            SCOPE_CHR = nameof(Private)
        };

        public static AccountScope Public = new AccountScope
        {
            SCOPE_CHR = nameof(Public)
        };

        public static X_Account_Scope SmtrSimplePublic = new X_Account_Scope
        {
            SCOPE_CHR = nameof(Public)
        };

        public static X_Account_Scope SmtrSimplePrivate = new X_Account_Scope
        {
            SCOPE_CHR = nameof(Private)
        };

    }
}
