using Northwind.EntityModels; // To use NorthwindDb, Category, Product
using Microsoft.EntityFrameworkCore;
using System.Xml; //To use DbSet<T>

partial class Program
{
    private static void FilterAndSort()
    {
        SectionTitle("Filter and Sort");

        using NorthwindDb db = new();

        DbSet<Product> products = db.Products;
        IQueryable<Product> filteredProducts = products.Where(P => P.UnitPrice < 10M);
        IQueryable<Product> filteredAndSortedProducts = filteredProducts.OrderByDescending(P => P.UnitPrice);
        var projectedProducts = filteredAndSortedProducts.Select(product => new
        {
            product.ProductId,
            product.ProductName,
            product.UnitPrice
        });

        WriteLine("Products that cost less than $10.");
        WriteLine(projectedProducts.ToQueryString());

        foreach (var p in projectedProducts)
        {
            WriteLine($"{p.ProductId}: {p.ProductName} costs {p.UnitPrice:$#,##0.00}");
        }
        WriteLine();
    }

    private static void JoinCategoriesAndProducts()
    {
        SectionTitle("Join categories and products.");
        using NorthwindDb db = new();

        var queryJoin = db.Categories.Join(
                inner: db.Products,
                outerKeySelector: c => c.CategoryId,
                innerKeySelector: p => p.CategoryId,
                resultSelector: (c, p) => new { c.CategoryName, p.ProductName, p.ProductId }
            ).OrderBy(c => c.CategoryName);

        WriteLine(queryJoin.ToQueryString());
        foreach (var j in queryJoin)
        {
            WriteLine($"{j.ProductId}: {j.ProductName} in {j.CategoryName}");
        }
    }

    private static void GroupJoinCategoriesAndProducts()
    {
        using NorthwindDb db = new();

        var queryGroupJoin = db.Categories.AsEnumerable().GroupJoin(inner: db.Products, outerKeySelector: c => c.CategoryId,
            innerKeySelector: p => p.CategoryId, resultSelector: (c, p) => new
            {
                c.CategoryName,
                Products = p.OrderBy(pp => pp.ProductName)
            });
        foreach (var c in queryGroupJoin)
        {
            WriteLine($"{c.CategoryName} has {c.Products.Count()} products.");
            foreach (var p in c.Products)
            {
                WriteLine($"    {p.ProductName}");
            }
        }
    }

    private static void ProductsLookup()
    {
        SectionTitle("Product lookup");

        using NorthwindDb db = new();

        var productQuery = db.Categories.Join(inner: db.Products, outerKeySelector: c => c.CategoryId, innerKeySelector: p => p.CategoryId,
            resultSelector: (c, p) => new { c.CategoryName, Product = p });
        ILookup<string, Product> productLookup = productQuery.ToLookup(
            keySelector: cp => cp.CategoryName,
            elementSelector: cp => cp.Product);

        ForegroundColor = ConsoleColor.Green;
        WriteLine(productQuery.ToQueryString());
        foreach (IGrouping<string, Product> group in productLookup)
        {
            ForegroundColor = ConsoleColor.Red;
            WriteLine($"{group.Key} has {group.Count()} products.");
            ForegroundColor = ConsoleColor.White;

            foreach (var p in group)
            {
                WriteLine($"{p.ProductName}");
            }
        }

        WriteLine("Enter category name.: ");
        string categoryName = ReadLine();
        WriteLine();
        WriteLine($"Products in {categoryName}.");

        IEnumerable<Product> productsInCategory = productLookup[categoryName];

        foreach (Product product in productsInCategory)
        {
            WriteLine($"    {product.ProductName}");
        }
    }

    private static void AggregateProducts()
    {
        SectionTitle("Aggregate products");
        using NorthwindDb db = new();
        // Try to get an efficient count from EF Core DbSet<T>.
        if (db.Products.TryGetNonEnumeratedCount(out int countDbSet))
        {
            WriteLine($"{"Product count from DbSet:",-25} {countDbSet,10}");
        }
        else
        {
            WriteLine("Products DbSet does not have a Count property.");
        }
        // Try to get an efficient count from a List<T>.
        List<Product> products = db.Products.ToList();
        if (products.TryGetNonEnumeratedCount(out int countList))
        {
            WriteLine($"{"Product count from list:",-25} {countList,10}");
        }
        else
        {
            WriteLine("Products list does not have a Count property.");
        }
        WriteLine($"{"Product count:",-25} {db.Products.Count(),10}");
        WriteLine($"{"Discontinued product count:",-27} {db.Products
        .Count(product => product.Discontinued),8}");
        WriteLine($"{"Highest product price:",-25} {db.Products.Max(p => p.UnitPrice),10:$#,##0.00}");
        WriteLine($"{"Sum of units in stock:",-25} {db.Products
        .Sum(p => p.UnitsInStock),10:N0}");
        WriteLine($"{"Sum of units on order:",-25} {db.Products
        .Sum(p => p.UnitsOnOrder),10:N0}");
        WriteLine($"{"Average unit price:",-25} {db.Products
        .Average(p => p.UnitPrice),10:$#,##0.00}");
        WriteLine($"{"Value of units in stock:",-25} {db.Products
        .Sum(p => p.UnitPrice * p.UnitsInStock),10:$#,##0.00}");
    }

    private static void OutputTableOfProducts(Product[] products,
 int currentPage, int totalPages)
    {
        string line = new('-', count: 73);
        string lineHalf = new('-', count: 30);
        WriteLine(line);
        WriteLine("{0,4} {1,-40} {2,12} {3,-15}",
        "ID", "Product Name", "Unit Price", "Discontinued");
        WriteLine(line);
        foreach (Product p in products)
        {
            WriteLine("{0,4} {1,-40} {2,12:C} {3,-15}",
            p.ProductId, p.ProductName, p.UnitPrice, p.Discontinued);
        }
        WriteLine("{0} Page {1} of {2} {3}",
        lineHalf, currentPage + 1, totalPages + 1, lineHalf);
    }

    private static void OutputPageOfProducts(IQueryable<Product> products, int pageSize, int currentPage, int totalPages)
    {
        var pagingQuery = products.OrderBy(p => p.ProductId)
            .Skip(currentPage * pageSize)
            .Take(pageSize);
        Clear();
        Message(pagingQuery.ToQueryString(), ConsoleColor.Green);
        OutputTableOfProducts(pagingQuery.ToArray(), currentPage, totalPages);
    }

    private static void PagingProducts()
    {
        using NorthwindDb db = new();

        int pageSize = 10;
        int currentPage = 0;
        int productCount = db.Products.Count();
        int totalPages = productCount / pageSize;

        while (true)
        {
            OutputPageOfProducts(db.Products, pageSize, currentPage, totalPages);
            Write("Press <- to page back, press -> to page next, press any other to exit.");
            ConsoleKey key = ReadKey().Key;
            if (key == ConsoleKey.LeftArrow)
            {
                currentPage = currentPage == 0 ? 0 : currentPage - 1;
            }
            else if (key == ConsoleKey.RightArrow)
            {
                currentPage = currentPage == totalPages ? 0 : currentPage + 1;
            }
            else break;
            WriteLine();
        }
    }
}