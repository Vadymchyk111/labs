using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_9
{
    class Picture : IDraw
    {
        private List<Shape> Shapes;
        public int ShapeCount => Shapes.Count;

        public Picture()
        {
            Shapes = new List<Shape>();
        }

        public Picture(int shapesNumber)
        {
            Shapes = new List<Shape>(shapesNumber);
        }

        public void AddShape(Shape shape)
        {
            Shapes.Add(shape);
        }
        public void RemoveShape(string name, string type, double square)
        {
            List<Shape> shapesToRemove = new List<Shape>();
            if (type == "square")
            {
                foreach (var shape in Shapes)
                {
                    if (shape is Square && shape.ShapeName == name && shape.CalculateSquare() > square)
                        shapesToRemove.Add(shape);
                }
            }
            if (type == "circle")
            {
                foreach (var shape in Shapes)
                {
                    if (shape is Circle && shape.ShapeName == name && shape.CalculateSquare() > square)
                        shapesToRemove.Add(shape);
                }
            }
            if (type == "triangle")
            {
                foreach (var shape in Shapes)
                {
                    if (shape is Triangle && shape.ShapeName == name && shape.CalculateSquare() > square)
                        shapesToRemove.Add(shape);
                }
            }

            Shapes = Shapes.Except(shapesToRemove).ToList();
        }
        public Shape this[int index] => Shapes.ElementAtOrDefault(index);

        public void Draw()
        {
            foreach (var shape in Shapes)
                shape.Draw();
        }
    }
}
