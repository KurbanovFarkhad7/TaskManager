using Microsoft.EntityFrameworkCore;

namespace GetStartedWinForms;

public class ProductsContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=products.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category { CategoryId = 1, Name = "Учеба" },
            new Category { CategoryId = 2, Name = "Спорт" },
            new Category { CategoryId = 3, Name = "Игры" },
            new Category { CategoryId = 4, Name = "Майнкрафт?" });

        modelBuilder.Entity<Product>().HasData(
            new Product { ProductId = 1, CategoryId = 1, Name = "Поесть" },
            new Product { ProductId = 2, CategoryId = 1, Name = "Поспать" },
            new Product { ProductId = 3, CategoryId = 1, Name = "Решить уроки" },
            new Product { ProductId = 4, CategoryId = 1, Name = "Решить домашку" },
            new Product { ProductId = 5, CategoryId = 1, Name = "Домашка не решена?!" },
            new Product { ProductId = 6, CategoryId = 1, Name = "Проверка" },
            new Product { ProductId = 7, CategoryId = 1, Name = "Томас" },
            new Product { ProductId = 8, CategoryId = 1, Name = "Шелби" },
            new Product { ProductId = 9, CategoryId = 1, Name = "Гуляет" },
            new Product { ProductId = 10, CategoryId = 1, Name = "По Лондону" },
            new Product { ProductId = 11, CategoryId = 2, Name = "И такой типа" },
            new Product { ProductId = 12, CategoryId = 2, Name = "крутой" },
            new Product { ProductId = 13, CategoryId = 2, Name = "с сигаретой еще" },
            new Product { ProductId = 14, CategoryId = 2, Name = "ну ваще имба" },
            new Product { ProductId = 15, CategoryId = 2, Name = "Deal1" },
            new Product { ProductId = 16, CategoryId = 2, Name = "Deal2" },
            new Product { ProductId = 17, CategoryId = 2, Name = "Deal3" },
            new Product { ProductId = 18, CategoryId = 2, Name = "Deal4" },
            new Product { ProductId = 19, CategoryId = 2, Name = "Deal5" },
            new Product { ProductId = 20, CategoryId = 2, Name = "Deal6" },
            new Product { ProductId = 21, CategoryId = 3, Name = "Deal7" },
            new Product { ProductId = 22, CategoryId = 3, Name = "Deal8" },
            new Product { ProductId = 23, CategoryId = 3, Name = "Deal9" },
            new Product { ProductId = 24, CategoryId = 4, Name = "Deal10" },
            new Product { ProductId = 25, CategoryId = 4, Name = "Deal11" },
            new Product { ProductId = 26, CategoryId = 4, Name = "Deal12" },
            new Product { ProductId = 27, CategoryId = 4, Name = "Deal13" },
            new Product { ProductId = 28, CategoryId = 4, Name = "Deal14" },
            new Product { ProductId = 29, CategoryId = 4, Name = "Deal15" },
            new Product { ProductId = 30, CategoryId = 4, Name = "Deal16" },
            new Product { ProductId = 31, CategoryId = 4, Name = "Deal17" },
            new Product { ProductId = 32, CategoryId = 4, Name = "Deal18" },
            new Product { ProductId = 33, CategoryId = 4, Name = "Deal19" });
    }
}