using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product p)
    {
        _products.Add(p);
    }

    public decimal ShippingCost()
    {
        return _customer.LivesInUSA() ? 5m : 35m;
    }

    public decimal TotalPrice()
    {
        decimal total = 0;
        foreach (var p in _products)
        {
            total += p.TotalCost();
        }
        return total + ShippingCost();
    }

    public string GetPackingLabel()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Packing Label:");
        foreach (var p in _products)
        {
            sb.AppendLine($"{p.GetName()} (ID: {p.GetProductId()})");
        }
        return sb.ToString();
    }

    public string GetShippingLabel()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Shipping Label:");
        sb.AppendLine(_customer.GetName());
        sb.AppendLine(_customer.GetAddress().GetFullAddress());
        return sb.ToString();
    }
}
