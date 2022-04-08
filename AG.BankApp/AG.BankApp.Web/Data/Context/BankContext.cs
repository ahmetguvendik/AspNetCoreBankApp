using AG.BankApp.Web.Data.Configurations;
using AG.BankApp.Web.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace AG.BankApp.Web.Data.Context
{
    public class BankContext :DbContext
    {
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public BankContext(DbContextOptions<BankContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AccountConfigurations());
            modelBuilder.ApplyConfiguration(new ApplicationUserConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
