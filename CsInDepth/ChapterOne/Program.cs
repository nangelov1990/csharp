// See https://aka.ms/new-console-template for more information
using System.Collections;

List<Product> products = Product.GetSampleProducts();
foreach (Product product in products.OrderBy(p => p.Name))
{
    Console.WriteLine(product);
}