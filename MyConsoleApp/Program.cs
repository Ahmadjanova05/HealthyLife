// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        List<Product> products = new List<Product>();

        // Mahsulot qo'shish
        products.Add(new Product { Name = "Kitob", Price = 25.50m });
        products.Add(new Product { Name = "Dastur", Price = 100.00m });

        // Mahsulotlarni chiqarish
        foreach (var product in products)
        {
            Console.WriteLine($"{product.Name} - {product.Price}");
        }
    }
}