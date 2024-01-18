using System;

public class CS_23
{
    public int Numerator { get; set; }
    public int Denominator { get; set; }

    public CS_23(int numerator, int denominator)
    {
        Numerator = numerator;
        Denominator = denominator;
    }

    public override string ToString()
    {
        return $"{Numerator}/{Denominator}";
    }

    public static void Main(string[] args)
    {
        CS_23 myFraction = new CS_23(3, 4);
        string fractionString = myFraction.ToString();
        Console.WriteLine($"분수: {fractionString}");

        CS_23 anotherFraction = new CS_23(1, 2);
        string anotherFractionString = anotherFraction.ToString();
        Console.WriteLine($"다른 분수: {anotherFractionString}");
    }
}
