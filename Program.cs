using System;

public class Program
{
    static void Main(string[] args)
    {
        Shape[] figure = new Shape[2];
        figure[0] = new Circle("Красный", 0, 0, 5);
        figure[1] = new Rectangle("Черный", 0, 0, 10, 5);

        foreach (Shape shape in  figure)
        {
            shape.Draw();
        }

        Console.ReadKey();
    }
}