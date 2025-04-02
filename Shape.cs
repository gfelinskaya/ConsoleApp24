namespace ConsoleApp24
{
    abstract class Shape
    {
        public string Name { get; }

        public string Color { get; set; }
        public double[] Sides { get; set; } 

        protected Shape(string name, string color, params double[] sides)
        {
            Name = name;
            Color = color;
            Sides = sides;
        }

        public abstract double GetSquare();
        
        public abstract double GetPerimeter();
    }
}
