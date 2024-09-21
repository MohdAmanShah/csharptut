using Northwind.EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

partial class Program
{
    private static void QueryingCategories()
    {
        using NorthwindDb db = new NorthwindDb();
        db.ChangeTracker.LazyLoadingEnabled = false;

        SectionTitle("Categories and how many products they have");
        //Iqueryable<category> categories = db.categories?.include(c => c.products);
        IQueryable<Category> categories = db.Categories;
        //IQueryable<Category> categories = db.Categories?.Include(c => c.Products.Where(p => p.Stock >= 51));


        if (categories is null || !categories.Any())
        {
            Heading("No categories found.");
        }

        foreach (Category c in categories)
        {
            Heading($"{c.CategoryName} have {c.Products.Count} products.");
            foreach (Product p in c.Products)
            {
                Message($"    {p.ProductName} has {p.Stock} units in stock.");
            }
        }
    }

    private static void QueryingProducts()
    {
        using NorthwindDb db = new();

        SectionTitle("Products that cost more than a price, highest at top");

        IQueryable<Product>? products = db.Products.TagWith("Products filtered by price and sor").Where(p => p.Cost > 100).OrderByDescending(p => (double)p.Cost);

        Heading("SQL queries ran.");
        Message(products.ToQueryString());

        if (products is null || !products.Any())
        {
            Heading("products not found");
        }

        foreach (Product p in products)
        {
            Heading($"{p.ProductId}:{p.ProductName}");
            Message($"Price: {p.Cost}, Stock: {p.Stock}");
        }
    }
    private static void QueryingSingleProduct()
    {
        using NorthwindDb db = new();
        int id = 12;

        Product? product = db.Products?.First(p => p.ProductId == id);
        //Product? product = db.Products?.Single(p => p.ProductId == id);

        if (product is null)
        {
            Heading($"product with id: {id} not found");
        }

        Heading($"{id}: {product.ProductName}");
        Message($"Price: {product.Cost}, Stock Left: {product.Stock}");
    }

    private static void QuerySingleProductWithLike()
    {
        using NorthwindDb db = new();
        string key = "che";
        int? row = db.Products?.Count();
        //IQueryable<Product> p = db.Products.Where(p => EF.Functions.Like(p.ProductName, $"%{key}%")); 
        IQueryable<Product> p = db.Products.Where(p => p.ProductId == (int)(EF.Functions.Random() * row));
        if (p is null || !p.Any())
        {
            Heading("product not found");
        }
        foreach (Product _p in p)
        {
            Heading($"{_p.ProductName}: {_p.Stock} left.");
        }
    }

    private static void ELoading()
    {
        using NorthwindDb db = new();
        IQueryable<Category> categories;

        db.ChangeTracker.LazyLoadingEnabled = false;

        Write("Enable eager loading? (Y/N): ");
        bool eagerLoading = (ReadKey().Key == ConsoleKey.Y);
        bool explicitLoading = false;
        WriteLine();
        if (eagerLoading)
        {
            categories = db.Categories?.Include(c => c.Products);
        }
        else
        {
            categories = db.Categories;
            Write("Enable explicit loading? (Y/N): ");
            explicitLoading = (ReadKey().Key == ConsoleKey.Y);
            WriteLine();
        }
        if (explicitLoading)
        {
            foreach (Category c in categories)
            {
                Write($"Explicitly load products for {c.CategoryName}? (Y/N): ");
                ConsoleKeyInfo key = ReadKey();
                WriteLine();
                if (key.Key == ConsoleKey.Y)
                {
                    CollectionEntry<Category, Product> products =
                    db.Entry(c).Collection(c2 => c2.Products);
                    if (!products.IsLoaded) products.Load();
                }
            }
        }
    }
    private static void LazyLoadingWithNoTracking()
    {
        using NorthwindDb db = new();
        SectionTitle("Lazy-loading with no tracking");
        IQueryable<Product>? products = db.Products?.AsNoTracking();
        if (products is null || !products.Any())
        {
            Heading("No products found.");
            return;
        }
        foreach (Product p in products)
        {
            WriteLine("{0} is in category named {1}.",
            p.ProductName, p.Category.CategoryName);
        }
    }
}