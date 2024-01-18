using System;

class CS_10
{
    static void Main()
    {
        int r, c;
        for (r = 1; r <= 9; r++)
        {
            for (c = 1; c <= r; c++)
            {
                Console.Write(" ");
            }

            for (c = r; c <= 8 + r; c++)
            {
                if (c <= 9)
                    Console.Write("{0}", c);
                else
                    Console.Write("{0}", c - 9);
            }

            Console.WriteLine();
        }
    }
}
