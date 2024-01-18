using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("스택 테스트 코드");
        Stack<string> stack = new Stack<string>();
        stack.Push("첫 번째 스택 원소");
        stack.Push("두 번째 스택 원소");
        stack.Push("세 번째 스택 원소");
        Console.WriteLine("스택에 있는 원소 개수: " + stack.Count);
        Console.WriteLine("현재 스택 탑에 있는 원소: " + stack.Peek());
        Console.WriteLine("스택에서 팝한 원소: " + stack.Pop());
        Console.WriteLine("스택에 '두 번째 스택 원소'가 존재하는가? " + stack.Contains("두 번째 스택 원소"));
        Console.WriteLine("스택에 '네 번째 스택 원소'가 존재하는가? " + stack.Contains("세 번째 스택 원소"));

        Console.WriteLine("\n큐 테스트 코드");
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("첫 번째 큐 원소");
        queue.Enqueue("두 번째 큐 원소");
        Console.WriteLine("현재 큐 프런트에 있는 원소: " + queue.Peek());
        Console.WriteLine("큐에서 디큐한 원소: " + queue.Dequeue());
        Console.WriteLine("큐에 '두 번째 큐 원소'가 존재하는가? " + queue.Contains("두 번째 큐 원소"));
        Console.WriteLine("큐에 '네 번째 큐 원소'가 존재하는가? " + queue.Contains("네 번째 큐 원소"));
    }
}
