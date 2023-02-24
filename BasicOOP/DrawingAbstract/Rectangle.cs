using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithmAndDataStructures.BasicOOP.DrawingAbstract
{
    public class Rectangle : Shape
    {
        public Rectangle() : base()
        {
            Console.WriteLine("Derived class -> constructor");
        }

        public Rectangle(int Width, int Height, int x, int y) : base(Width, Height, x, y) //base(Width: -5, Height: -5, x: -10, y: -10) override
        {
            Console.WriteLine("Derived class -> ctor - 4p");
        }

        public override void Draw() =>
            Console.WriteLine($"Rectangle {Position} - {Size}");

        public override void Move(Position NewPosition)
        {
            Console.Write("Rectangle ");
            base.Move(NewPosition);
        }

        public override void ReShape(int Width, int Height)
        {
            Size.Width = Width;
            Size.Height = Height;
        }
    }
}