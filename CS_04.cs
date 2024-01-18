using System;

class CS_04 {

    public static void Main() {
        int i, a;
        Console.WriteLine("100 이하의 소수:");

        for (i = 2; i <= 100; i++) {
            bool isPrime = true;

            for (a = 2; a < i; a++) {
                if (i % a == 0) {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime) {
                Console.Write("{0} ", i);
            }
        }

        Console.WriteLine();
    }
}
