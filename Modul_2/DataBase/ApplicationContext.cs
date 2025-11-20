using Microsoft.EntityFrameworkCore;
using Modul_2.Models;
using Modul_2.Models.Users;
using System.Windows.Controls;

namespace Modul_2.DataBase
{
    public class ApplicationContext: DbContext
    {
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Manufacturer> Manufacturer { get; set; }
        public DbSet<NameProduct> NameProduct { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<PickPoint> PickPoints { get; set; }
        public DbSet<StatusOrder> StatusOrders { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<UnitProduct> UnitProducts { get; set; }
        public DbSet<СategoryProduct> СategoryProduct { get; set; }
        public DbSet<Product> Products { get; set; }
        public ApplicationContext() 
        {
            //Database.EnsureDeleted();
            if (Database.EnsureCreated())
            {
            }
            Roles.Load();
            Users.Load();
            Manufacturer.Load();
            NameProduct.Load();
            Order.Load();
            PickPoints.Load();
            StatusOrders.Load();
            Suppliers.Load();
            UnitProducts.Load();
            СategoryProduct.Load();
            Products.Load();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<Role> roles = new()
            {
                new Role() {Id = 1, Name = "Пользователь" },
                new Role() {Id = 2, Name = "Администратор" },
                new Role() {Id = 3, Name = "Менеджер" }
            };
            
            modelBuilder.Entity<Role>().HasData(roles);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ShopBase;Trusted_Connection=True;");
        }
    }
}
