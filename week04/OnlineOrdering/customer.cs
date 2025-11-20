using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string Name { get => _name; set => _name = value; }
    public Address Address { get => _address; set => _address = value; }

    public bool IsInUSA()
    {
        if (_address == null) return false;
        return _address.IsInUSA();
    }
}

