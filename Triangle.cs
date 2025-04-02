namespace ConsoleApp24
{
    class Triangle : Shape
    {
        public TriangleType Type { get; }

        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(string name, string color, TriangleType type, params double[] sides)
            :base(name, color, sides) 
        {   
            Type = type;
            SideA = sides[0];
            SideB = sides[1];
            SideC = sides[2];
        }

        public override double GetSquare()
        {
            var result = (Type) switch
            {
                TriangleType.Priamohutny => Math.Sqrt(GetHalfPerimeter() * (GetHalfPerimeter() - Sides[0]) * (GetHalfPerimeter() - Sides[1]) * (GetHalfPerimeter() - Sides[2])),
                TriangleType.Rivnostoronniy => Math.Sqrt(GetHalfPerimeter() * Math.Pow(GetHalfPerimeter() - Sides[0], 3)),
                TriangleType.Rivnobedreniy => Math.Sqrt(GetHalfPerimeter() * Math.Pow(GetHalfPerimeter() - Sides[0], 2) * (GetHalfPerimeter() - Sides[1])),
                TriangleType.Riznostoronniy => Math.Sqrt(GetHalfPerimeter() * (GetHalfPerimeter() - Sides[0]) * (GetHalfPerimeter() - Sides[1]) * (GetHalfPerimeter() - Sides[2]))
            };

            return result;  
        }

        public override double GetPerimeter()
        {
            double result = (Type) switch
            {
                TriangleType.Priamohutny => Sides[0] + Sides[1] + Sides[2],
                TriangleType.Rivnostoronniy => 3 * Sides[0],
                TriangleType.Rivnobedreniy => 2 * Sides[0] + Sides[1],
                TriangleType.Riznostoronniy => Sides[0] + Sides[1] + Sides[2]
            };

            return result;
        }
         public double GetHalfPerimeter() 
        {
            double result = GetPerimeter () / 2;
            return result;
        }

        public override void Visualize()
        {
            Console.WriteLine("*");
        }
    }
}
