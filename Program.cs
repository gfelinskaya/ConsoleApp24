using System.Diagnostics;
using System.Text;

namespace ConsoleApp24
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            var triangle = new Triangle("Трикутник рівносторонній", "Green", TriangleType.Equilateral, 12, 12, 12);
            var rectangle1 = new Rectangle("Прямокутник", "Blue", 20, 45);
            var blackSquare = new Square("Чорний квадрат", "Black", 35);

            Shape[] shapes = [triangle, rectangle1, blackSquare];

            for (int i = 0; i < shapes.Length; i++)
            {
                switch (shapes[i].Color)
                {
                    case "Green": Console.ForegroundColor = ConsoleColor.Green; 
                        break;
                    case "Blue":
                        {                        
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        break;
                    case "Black":
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                        break;
                }
                Console.WriteLine(shapes[i].Name);
                Console.WriteLine($"Square = {shapes[i].GetSquare()}");
                Console.WriteLine($"Perimetr = {shapes[i].GetPerimeter()}");

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine(new String('-', 30));
            }
        }
    }
}
