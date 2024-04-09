using System.Net.Http.Headers;

class Order
{
    public List<Product> Products { get; set; }
    public Customer Customer{ get; set; }

    public Order(Customer customer)
    {
        Customer = customer;
        Products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        Products.Add(product);
    }
    public List<string> GetPackingLabel()
    {
        List<string> packingLabel = new();
        foreach (Product product in Products)
        {
            packingLabel.Add($"{product.Name}, {product.Product_Id}");
        }
        return packingLabel;
    }
    public string GetShippingLabel()
    {
        return $"{Customer.Name}\n{Customer.Address.GetFullAddress()}";
    }
    private int CalculateShippingCost()
    {
        //if USA $5, else $35
        if (Customer.IsFromUSA())
        {
            return 5;
        }
        return 35;
    }
    private double CalculateTotalCost(int shippingCost)
    {
        //add up cost of all products and add shipping cost
        double subTotal = 0;
        foreach (Product product in Products)
        {
            subTotal+= product.CalculateSubTotal();
        }
        return subTotal + shippingCost;
    }
    public double GetTotalCost()
    {
        return CalculateTotalCost(CalculateShippingCost());
    }
}