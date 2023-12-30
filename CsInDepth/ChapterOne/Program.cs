﻿// See https://aka.ms/new-console-template for more information
using System.Collections;

List<Product> products = Product.GetSampleProducts();
foreach (Product product in products.Where(p => p.Price > 10))
{
    Console.WriteLine(product);
}