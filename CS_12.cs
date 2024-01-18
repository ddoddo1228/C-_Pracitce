using System;

public delegate string MyDelegate(int i);

public class CS_12
{
    public static string MethodA(int i)
    {
        return string.Format("int value = {0}", i);
    }

    public static void Main()
    {
        MyDelegate myDelegate = MethodA;
        string result = myDelegate(42);
        Console.WriteLine(result);
    }
}
