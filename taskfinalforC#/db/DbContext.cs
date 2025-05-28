using Microsoft.EntityFrameworkCore;
using taskfinalforC_.Models;

namespace taskfinalforC_.db
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"your_connection_string_here");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
             new Category { Id = 1, Name = "Electronics" },
             new Category { Id = 2, Name = "Books" },
             new Category { Id = 3, Name = "Clothing" },
             new Category { Id = 4, Name = "Toys" },
             new Category { Id = 5, Name = "Groceries" },
             new Category { Id = 6, Name = "Furniture" },
             new Category { Id = 7, Name = "Sports" },
             new Category { Id = 8, Name = "Health" },
             new Category { Id = 9, Name = "Beauty" },
             new Category { Id = 10, Name = "Automotive" },
             new Category { Id = 11, Name = "Pet Supplies" },
             new Category { Id = 12, Name = "Garden" },
             new Category { Id = 13, Name = "Music" },
             new Category { Id = 14, Name = "Office Supplies" },
             new Category { Id = 15, Name = "Art" },
             new Category { Id = 16, Name = "Photography" },
             new Category { Id = 17, Name = "Shoes" },
             new Category { Id = 18, Name = "Jewelry" },
             new Category { Id = 19, Name = "Video Games" },
             new Category { Id = 20, Name = "Home Decor" }
         );


            modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Smartphone", Price = 899, CategoryId = 1 },
            new Product { Id = 2, Name = "Laptop", Price = 1500, CategoryId = 1 },
            new Product { Id = 3, Name = "Sci-Fi Novel", Price = 19.99m, CategoryId = 2 },
            new Product { Id = 4, Name = "Children's Book", Price = 12.50m, CategoryId = 2 },
            new Product { Id = 5, Name = "T-Shirt", Price = 25, CategoryId = 3 },
            new Product { Id = 6, Name = "Jacket", Price = 60, CategoryId = 3 },
            new Product { Id = 7, Name = "Lego Set", Price = 45, CategoryId = 4 },
            new Product { Id = 8, Name = "Board Game", Price = 35, CategoryId = 4 },
            new Product { Id = 9, Name = "Milk", Price = 3, CategoryId = 5 },
            new Product { Id = 10, Name = "Eggs", Price = 2.50m, CategoryId = 5 },
            new Product { Id = 11, Name = "Chair", Price = 80, CategoryId = 6 },
            new Product { Id = 12, Name = "Desk", Price = 150, CategoryId = 6 },
            new Product { Id = 13, Name = "Football", Price = 20, CategoryId = 7 },
            new Product { Id = 14, Name = "Tennis Racket", Price = 75, CategoryId = 7 },
            new Product { Id = 15, Name = "Vitamin C", Price = 10, CategoryId = 8 },
            new Product { Id = 16, Name = "Shampoo", Price = 8.99m, CategoryId = 9 },
            new Product { Id = 17, Name = "Car Oil", Price = 25.99m, CategoryId = 10 },
            new Product { Id = 18, Name = "Dog Food", Price = 40, CategoryId = 11 },
            new Product { Id = 19, Name = "Guitar", Price = 300, CategoryId = 13 },
            new Product { Id = 20, Name = "Wall Clock", Price = 50, CategoryId = 20 }
        );


            modelBuilder.Entity<Order>().HasData(
            new Order { Id = 1, CustomerName = "Nino Beridze", OrderDate = new DateTime(2024, 4, 15), ProductId = 1, Quantity = 1 },
            new Order { Id = 2, CustomerName = "Giorgi Mikeladze", OrderDate = new DateTime(2024, 4, 28), ProductId = 3, Quantity = 2 },
            new Order { Id = 3, CustomerName = "Lasha Kapanadze", OrderDate = new DateTime(2024, 5, 10), ProductId = 5, Quantity = 3 },
            new Order { Id = 4, CustomerName = "Salome Gagnidze", OrderDate = new DateTime(2024, 6, 5), ProductId = 9, Quantity = 10 },
            new Order { Id = 5, CustomerName = "Ana Chikhladze", OrderDate = new DateTime(2024, 6, 15), ProductId = 11, Quantity = 1 },
            new Order { Id = 6, CustomerName = "Nikoloz Tsertsvadze", OrderDate = new DateTime(2024, 7, 3), ProductId = 2, Quantity = 1 },
            new Order { Id = 7, CustomerName = "Lizi Tabidze", OrderDate = new DateTime(2024, 7, 20), ProductId = 8, Quantity = 4 },
            new Order { Id = 8, CustomerName = "Mariam Shengelia", OrderDate = new DateTime(2024, 8, 2), ProductId = 12, Quantity = 1 },
            new Order { Id = 9, CustomerName = "Dato Mchedlishvili", OrderDate = new DateTime(2024, 8, 15), ProductId = 7, Quantity = 1 },
            new Order { Id = 10, CustomerName = "Eka Kapanadze", OrderDate = new DateTime(2024, 9, 9), ProductId = 10, Quantity = 6 },

            new Order { Id = 11, CustomerName = "Gela Chanturia", OrderDate = new DateTime(2024, 10, 12), ProductId = 6, Quantity = 2 },
            new Order { Id = 12, CustomerName = "Tatia Kvantaliani", OrderDate = new DateTime(2024, 10, 25), ProductId = 4, Quantity = 1 },
            new Order { Id = 13, CustomerName = "Beka Tsikarishvili", OrderDate = new DateTime(2024, 11, 8), ProductId = 13, Quantity = 5 },
            new Order { Id = 14, CustomerName = "Elene Akhvlediani", OrderDate = new DateTime(2024, 12, 1), ProductId = 14, Quantity = 2 },
            new Order { Id = 15, CustomerName = "Irakli Gelashvili", OrderDate = new DateTime(2025, 1, 10), ProductId = 15, Quantity = 3 },
            new Order { Id = 16, CustomerName = "Lali Papashvili", OrderDate = new DateTime(2025, 2, 5), ProductId = 16, Quantity = 2 },
            new Order { Id = 17, CustomerName = "Zaza Giorgadze", OrderDate = new DateTime(2025, 3, 20), ProductId = 17, Quantity = 1 },
            new Order { Id = 18, CustomerName = "Maia Metreveli", OrderDate = new DateTime(2025, 4, 14), ProductId = 18, Quantity = 2 },
            new Order { Id = 19, CustomerName = "Tamar Kukava", OrderDate = new DateTime(2025, 5, 1), ProductId = 19, Quantity = 1 },
            new Order { Id = 20, CustomerName = "Natia Lomtatidze", OrderDate = new DateTime(2025, 5, 25), ProductId = 20, Quantity = 1 }
        );

        }
    }
}
