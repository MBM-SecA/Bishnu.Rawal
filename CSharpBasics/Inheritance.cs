using System;

public interface IShapeWithSides
{ 
    public double GetDiagonal();
}

public abstract class Shape
{
    // Define abstract members when you want to force derived classes to 
    // implement their own logic
    public abstract double GetArea();
    public abstract double GetCircumference();
    public virtual void Display()
    {
        Console.WriteLine("Displaying result for some shape.");
    }
}

public class Square : Shape, IShapeWithSides
{
    public Square(double side)
    {
        Side = side;
    }

    public double Side { get; set; }

    public override double GetArea() => Side * Side;
    public override double GetCircumference() => 4 * Side;

    public override void Display()
    {
        Console.WriteLine($"Displaying results for Sqaure with side {Side}:");
        Console.WriteLine($"Area: {this.GetArea()} square unit.");
        Console.WriteLine($"Circumference: {this.GetCircumference()} unit.");
    }

    public double GetDiagonal() => Math.Sqrt(2 * Side * Side);
}

public class Rectangle : Shape, IShapeWithSides
{
    public double Length { get; set; }
    public double Breadth { get; set; }

    public Rectangle(double lenght, double breadth)
    {
        Length = lenght;
        Breadth = breadth;
    }

    public override double GetArea() => Length * Breadth;
    public override double GetCircumference() => 2 * (Length + Breadth);

    public double GetDiagonal() => Math.Sqrt(Length * Length + Breadth * Breadth);
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public override double GetArea() => Math.PI * Radius * Radius;
    public override double GetCircumference() => 2 * Math.PI * Radius;
}

class A
{ }
class B : A
{ }

class C : B
{ }

class D : IA, IB
{ }

interface IA
{ }

interface IB
{ }
