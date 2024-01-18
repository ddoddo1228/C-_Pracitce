using System;

class CS_06
{
    static int ya(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static int go(int a, int b)
    {
        return (a * b) / ya(a, b);
    }

    static void Main()
    {
        Console.WriteLine("두 수의 최대 공약수와 최소공배수를 계산합니다.");

        Console.Write("첫 번째 수를 입력하세요.: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("두 번째 수를 입력하세요.: ");
        int num2 = int.Parse(Console.ReadLine());

        int ak = ya(num1, num2);
        int bae = go(num1, num2);

        Console.WriteLine("두 수의 최대 공약수: " + ak);
        Console.WriteLine("두 수의 최소 공배수: " + bae);
    }
}
