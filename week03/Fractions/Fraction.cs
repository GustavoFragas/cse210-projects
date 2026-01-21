using System;

public class Fraction
{
    private int _topNumber;
    private int _bottomNumber;

    public Fraction()
    {
        _topNumber = 1;
        _bottomNumber = 1;
    }

    public Fraction(int topNumber)
    {
        _topNumber = topNumber;
        _bottomNumber = 1;
    }

    public Fraction(int topNumber, int bottomNumber)
    {
        _topNumber = topNumber;
        _bottomNumber = bottomNumber;
    }

    public void GetFractionString()
    {
        Console.WriteLine($"{_topNumber}/{_bottomNumber}");
    }

    public int GetTopNumber()
    {
        return _topNumber;
    }

    public int GetBottomNumber()
    {
        return _bottomNumber;
    }

    public void SetTopNumber(int topNumber)
    {
        _topNumber = topNumber;
    }

    public void SetBottomNumber(int bottomNumber)
    {
        _bottomNumber = bottomNumber;
    }

    public void GetDecimalValue()
    {
        double result = (double)_topNumber / _bottomNumber;
        Console.WriteLine($"The result is {result:f2}");
    }
}
