using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    class Circle : Shape
    {
        public override ConsoleColor ShapeColor { get; set; }
        public override int VerticlesCount => 0;
        public override string ShapeName { get; }
        public int Radius { get; set; }

        public Circle(string shapeName)
        {
            Random random = new Random();
            int randomNumber = random.Next(16);
            ShapeColor = (ConsoleColor) randomNumber;
            ShapeName = shapeName;
            Radius = random.Next(100);
        }

        public Circle(string shapeName, int size)
        {
            ShapeName = shapeName; 
            Random random = new Random();
            int randomNumber = random.Next(16);
            ShapeColor = (ConsoleColor)randomNumber;
            Radius = size;
        }

        public Circle(string shapeName, int size, int color)
        {
            ShapeName = shapeName;
            Radius = size;
            ShapeColor = (ConsoleColor)color;
        }
        public override double CalculatePerimeter()
        {
            return Math.PI * (Radius * Radius);
        }

        public override double CalculateSquare()
        {
            return 2 * Math.PI * Radius;
        }

        public override void Draw()
        {
            Console.ForegroundColor = ShapeColor;
            Console.WriteLine("Фигура: Круг" +
                              $"\nНазвание фигуры: {ShapeName}" +
                              $"\nКоличество вершин: {VerticlesCount}" +
                              $"\nРадиус круга: {Radius}" +
                              $"\nПлощадь круга: {CalculateSquare()}" +
                              $"\nПериметр круга: {CalculatePerimeter()}");
            Console.ResetColor();
        }
    }
}
