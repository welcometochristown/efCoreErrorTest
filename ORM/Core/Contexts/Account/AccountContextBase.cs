using Microsoft.EntityFrameworkCore;

namespace ORM.Core.Contexts.Account
{
    public partial class AccountContextBase : DbContext
    {
        public AccountContextBase()
        {
        }

        public AccountContextBase(DbContextOptions<AccountContextBase> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<AccountScope> AccountScope { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
// To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=AccountDatabase;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.NUMBER_INT)
                    .HasName("Account_pk");

                entity.Property(e => e.SCOPE_CHR)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Scope)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.SCOPE_CHR)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Account_AccountScope");
            });

            modelBuilder.Entity<AccountScope>(entity =>
            {
                entity.HasKey(e => e.SCOPE_CHR)
                    .HasName("PK_Scope");

                entity.Property(e => e.SCOPE_CHR)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

