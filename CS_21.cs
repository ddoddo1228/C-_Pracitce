using System;

public class CS_21
{
    public int Numerator { get; set; }
    public int Denominator { get; set; }

    public CS_21(int numerator, int denominator)
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
        CS_21 myFraction = new CS_21(3, 4);
        string fractionString = myFraction.ToString();
        Console.WriteLine($"분수: {fractionString}");
    }
}
