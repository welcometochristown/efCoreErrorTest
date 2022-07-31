
namespace ORM.Core.Contexts.SmtrSimple
{
    public partial class Account_Master
    {
        public int NUMBER_INT { get; set; }
        public string SCOPE_CHR { get; set; }
     
        public virtual X_Account_Scope Scope { get; set; }
    }
}
