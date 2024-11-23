// See https://aka.ms/new-console-template for more information
foreach (var product in products)
{
    if (product != null && !string.IsNullOrEmpty(product.Name))
    {
        Console.WriteLine($"{product.Name} - {product.Price}");
    }
    else
    {
        Console.WriteLine("neznayu.");
    }
}
