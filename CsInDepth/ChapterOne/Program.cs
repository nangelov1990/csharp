// See https://aka.ms/new-console-template for more information
using System.Collections;

List<Product> list = Product.GetSampleProducts();
foreach (Product product in list)
{
    Console.WriteLine(product);
}