using EFCore.DatabaseFirst.DAL;
using Microsoft.EntityFrameworkCore;

DbContextInitializer.Build();

using (var _context = new AppDbContext())
{
    var products = await _context.Products.ToListAsync();

    foreach (var item in products)
    {
        Console.WriteLine($"{item.Id}: {item.Name} {item.Stock} {item.Price}");
    }
}

