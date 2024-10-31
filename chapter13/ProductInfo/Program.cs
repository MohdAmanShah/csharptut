
public class Program
{
    public static void Main(string[] args)
    {
        var first = new (string Name, int Age)[] { ("Noa", 23), ("Aman", 24) };
        var second = new (string Name, int Age)[] { ("Noah", 23), ("Amanda", 21) };
        var third = new string[] { "ron", "Don", "Monkey" };
        var fourth = new string[] { "ron", "Don", "Donkey" };
        var result = (from f in fourth select f).Except(from t in third select t);
        foreach (var r in result)
        {
            Console.WriteLine(r);
        }
        // var result2 = first.IntersectBy(second.Select(x => x.Age), p => p.Age);
        var result2 = first.UnionBy(second, p => p.Age);
        foreach (var r in result2)
        {
            Console.WriteLine(r);
        }
        var dd = delegate (int a, int b)
        {
            Console.WriteLine(a + b);
        };
        dd(23, 32);
    }
    public static void Prog()
    {
        ProductInfo[] itemsInStock = new[]
    {
    new ProductInfo{ Name = "Mac's Coffee", Description = "Coffee with Teeth", NumberInStock = 24},
    new ProductInfo{ Name = "Milk Maid Milk", Description = "Milk cow's love",NumberInStock = 100},
    new ProductInfo{ Name = "Pure Silk Tofu", Description = "Bland as Possible",NumberInStock = 120},
    new ProductInfo{ Name = "Crunchy Pops", Description = "Cheezy, peppery goodness",NumberInStock = 2},
    new ProductInfo{ Name = "RipOff Water", Description = "From the tap to your wallet",NumberInStock = 100},
    new ProductInfo{ Name = "Classic Valpo Pizza", Description = "Everyone lovespizza!", NumberInStock = 73}
};
        ProductInfo.SelectEverything(itemsInStock);
        Array result = ProductInfo.GetOverStock(itemsInStock);
        result.SetValue(new { itemsInStock[3].Name, itemsInStock[3].NumberInStock }, 1);
        result.SetValue(new { Name = "Cadbury", NumberInStock = 1 }, 1);
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
        ProductInfo.PagingWithLINQ(itemsInStock);
    }
}
class ProductInfo
{
    public static void SelectEverything(ProductInfo[] items)
    {
        Console.WriteLine("All Product Details");
        var allProducts = from p in items select p.Name;
        foreach (var i in allProducts)
        {
            Console.WriteLine(i);
        }
    }
    public static Array GetOverStock(ProductInfo[] items)
    {
        Console.WriteLine("The overstock items.");
        var overstock = from p in items
                        where p.NumberInStock > 25
                        select new { p.Name, p.NumberInStock };
        return overstock.ToArray();
    }
    public static void PagingWithLINQ(ProductInfo[] products)
    {
        Console.WriteLine("Paging Operations");
        IEnumerable<ProductInfo> list = (from p in products orderby p.NumberInStock select p).TakeWhile(x => x.NumberInStock > 20);
        OutputResults("The first 3", list);

    }
    static void OutputResults(string message, IEnumerable<ProductInfo> products)
    {
        Console.WriteLine(message);
        foreach (var c in products)
        {
            Console.WriteLine(c.ToString());
        }
    }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int NumberInStock { get; set; } = 0;
    public override string ToString()
    {
        return $"Name = {Name}, Description = {Description}, NumberInStocks = {NumberInStock}";
    }
}