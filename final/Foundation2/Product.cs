public class Product(string name, string productId, double pricePerUnit, int quantity)
{
    private string _name = name;
    private string _productId = productId;
    private double _pricePerUnit = pricePerUnit;
    private int _quantity = quantity;


    public string GetName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public double GetPricePerUnit()
    {
        return _pricePerUnit;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public double GetTotalPrice()
    {
        double totalPrice = _pricePerUnit * (double)_quantity;
        return totalPrice;
    }
}