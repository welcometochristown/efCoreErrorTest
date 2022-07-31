using System.Collections.Generic;

namespace ORM.Core.Contexts.SmtrSimple
{
    public partial class X_Account_Scope
    {
        public X_Account_Scope()
        {
            Accounts = new HashSet<Account_Master>();
        }

        public string SCOPE_CHR { get; set; }

        public virtual ICollection<Account_Master> Accounts { get; set; }
    }
}
