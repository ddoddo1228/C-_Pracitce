using System;

class CS_09
{
    static void Main()
    {
        int r, c;
        int n1, n2;

        for (n1 = -1, n2 = 5, r = 1; r <= 9; r++)
        {
            if (r <= 5)
            {
                n1 += 2;
                n2--;
            }
            else
            {
                n1 -= 2;
                n2++;
            }

            for (c = 1; c <= n2; c++)
            {
                Console.Write(" ");
            }

            for (c = 1; c <= 1; c++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}
