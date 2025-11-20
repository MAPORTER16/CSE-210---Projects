using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public List<Product> Products { get => _products; }
    public Customer Customer { get => _customer; set => _customer = value; }

    public void AddProduct(Product product)
    {
        if (product != null)
            _products.Add(product);
    }

    public double TotalPrice()
    {
        double sum = 0.0;
        foreach (var p in _products)
        {
            sum += p.TotalCost();
        }

        double shipping = _customer != null && _customer.IsInUSA() ? 5.0 : 35.0;
        return sum + shipping;
    }

    public string PackingLabel()
    {
        var sb = new StringBuilder();
        foreach (var p in _products)
        {
            sb.AppendLine($"{p.Name} - ID: {p.ProductId}");
        }
        return sb.ToString().TrimEnd();
    }

    public string ShippingLabel()
    {
        if (_customer == null) return string.Empty;
        var sb = new StringBuilder();
        sb.AppendLine(_customer.Name);
        if (_customer.Address != null)
            sb.Append(_customer.Address.ToMultiLineString());
        return sb.ToString().TrimEnd();
    }
}

