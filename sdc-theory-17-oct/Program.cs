string[] names =
    { "Tom", "Harry", "Mary", "Jay" };


IList<Product> products = new List<Product>
{
    new Product { ProductId = 1,
        ProductName = "Laptop",
        Price = 999.99m,
        Stock = 10,
        Category = "Electronics" },
    new Product { ProductId = 2,
        ProductName = "Smartphone",
        Price = 699.99m,
        Stock = 25,
        Category = "Electronics" },
    new Product { ProductId = 3,
        ProductName = "Desk Chair",
        Price = 89.99m,
        Stock = 15,
        Category = "Furniture" },
    new Product { ProductId = 4,
        ProductName = "Bookcase",
        Price = 129.99m, Stock = 5,
        Category = "Furniture" },
    new Product { ProductId = 5,
        ProductName = "Headphones",
        Price = 199.99m, Stock = 30,
        Category = "Electronics" }
};

var query =
    products
    .Where(p => p.Price > 100).Select(p => new { p.ProductName, p.Price, p.Category });

foreach (var item in query)
{
    Console.WriteLine($"Product: {item.ProductName} " + $"Price: {item.Price} " + $"Category: {item.Category} ");
}

var inStockQuery = products
    .Select(p => new { 
        p.ProductName,
        p.Price,
        p.Category, 
        InStock = p.Stock > 20 ? "Yes" : "No" 
    });

foreach(var item in inStockQuery)
{
    Console.WriteLine($"Product: {item.ProductName}, " +
        $"Price: {item.Price}, " +
        $"Category: {item.Category}, " +
        $"In Stock: {item.InStock}");
}

Console.WriteLine("\n\n --- ORDERED PRODUCTS ----");
var orderedQuery = products
    .OrderBy(p => p.Category)
    .ThenByDescending(p => p.Price)
    .Select(p => new { p.ProductName, p.Price, p.Category });

foreach (var item in orderedQuery)
{
    Console.WriteLine($"Product: {item.ProductName}, " +
        $"Price: {item.Price}, " +
        $"Category: {item.Category}, ");
}

var electronicsCount = products
    .Count(p => p.Category == "Electronics");

Console.WriteLine($"\n\nTotal Electronics Products: {electronicsCount}");

decimal avgPrice = products.Average(p => p.Price);
decimal maxPrice = products.Max(p => p.Price);
decimal minPrice = products.Min(p => p.Price);

Console.WriteLine($"\n Average Price: {avgPrice}"); 
Console.WriteLine($"\n Max Price: {maxPrice}"); 
Console.WriteLine($"\n Min Price: {minPrice}");

var firstElement = products.OrderByDescending(p => p.Price)
    .First();

Console.WriteLine($"\nProduct with Highest Price: {firstElement.ProductName}, Price: {firstElement.ProductName}");

var firstElementDefault = products
    .Where(p =>  p.Category == "Toys")
    .OrderByDescending(p => p.Price)
    .FirstOrDefault();

Console.WriteLine($"{firstElementDefault}");
Console.WriteLine($"\n First or Default Product in Toys Category: " +
    $"{(firstElementDefault == null ? "No Products Found" : firstElementDefault.ProductName)}");


public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public string Category { get; set; }
}