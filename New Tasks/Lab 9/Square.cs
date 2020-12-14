using System;

namespace Lab_9
{
    class Square : Shape
    {
        public override ConsoleColor ShapeColor { get; set; }
        public override int VerticlesCount => 4;
        public override string ShapeName { get; }
        public int SideLenght { get; set; }

        public Square(string shapeName)
        {
            Random rand = new Random();
            ShapeName = shapeName;
            ShapeColor = (ConsoleColor)rand.Next(16);
            SideLenght = rand.Next(1, 11);
        }
        public Square(string shapeName, int size)
        {
            ShapeName = shapeName;
            ShapeColor = (ConsoleColor)new Random().Next(16);
            SideLenght = size;
        }
        public Square(string shapeName, int size, int color)
        {
            ShapeName = shapeName;
            ShapeColor = (ConsoleColor)color;
            SideLenght = size;
        }

        public override double CalculateSquare()
        {
            return SideLenght * SideLenght;
        }

        public override double CalculatePerimeter()
        {
            return SideLenght * 4;
        }
        public override void Draw()
        {
            Console.ForegroundColor = ShapeColor;
            Console.WriteLine("Фигура: Квадрат;" +
                              $"\nНазвание: {ShapeName}" +
                              $"\nКоличество вершин: {VerticlesCount}" +
                              $"\nДлинна стороны: {SideLenght}" +
                              $"\nПлощадь: {CalculateSquare()}" +
                              $"\nПериметр: {CalculatePerimeter()}");
            Console.ResetColor();
        }
    }
}
