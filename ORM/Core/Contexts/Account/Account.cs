namespace ORM.Core.Contexts.Account
{
    public partial class Account
    {
        public int NUMBER_INT { get; set; }
        public string SCOPE_CHR { get; set; }

        public virtual AccountScope Scope { get; set; }
    }
}
