using Modul_2.Models;

namespace Modul_2
{
    public static class AppContext
    {
        public static List<Role> Roles = new()
        {
            new Role(){ Id = 1, Name = "Пользователь"},
            new Role(){ Id = 2, Name = "Менеджер"},
            new Role(){ Id = 3, Name = "Админ"},
        };
        public static List<User> Users = new()
        {
            new User()
            {
                Id = 1,
                Name = "1",
                Login = "1",
                Password = "1",
                Role = Roles.FirstOrDefault(q => q.Name == "Пользователь") ?? Roles[0]
            },
            new User()
            {
                Id = 2,
                Name = "2",
                Login = "2",
                Password = "2",
                Role = Roles.FirstOrDefault(q => q.Name == "Менеджер") ?? Roles[0]
            },
            new User()
            {
                Id = 3,
                Name = "3",
                Login = "3",
                Password = "3",
                Role = Roles.FirstOrDefault(q => q.Name == "Админ") ?? Roles[0]
            },
        };
        public static List<Product> Products { get; set; } = new()
        {
            new Product() {
                Id = 0, 
                Name = "Крыте и не забываемые",
                Сategory = "Туфли",
                Description = "Полуботинки Alessio Nesca женские 3-30797-47, размер 37, цвет: бордовый",
                Discount = 20,
                Price = 1000,
                Count = 12,
            },
            new Product() {Id = 1, Count = 2, Discount = 16, Price = 1200},
            new Product() {Id = 2, Count = 2, Discount = 16, Price = 1200},
            new Product() {Id = 3, Count = 2, Discount = 16, Price = 1200},
        };
    }
}
