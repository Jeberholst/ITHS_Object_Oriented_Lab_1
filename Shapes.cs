using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Shapes
{
    public abstract double GetArea();
    public abstract double GetPerimeter();
    public abstract override string ToString();
    public void SayHello()
    {
        Console.WriteLine($"{this.GetType().Name} says hello!");
    }
    public virtual void ScreamHello()
    {
        Console.WriteLine($"{this.GetType().Name.ToUpper()} SCREAMS HELLO!");
    }
    //Notera att SayHello inte kommer att kunna ändras i de ärvda klasserna.
    //ScreamHello kan dock ändras då det är markerat som virtual.


}

public class Square: Shapes
{

    public Square(int side)
    {
        SideLength = side;
    }

    public int SideLength { get; set; }


    public override double GetArea()
    {
        return (SideLength * SideLength);
    }

    public override double GetPerimeter()
    {
        return (SideLength * 4);
    }

    public override string ToString()
    {

        StringBuilder sb = new StringBuilder();
        sb.Append("This is a ");
        sb.Append(this.GetType().Name.ToLower());
        sb.Append(" ");
        sb.Append("with side length " + SideLength);
        sb.Append(", ");
        sb.Append("area " + GetArea());
        sb.Append(" ");
        sb.Append("and perimeter length " + GetPerimeter());
        sb.Append(".");

        return sb.ToString();
    }
}

public class Rectangle: Shapes
{

    public int Width { get; set; }
    public int Height { get; set; }

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public Rectangle(int width)
    {
        Width = width;
        Height = width;
    }

    public override double GetArea()
    {
        return (Width * Height);
    }

    public override double GetPerimeter()
    {
        return (Width * 2) + (Height * 2);
    }

    public override string ToString()
    {

        StringBuilder sb = new StringBuilder();
        sb.Append("This is a ");
        sb.Append(this.GetType().Name.ToLower());
        sb.Append(" ");
        sb.Append("with height " + Height);
        sb.Append(" ");
        sb.Append("and width " + Width);
        sb.Append(". ");
        sb.Append("Area is " + GetArea());
        sb.Append(" ");
        sb.Append("and perimeter is " + GetPerimeter());
        sb.Append(".");


        return sb.ToString();

    }

}

public class Circle : Shapes
{
    private int radius;

    public Circle(int radius)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return ((radius * radius) * Math.PI);
    }

    public override double GetPerimeter()
    {
        return ((radius * 2) * Math.PI);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("This is a ");
        sb.Append(this.GetType().Name.ToLower());
        sb.Append(" ");
        sb.Append("with radius " + radius);
        sb.Append(".");
        sb.Append(" ");
        sb.Append("The area is " + GetArea());
        sb.Append(" ");
        sb.Append("and the perimeter is " + GetPerimeter());
        sb.Append(".");


        return sb.ToString();
    }
}

