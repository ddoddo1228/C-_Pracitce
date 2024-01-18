using System;

class CS_05 {
    public static void Main() {
        Console.WriteLine("값을 입력하세요.:");
        string value = Console.ReadLine();
        bool isPalindrome = true;

        for (int i = 0; i < value.Length / 2; i++) {
            if (value[i] != value[value.Length - 1 - i]) {
                isPalindrome = false;
                break;
            }
        }

        if (isPalindrome) {
            Console.WriteLine("회문수 입니다.");
        }
        else {
            Console.WriteLine("회문수가 아닙니다.");
        }
    }
}
