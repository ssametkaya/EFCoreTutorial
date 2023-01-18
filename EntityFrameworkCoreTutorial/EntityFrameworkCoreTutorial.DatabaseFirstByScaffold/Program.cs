
using EntityFrameworkCoreTutorial.DatabaseFirstByScaffold.Models;
using Microsoft.EntityFrameworkCore;

using (var context = new EFCoreDbFirstContext())
{
    var products = await context.Products.ToListAsync();

    products.ForEach(p =>
    {
        Console.WriteLine($"Ürün ID: {p.Id} - Ürün Adı:{p.Name} - Ürün Fiyatı:{p.Price} - Ürün Stoğu: {p.Stock}");
    });
}
