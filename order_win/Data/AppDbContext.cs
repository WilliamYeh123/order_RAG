using Microsoft.EntityFrameworkCore;
using order_win.Models;

namespace order_win.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }
        public AppDbContext() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {   //DESKTOP-7VJ993H
                optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=OrderSystem_WinFormDb;Trusted_Connection=True;");
                //optionsBuilder.UseSqlServer(@"Server=DESKTOP-7VJ993H;Database=OrderSystem_WinFormDb;Trusted_Connection=True;");
            }
        }

        public DbSet<order_win.Models.Customer> Customers { get; set; }
        public DbSet<order_win.Models.Product> Products { get; set; }
        public DbSet<order_win.Models.Category> Categories { get; set; }
        public DbSet<order_win.Models.Order> Orders { get; set; }
        public DbSet<order_win.Models.OrderProduct> OrderProducts { get; set; }
    }
}
