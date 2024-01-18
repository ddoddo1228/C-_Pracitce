using System;

class CS_19
{
    static void Main(string[] args)
    {
        Stack mystack = new Stack();
        Console.WriteLine("정수를 입력하세요 (입력의 끝은 0입니다)");

        while (true)
        {
            string inputString = Console.ReadLine();

            if (inputString == "0")
                break;

            if (int.TryParse(inputString, out int input))
            {
                mystack.Push(input);
            }
            else
            {
                Console.WriteLine("유효한 정수를 입력하세요.");
            }
        }

        Console.WriteLine("입력된 정수를 역순으로 출력합니다.");

        while (!mystack.IsEmpty())
        {
            int data = mystack.Pop();
            Console.WriteLine(data);
        }
    }
}

class Stack
{
    private int[] stack;
    private int sp = -1;

    public Stack()
    {
        stack = new int[100];
    }

    public void Push(int data)
    {
        if (sp < stack.Length - 1)
        {
            sp++;
            stack[sp] = data;
        }
        else
        {
            Console.WriteLine("스택이 가득 찼습니다.");
        }
    }

    public int Pop()
    {
        if (sp >= 0)
        {
            int data = stack[sp];
            sp--;
            return data;
        }
        else
        {
            Console.WriteLine("스택이 비어있습니다.");
            return -1;
        }
    }

    public bool IsEmpty()
    {
        return sp == -1;
    }
}
