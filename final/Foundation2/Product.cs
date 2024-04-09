using System.Reflection.Metadata.Ecma335;

class Product
{
    public string Name { get; set; }
    public int Product_Id { get; set; }
    public double PricePerUnit { get; set; }
    public int Quantity { get; set; }

    public Product( string name, int product_id, double pricePerUnit, int quantity)
    {
        Name = name;
        Product_Id = product_id;
        PricePerUnit = pricePerUnit;
        Quantity = quantity;
    }
    public double CalculateSubTotal()
    {
        return PricePerUnit * Quantity;
    }
}