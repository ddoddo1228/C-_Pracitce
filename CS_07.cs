using System;

class CS_07
{
    static void Main()
    {
        int n = 9;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }

            for (int j = i; j >= 1; j--)
            {
                Console.Write(j);
            }

            for (int j = 2; j <= i; j++)
            {
                Console.Write(j);
            }

            Console.WriteLine();
        }
    }
}
