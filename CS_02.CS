using System;

class CS_02 {
    static double Volume(double x) {
        return 4.0 * Math.PI * x * x * x / 3.0;
    }

    static double SurfaceArea(double x) {
        return 4.0 * Math.PI * x * x;
    }

    public static void Main() {
        double r;
        Console.Write("반지름을 입력하시오: ");
        r = double.Parse(Console.ReadLine());
        Console.WriteLine("부피: {0:0.##}", Volume(r));
        Console.WriteLine("표면적: {0:0.##}", SurfaceArea(r));
    }
}
