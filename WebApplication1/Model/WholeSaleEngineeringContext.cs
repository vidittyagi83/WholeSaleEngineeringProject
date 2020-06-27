using Microsoft.EntityFrameworkCore;


namespace WholeSaleEngineeringApi.Model
{
    public class WholeSaleEngineeringContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
        public virtual DbSet<Accounts> Accounts { get; set; }
        public virtual DbSet<Transactions> Transactions { get; set; }
        public WholeSaleEngineeringContext(DbContextOptions<WholeSaleEngineeringContext> options) : base(options)
        {

        }
        public static string ConnectionString
        {
            get;
            set;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accounts>(entity =>
            {
                entity.HasKey(e => new { e.AccountId });


                entity.Property(e => e.AccountId)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyType)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BalanceDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Transactions>(entity =>
            {
                entity.HasKey(e => new { e.TransactionId });


                entity.Property(e => e.TransactionId)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyType)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");
            });
        }
    }
}
