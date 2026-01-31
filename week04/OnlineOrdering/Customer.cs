public class Customer
{
    private string _name;
    private Adress _adress;

    public Customer(string name, Adress adress)
    {
        _name = name;
        _adress = adress;
    }

    public string GetCustomerInfo()
    {
        return $"{_name}\n{_adress.GetDisplayText()}";
    }

    public string GetAdress()
    {
        return _adress.GetDisplayText().Split(',').Last().Trim();
    }

    public string GetName()
    {
        return _name;
    }

}