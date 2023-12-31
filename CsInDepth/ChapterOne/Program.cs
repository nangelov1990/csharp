// See https://aka.ms/new-console-template for more information
using System.Collections;

List<Product> products = Product.GetSampleProducts();
List<Supplier> suppliers = Supplier.GetSampleSuppliers();
var filtered = from Product p in products
               join s in suppliers
                   on p.SupplierID equals s.SupplierID
               where p.Price > 10
               orderby s.Name, p.Name
               select new
               {
                   SupplierName = s.Name,
                   ProductName = p.Name,
                   ProductPrice = p.Price
               };
foreach (var v in filtered)
{
    Console.WriteLine("Supplier: {0}; Product: {1}, {2}",
                      v.SupplierName, v.ProductName, v.ProductPrice);
}