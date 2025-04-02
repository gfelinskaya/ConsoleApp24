namespace ConsoleApp24
{
    class Circle : Shape
    {
        const float Pi = 3.14f;
        public double Radius { get; }

        public Circle(string name, string color, double radius)
            :base(name, color, radius) 
        {   
            Radius = radius;
        }

        public override double GetSquare()
        {
            double result = Pi * Math.Pow(Radius, 2);
            return result;  
        }

        public double LengthOfCircle()
        {
        return GetPerimeter();
        }
        public override double GetPerimeter()
        {
           double result = 2 * Pi * Radius;
            return result;
        }

        public override void Visualize()
        {
            Console.WriteLine("0");
        }
    }
}
