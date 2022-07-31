using Microsoft.EntityFrameworkCore;

namespace ORM.Core.Contexts.SmtrSimple
{
    public partial class SmtrSimpleContextBase : DbContext
    {
        public SmtrSimpleContextBase()
        {
        }

        public SmtrSimpleContextBase(DbContextOptions<SmtrSimpleContextBase> options)
            : base(options)
        {
        }

        public virtual DbSet<Account_Master> Account_Master { get; set; }
        public virtual DbSet<X_Account_Scope> X_Account_Scope { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
// To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=Smtr;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account_Master>(entity =>
            {
                entity.HasKey(e => e.NUMBER_INT)
                    .HasName("Account_Master_pk");

                entity.Property(e => e.SCOPE_CHR)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Scope)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.SCOPE_CHR)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("OP_X_Account_Scope_OP_Account_Master_SCOPE_CHR_fk");
            });

            modelBuilder.Entity<X_Account_Scope>(entity =>
            {
                entity.HasKey(e => e.SCOPE_CHR)
                    .HasName("X_Account_Scope_pk");

                entity.Property(e => e.SCOPE_CHR)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

