using EfCore.DatabaseFirstByScaffold.Models;
using Microsoft.EntityFrameworkCore;

using (var context = new EfCoreDbContext())
{
    var products = await context.Products.ToListAsync();

    foreach (var item in products)
    {
        Console.WriteLine($"{item.Id}: {item.Name} {item.Stock} {item.Price}");
    }
}