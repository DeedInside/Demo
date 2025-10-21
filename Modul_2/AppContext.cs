using Modul_2.Models;

namespace Modul_2
{
    public static class AppContext
    {
        public static List<Product> Products { get; set; } = new()
        {
            new Product() {
                Id = 0, 
                Description = "Полуботинки Alessio Nesca женские 3-30797-47, размер 37, цвет: бордовый",
                Discount = 20,
                Price = 1000,
                Count = 12,
            },
            new Product() {Id = 1},
            new Product() {Id = 2,Count = 2, Discount = 16, Price = 1200},
            new Product() {Id = 3},
        };
    }
}
