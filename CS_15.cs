public class CS_15
{
    public int numerator;
    public int denominator;

    public CS_15(int numerator, int denominator)
    {
        this.numerator = numerator;
        if (denominator != 0)
        {
            this.denominator = denominator;
        }
        else
        {
            throw new ArgumentException("분모는 0이 될 수 없습니다.");
        }
    }

    public override string ToString()
    {
        return $"{numerator}/{denominator}";
    }

    public static void Main(string[] args)
    {
        try
        {
            CS_15 fraction = new CS_15(3, 4);
            Console.WriteLine(fraction.ToString());
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
