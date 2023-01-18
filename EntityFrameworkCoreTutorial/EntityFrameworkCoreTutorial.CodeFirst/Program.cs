
using EntityFrameworkCoreTutorial.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Initializer.Build();

using (var _context = new AppDbContext())
{
    var products = await _context.Products.ToListAsync();

    products.ForEach(p =>
    {
        Console.WriteLine($"Ürün ID: {p.Id} - Ürün Adı:{p.Name} - Ürün Fiyatı:{p.Price} -Ürün Stoğu: {p.Stock}");
    });
}