using System;
using System.Collections.Generic;

namespace ORM.Core.Contexts.Account
{
    public partial class AccountScope
    {
        public AccountScope()
        {
            Accounts = new HashSet<Account>();
        }

        public string scope { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
