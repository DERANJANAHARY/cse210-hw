public class Product
{
    private string _name;
    private string _productId;
    private decimal _pricePerUnit;
    private int _quantity;

    public Product(string name, string productId, decimal pricePerUnit, int quantity)
    {
        _name = name;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public string GetName() => _name;
    public string GetProductId() => _productId;
    public decimal GetPricePerUnit() => _pricePerUnit;
    public int GetQuantity() => _quantity;

    public void SetName(string value) => _name = value;
    public void SetProductId(string value) => _productId = value;
    public void SetPricePerUnit(decimal value) => _pricePerUnit = value;
    public void SetQuantity(int value) => _quantity = value;

    public decimal TotalCost()
    {
        return _pricePerUnit * _quantity;
    }
}
