// AppDbContext.cs
using Microsoft.EntityFrameworkCore;
using SimpleBankApp.Data.Entities;

namespace SimpleBankApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 对 AccountNumber、Username、Email 做唯一索引
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();
            modelBuilder.Entity<BankAccount>()
                .HasIndex(a => a.AccountNumber)
                .IsUnique();

            // 可以根据需求再做更多配置，比如 decimal 精度等
            modelBuilder.Entity<BankAccount>()
                .Property(a => a.Balance)
                .HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Transaction>()
                .Property(t => t.Amount)
                .HasColumnType("decimal(18,2)");
        }
    }
}
