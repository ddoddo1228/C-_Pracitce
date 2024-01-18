using System;

class CS_01 {
    public static void Main() {

        double H;
        double W;
        double SW;
        double B;

        Console.Write("키 : ");
        if (double.TryParse(Console.ReadLine(), out H) == false) {
            return;
        }

        Console.Write("몸무게 : ");
        if (double.TryParse(Console.ReadLine(), out W) == false) {
            return;
        }

        SW = (H - 100.0) * 0.9;
        B = W / SW * 100.0;
        Console.WriteLine("\n비만도는 {0:0.##}입니다.", B);
    }
}
