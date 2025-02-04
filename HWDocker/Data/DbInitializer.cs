using HWDocker.Models;

namespace HWDocker.Data;

public static class DbInitializer
{
    public static void Initialize(AppDbContext context)
    {
        if (context.MenuItems.Any()) return; 

        var menuItems = new List<MenuItem>
        {
            new() { Name = "Burger", Price = 5.99m },
            new() { Name = "Pizza", Price = 8.99m },
            new() { Name = "Salad", Price = 4.49m }
        };

        context.MenuItems.AddRange(menuItems);
        context.SaveChanges();
    }
}
