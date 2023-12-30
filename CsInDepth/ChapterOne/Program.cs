// See https://aka.ms/new-console-template for more information
using System.Collections;

List<Product> products = Product.GetSampleProducts();
products.FindAll(delegate(Product p) { return p.Price > 10m; })
        .ForEach(Console.WriteLine);