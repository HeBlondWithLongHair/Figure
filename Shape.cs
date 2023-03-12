using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

abstract public class Shape
{
    public string color;
    public abstract void Draw();

}

public class Circle : Shape
{
    float x;
    float y;
    float radius;

    public Circle(string color,float x, float y, float radius)
    {
        this.color = color;
        this.x = x;
        this.y = y;
        this.radius = radius;
    }

    public override void Draw()
    {
        Console.WriteLine($"Рисуем circle цвета: {color} с координатами ({x}, {y}) и радиусом {radius}");
    }

}

public class Rectangle : Shape
{
   
    float x1;
    float x2;
    float x3;
    float x4;

    public Rectangle(string color, float x1, float x2, float x3, float x4)
    {
        this.color = color;
        this.x1 = x1;
        this.x2 = x2;
        this.x3 = x3;
        this.x4 = x4;
    }

    public override void Draw()
    {
        Console.WriteLine($"Рисуем Rectangle цвета {color} с координатами {x1}, {x2}, {x3}, {x4}");
    }

}
