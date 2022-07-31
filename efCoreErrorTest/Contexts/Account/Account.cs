using System;
using System.Collections.Generic;

namespace ORM.Core.Contexts.Account
{
    public partial class Account
    {
        public int id { get; set; }
        public string scope { get; set; }

        public virtual AccountScope Scope { get; set; }
    }
}
