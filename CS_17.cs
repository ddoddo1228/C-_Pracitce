using System;
using System.Collections.Generic; 

class XS_17
{
    private List<int> stack;

    public XS_17()
    {
        stack = new List<int>();
    }

    public void Push(int data)
    {
        stack.Add(data);
    }

    public int Pop()
    {
        if (stack.Count > 0)
        {
            int lastIndex = stack.Count - 1;
            int data = stack[lastIndex];
            stack.RemoveAt(lastIndex);
            return data;
        }
        else
        {
            Console.WriteLine("스택이 비어있습니다.");
            return -1;
        }
    }

    public bool IsEmpty() // 괄호 수정
    {
        return stack.Count == 0;
    }
}
