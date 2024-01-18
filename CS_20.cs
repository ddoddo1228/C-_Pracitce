using System;

class CS_20
{
    public int Numerator { get; set; }
    public int Denominator { get; set; }

    public CS_20(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("분모는 0일 수 없습니다.");
        }

        Numerator = numerator;
        Denominator = denominator;
    }

    public static CS_20 operator +(CS_20 fraction1, CS_20 fraction2)
    {
        int newNumerator = (fraction1.Numerator * fraction2.Denominator) + (fraction2.Numerator * fraction1.Denominator);
        int newDenominator = fraction1.Denominator * fraction2.Denominator;
        return new CS_20(newNumerator, newDenominator);
    }

    public static CS_20 operator -(CS_20 fraction1, CS_20 fraction2)
    {
        int newNumerator = (fraction1.Numerator * fraction2.Denominator) - (fraction2.Numerator * fraction1.Denominator);
        int newDenominator = fraction1.Denominator * fraction2.Denominator;
        return new CS_20(newNumerator, newDenominator);
    }

    public static CS_20 operator *(CS_20 fraction1, CS_20 fraction2)
    {
        int newNumerator = fraction1.Numerator * fraction2.Numerator;
        int newDenominator = fraction1.Denominator * fraction2.Denominator;
        return new CS_20(newNumerator, newDenominator);
    }

    public static CS_20 operator /(CS_20 fraction1, CS_20 fraction2)
    {
        if (fraction2.Numerator == 0)
        {
            throw new DivideByZeroException("분모가 0이면 나눌 수 없습니다.");
        }

        int newNumerator = fraction1.Numerator * fraction2.Denominator;
        int newDenominator = fraction1.Denominator * fraction2.Numerator;
        return new CS_20(newNumerator, newDenominator);
    }

    public override string ToString()
    {
        return $"{Numerator}/{Denominator}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        CS_20 fraction1 = new CS_20(1, 2);
        CS_20 fraction2 = new CS_20(3, 4);
        CS_20 sum = fraction1 + fraction2;
        CS_20 difference = fraction1 - fraction2;
        CS_20 product = fraction1 * fraction2;
        CS_20 quotient = fraction1 / fraction2;

        Console.WriteLine($"덧셈: {sum}");
        Console.WriteLine($"뺄셈: {difference}");
        Console.WriteLine($"곱셈: {product}");
        Console.WriteLine($"나눗셈: {quotient}");
    }
}
