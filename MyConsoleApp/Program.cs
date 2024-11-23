// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Color { get; set; }
    public string Description { get; set; }
 
}

public class Program
{
    public static void Main(string[] args)
    {
        List<Product> products = new List<Product>();

        // Mahsulot qo'shish
        products.Add(new Product { Name = "Kitob", Price = 25.50m ,Color= "pink",Description="good"});
        products.Add(new Product { Name = "Dastur", Price = 100.00m ,Color="Black",Description="not good"});

        // Mahsulotlarni chiqarish
        foreach (var product in products)
        {
            Console.WriteLine($"{product.Name} - {product.Price},{product.Color},{product.Description}");
        }
    }
}