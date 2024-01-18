using System;

public interface IFigure
{
    void Area();  
    void Girth();
    void Draw();  
}

public class Rectangle : IFigure
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public void Area()
    {
        double area = width * height;
        Console.WriteLine($"사각형의 넓이: {area}");
    }

    public void Girth()
    {
        double girth = 2 * (width + height);
        Console.WriteLine($"사각형의 둘레: {girth}");
    }

    public void Draw()
    {
        Console.WriteLine("사각형 그리기");
    }
}

public class Circle : IFigure
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public void Area()
    {
        double area = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine($"원의 넓이: {area}");
    }

    public void Girth()
    {
        double girth = 2 * Math.PI * radius;
        Console.WriteLine($"원의 둘레: {girth}");
    }

    public void Draw()
    {
        Console.WriteLine("원 그리기");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle(5.0, 4.0);
        Circle circle = new Circle(3.0);
        rectangle.Area();
        rectangle.Girth();
        rectangle.Draw();
        Console.WriteLine();
        circle.Area();
        circle.Girth();
        circle.Draw();
    }
}
