using System.Collections;

public class Product
{
    readonly string name;
    public string Name { get { return name; } }

    readonly int supplierId;
    public int SupplierID { get { return supplierId; } }

    readonly decimal? price;
    public decimal? Price { get { return price; } }
    
    public Product(string name, int supplierId, decimal? price = null)
    {
        this.name = name;
        this.supplierId = supplierId;
        this.price = price;
    }

    public static List<Product> GetSampleProducts()
    {
        return new List<Product>
        {
            new Product(name: "West Side Story", supplierId: 123, price: 9.99m),
            new Product(name: "Assassins", supplierId: 123, price: 14.99m),
            new Product(name: "Frogs", supplierId: 234, price: 13.99m),
            new Product(name: "Sweeney Todd",supplierId: 345, price: 10.99m),
            new Product(name: "Not Released", supplierId: 234)
        };
    }

    public override string ToString()
    {
        return string.Format("{0}: {1}", name, price);
    }
}