public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalPrice()
    {
        double price = CalculateShippingCost();

        _products.ForEach(product => {
            price += product.GetTotalPrice();
        });

        return price;
    }

    public string GetPackingLabel()
    {
        string label = "";

        _products.ForEach(product => {
            label += $"Product: " + product.GetName() + "\n";
            label += $"Id: " + product.GetId() + "\n";
        });

        return label;
    }

    public string GetShippingLabel()
    {
        return $"Customer Name: {_customer.GetName()}\n" +
            $"Address: {_customer.GetFullAddress()}";
    }

    private double CalculateShippingCost()
    {
        if(_customer.IsUsa())
        {
            return 5.0;
        }

        return 35.0;
    }
}