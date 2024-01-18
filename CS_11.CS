using System;

class CS_11
{
    static void hang(int[,] matrix)
    {
        int numRows = matrix.GetLength(0);
        int numCols = matrix.GetLength(1);

        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static int[,] Transhang(int[,] matrix)
    {
        int numRows = matrix.GetLength(0);
        int numCols = matrix.GetLength(1);
        int[,] trans = new int[numCols, numRows];

        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
            {
                trans[j, i] = matrix[i, j];
            }
        }

        return trans;
    }

    static void Main()
    {
        int[,] org =
        {
            {1, 2, 3},
            {4, 5, 6}
        };

        Console.WriteLine("Original Matrix:");
        hang(org);

        int[,] trans = Transhang(org);

        Console.WriteLine("\nTransposed Matrix:");
        hang(trans);
    }
}
