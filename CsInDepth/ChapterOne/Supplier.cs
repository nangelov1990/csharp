public class Supplier
{
    readonly string name;
    public string Name { get { return name; } }

    readonly int supplierId;
    public int SupplierID { get { return supplierId; } }

    public Supplier(string name, int supplierId)
    {
        this.name = name;
        this.supplierId = supplierId;
    }

    public static List<Supplier> GetSampleSuppliers()
    {
        return new List<Supplier>
        {
            new Supplier(name: "Game Boys Supplies", supplierId: 123),
            new Supplier(name: "Supplies by Deni", supplierId: 234),
            new Supplier(name: "Goodie Supplies", supplierId: 345)
        };
    }
}