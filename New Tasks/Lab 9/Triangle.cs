using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    class Triangle : Shape
    {
        public override ConsoleColor ShapeColor { get; set; }
        public override int VerticlesCount => 3;
        public override string ShapeName { get; }
        public int LateralSideLenght { get; set; }
        public int BaseSideLenght { get; set; }

        public Triangle(string shapeName)
        {
            Random rand = new Random();
            ShapeName = shapeName;
            int randNumber = rand.Next(16);
            ShapeColor = (ConsoleColor)randNumber;
            LateralSideLenght = rand.Next(100);
            BaseSideLenght = rand.Next(LateralSideLenght * 2);
        }

        public Triangle(string shapeName, int lateralSideLenght, int baseSideLenght)
        {
            Random rand = new Random();
            ShapeName = shapeName;
            int randNumber = rand.Next(16);
            ShapeColor = (ConsoleColor)randNumber;
            LateralSideLenght = lateralSideLenght;
            BaseSideLenght = baseSideLenght;
        }
        public Triangle(string shapeName, int lateralSideLenght, int baseSideLenght, int color)
        {
            ShapeName = shapeName;
            ShapeColor = (ConsoleColor)color;
            LateralSideLenght = lateralSideLenght;
            BaseSideLenght = baseSideLenght;
        }

        public override double CalculateSquare()
        {
            return Math.Sqrt(4 * LateralSideLenght ^ 2 - BaseSideLenght ^ 2) * 0.5 * BaseSideLenght;
        }

        public override double CalculatePerimeter()
        {
            return BaseSideLenght + LateralSideLenght * LateralSideLenght;
        }

        public override void Draw()
        {
            Console.ForegroundColor = ShapeColor;
            Console.WriteLine("Фигура: Треугольник;" +
                              $"\nНазвание фигуры: {ShapeName}" +
                              $"\nКоличество вершин: {VerticlesCount}" +
                              $"\nДлина основы: {BaseSideLenght}" +
                              $"\nДлина боковых сторон: {LateralSideLenght}" +
                              $"\nПлощадь: {CalculateSquare()}" +
                              $"\nПериметр: {CalculatePerimeter()}");
            Console.ResetColor();
        }
    }
}
