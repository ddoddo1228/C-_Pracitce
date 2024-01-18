using System;

public class CS_22
{
    private int[] v;

    public CS_22(int size)
    {
        v = new int[size];
    }

    public int this[int index]
    {
        get
        {
            if (index < 0 || index >= v.Length)
            {
                throw new IndexOutOfRangeException("인덱스가 범위를 벗어났습니다.");
            }
            return v[index];
        }
        set
        {
            if (index < 0 || index >= v.Length)
            {
                throw new IndexOutOfRangeException("인덱스가 범위를 벗어났습니다.");
            }
            v[index] = value;
        }
    }

    public static CS_22 operator ++(CS_22 vector)
    {
        for (int i = 0; i < vector.v.Length; i++)
        {
            vector.v[i]++;
        }
        return vector;
    }

    public static CS_22 operator --(CS_22 vector)
    {
        for (int i = 0; i < vector.v.Length; i++)
        {
            vector.v[i]--;
        }
        return vector;
    }

    public static void Main(string[] args)
    {
        CS_22 myVector = new CS_22(3);
        myVector[0] = 1;
        myVector[1] = 2;
        myVector[2] = 3;

        Console.WriteLine("벡터:");
        Console.WriteLine(myVector[0]);
        Console.WriteLine(myVector[1]);
        Console.WriteLine(myVector[2]);

        myVector++;
        Console.WriteLine("\n++ 연산자:");
        Console.WriteLine(myVector[0]);
        Console.WriteLine(myVector[1]);
        Console.WriteLine(myVector[2]);

        myVector--;
        Console.WriteLine("\n-- 연산자:");
        Console.WriteLine(myVector[0]);
        Console.WriteLine(myVector[1]);
        Console.WriteLine(myVector[2]);
    }
}
