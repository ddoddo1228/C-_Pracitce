using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("파일 이름을 입력하세요: ");
            string fileName = Console.ReadLine();
            string filePath = Path.Combine(Environment.CurrentDirectory, fileName);

            if (File.Exists(filePath))
            {
                Console.WriteLine("파일을 성공적으로 열었습니다.");
                break;
            }
            else
            {
                Console.WriteLine("파일이 존재하지 않습니다. 다시 시도하세요.");
            }
        }
    }
}
