using System;

public class Fraction
{
    public int Numerator { get; set; }
    public int Denominator { get; set; }

    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("분모는 0이 될 수 없습니다.");
        }

        Numerator = numerator;
        Denominator = denominator;
        Simplify();
    }

    public Fraction AddFraction(Fraction other)
    {
        int commonDenominator = Denominator * other.Denominator;
        int commonNumerator = Numerator * other.Denominator + other.Numerator * Denominator;
        return new Fraction(commonNumerator, commonDenominator);
    }

    public Fraction SubFraction(Fraction other)
    {
        int commonDenominator = Denominator * other.Denominator;
        int commonNumerator = Numerator * other.Denominator - other.Numerator * Denominator;
        return new Fraction(commonNumerator, commonDenominator);
    }

    public Fraction MulFraction(Fraction other)
    {
        int commonDenominator = Denominator * other.Denominator;
        int commonNumerator = Numerator * other.Numerator;
        return new Fraction(commonNumerator, commonDenominator);
    }

    public Fraction DivFraction(Fraction other)
    {
        if (other.Numerator == 0)
        {
            throw new ArgumentException("0으로 나눌 수 없습니다.");
        }

        int newNumerator = Numerator * other.Denominator;
        int newDenominator = Denominator * other.Numerator;
        return new Fraction(newNumerator, newDenominator);
    }

    private void Simplify()
    {
        int gcd = GCD(Numerator, Denominator);
        Numerator /= gcd;
        Denominator /= gcd;
    }

    private int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        return a;
    }

    public override string ToString()
    {
        return $"{Numerator}/{Denominator}";
    }
}

public class CS_17
{
    public static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction(1, 2);
        Fraction fraction2 = new Fraction(3, 4);

        // 덧셈
        Fraction sum = fraction1.AddFraction(fraction2);
        Console.WriteLine($"덧셈 결과: {sum}");

        // 뺄셈
        Fraction difference = fraction1.SubFraction(fraction2);
        Console.WriteLine($"뺄셈 결과: {difference}");

        // 곱셈
        Fraction product = fraction1.MulFraction(fraction2);
        Console.WriteLine($"곱셈 결과: {product}");

        // 나눗셈
        Fraction quotient = fraction1.DivFraction(fraction2);
        Console.WriteLine($"나눗셈 결과: {quotient}");
    }
}
