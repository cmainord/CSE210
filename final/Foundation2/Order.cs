public class Order(Customer customer, List<Product> products)
{
    private Customer _customer = customer;
    private List<Product> _products = products;

    public double GetTotalPrice()
    {
        double totalPrice = 0;

        foreach (Product product in _products)
        {
            totalPrice += product.GetTotalPrice();
        }

        if(_customer.IsInUnitedStates())
        {
            totalPrice += 35;
        }
        else
        {
            totalPrice += 5;
        }

        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string label = "";
        int i = 0;
        foreach(Product product in _products)
        {
            label += $"{product.GetProductId()}: {product.GetName()}";
            if(i < _products.Count)
            {
                label += "\n";
            }
        }
        return label;
    }

    public string GetShippingLabel()
    {
        string label = $"{_customer.GetName()}\n{_customer.GetAddress()}\n";
        return label;
    }

    
}