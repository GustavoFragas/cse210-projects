public class Adress
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Adress(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool ValidateCountry(string country)
    {
        return _country.ToLower() == country.ToLower();
    }

    public string GetDisplayText()
    {
        return $"{_street}, {_city}, {_state}, {_country}";
    }
}