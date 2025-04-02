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
                TriangleType.Rectangular => 0.5 * SideA * Sides[1],
                TriangleType.Isosceles => 0.5 * Sides[2],
                TriangleType.Equilateral => 0.5 * Sides[2]  
            };

            return result;  
        }

        public override double GetPerimeter()
        {
            var result = (Type) switch
            {
                TriangleType.Rectangular => 0.5 * Sides[0] * Sides[1],
                TriangleType.Isosceles => 0.5 * Sides[2],
                TriangleType.Equilateral => 0.5 * Sides[2]
            };

            return result;
        }
    }
}
