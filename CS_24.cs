using System;
using System.Collections.Generic;

public interface IOperation
{
    void Insert(string str);
    string Delete();
    bool Search(string str);
    string GetCurrentElt();
    int NumOfElements();
}

public class Stack : IOperation
{
    private List<string> stackList;

    public Stack()
    {
        stackList = new List<string>();
    }

    public void Insert(string str)
    {
        stackList.Add(str);
    }

    public string Delete()
    {
        if (stackList.Count == 0)
        {
            throw new InvalidOperationException("스택이 비어 있습니다.");
        }
        string topElement = stackList[stackList.Count - 1];
        stackList.RemoveAt(stackList.Count - 1);
        return topElement;
    }

    public bool Search(string str)
    {
        return stackList.Contains(str);
    }

    public string GetCurrentElt()
    {
        if (stackList.Count == 0)
        {
            throw new InvalidOperationException("스택이 비어 있습니다.");
        }
        return stackList[stackList.Count - 1];
    }

    public int NumOfElements()
    {
        return stackList.Count;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Stack stack = new Stack();
        stack.Insert("첫 번째 원소");
        stack.Insert("두 번째 원소");
        stack.Insert("세 번째 원소");

        Console.WriteLine("스택에 있는 원소 개수: " + stack.NumOfElements());
        Console.WriteLine("현재 스택 탑에 있는 원소: " + stack.GetCurrentElt());
        Console.WriteLine("스택에서 팝한 원소: " + stack.Delete());

        Console.WriteLine("스택에 '두 번째 원소'가 존재하는가? " + stack.Search("두 번째 원소"));
        Console.WriteLine("스택에 '네 번째 원소'가 존재하는가? " + stack.Search("네 번째 원소"));
    }
}
