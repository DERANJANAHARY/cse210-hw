using System;
using System.Text;

public class Address
{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string street, string city, string stateOrProvince, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public bool IsInUSA()
    {
        return _country.ToUpper() == "USA";
    }

    public string GetFullAddress()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(_street);
        sb.AppendLine($"{_city}, {_stateOrProvince}");
        sb.Append(_country);
        return sb.ToString();
    }
}
