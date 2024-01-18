using System;

class CS_08
{
    static void Main()
    {
        int n = 10;
        double sum1 = 0;
        double sum2 = 0;
        int sign = 1;

        for (int i = 1; i <= n; i++)
        {
            double term1 = 1.0;
            double term2 = 1.0 / i;

            for (int j = 1; j <= i; j++)
            {
                term1 *= j;
            }

            sum1 += term1;
            sum2 += sign * term2;
            sign = -sign;
        }

        Console.WriteLine("1번: " + sum1);
        Console.WriteLine("2번: " + sum2);
    }
}
