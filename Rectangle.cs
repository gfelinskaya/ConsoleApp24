namespace ConsoleApp24;

class Rectangle : Shape
{
    public double SideA { get; }
    public double SideB { get; }

    public Rectangle(string name, string color, double side1, double side2)
        : base(name, color, side1, side2)
    { 
        SideA = side1;
        SideB = side2;
    }

    public override double GetPerimeter()
    {
        return 2 * SideA + SideB;
    }

    public override double GetSquare()
    {
        return SideA * SideB;
    }
}
