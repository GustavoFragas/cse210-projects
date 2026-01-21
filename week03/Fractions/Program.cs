using System;

class Program
{
    static void Main(string[] args)
    {
        //primeiro construtor
        Fraction f = new();
        f.GetFractionString();
        f.GetDecimalValue();
        //segundo construtor
        Fraction f2 = new(6);
        f2.GetFractionString();
        f2.GetDecimalValue();

        Fraction f3 = new(6, 7);
        f3.GetFractionString();
        f3.GetDecimalValue();
        // int top = f3.GetTopNumber();
        // int bottom = f3.GetBottomNumber();
        // f3.SetTopNumber(8);
        // f3.SetBottomNumber(9);
        // f3.GetFractionString();
        // Console.WriteLine($"Top number: {top}, Bottom number: {bottom}");




    }
}
