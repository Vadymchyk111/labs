using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    abstract class Shape : IDraw
    {
        public abstract ConsoleColor ShapeColor { get; set; }
        public abstract int VerticlesCount { get; }
        public abstract string ShapeName { get; }
        public abstract double CalculateSquare();
        public abstract double CalculatePerimeter();
        public abstract void Draw();
    }
}
