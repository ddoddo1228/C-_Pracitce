using System;

public class CS_16
{
    public int numerator;
    public int denominator;

    public CS_16(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("분모는 0이 될 수 없습니다.");
        }
        this.numerator = numerator;
        this.denominator = denominator;
    }

    private static int CalculateGCD(int a, int b)
    {
        if (b == 0)
        {
            return a;
        }
        return CalculateGCD(b, a % b);
    }

    public void Simplify()
    {
        int gcd = CalculateGCD(numerator, denominator);
        numerator /= gcd;
        denominator /= gcd;
    }

    public override string ToString()
    {
        return $"{numerator}/{denominator}";
    }

    public static void Main(string[] args)
    {
        try
        {
            CS_16 fraction = new CS_16(6, 9);
            Console.WriteLine("기존 분수: " + fraction);
            fraction.Simplify();
            Console.WriteLine("기약 분수: " + fraction);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
