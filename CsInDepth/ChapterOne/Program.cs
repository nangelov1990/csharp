// See https://aka.ms/new-console-template for more information
using System.Collections;

List<Product> products = Product.GetSampleProducts();
products.Sort(new ProductNameComparer());
foreach (Product product in products)
{
    Console.WriteLine(product);
}