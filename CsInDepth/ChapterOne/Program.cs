// See https://aka.ms/new-console-template for more information
using System.Collections;

List<Product> products = Product.GetSampleProducts();
products.Sort(delegate (Product x, Product y)
    { return x.Name.CompareTo(y.Name); }
);
foreach (Product product in products)
{
    Console.WriteLine(product);
}