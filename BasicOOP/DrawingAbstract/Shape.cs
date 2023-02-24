using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithmAndDataStructures.BasicOOP.DrawingAbstract
{
    public sealed class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        public override string ToString() =>
            $"X: {X}, Y: {Y}";
    }
    public sealed class Size
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public override string ToString() =>
            $"Width : {Width}, Height : {Height}";
    }
    public abstract class Shape
    {
        public Shape()
        {
            Console.WriteLine("Base class -> constructor");
        }
        public Shape(int Width, int Height, int x, int y)
        {
            Size = new Size { Width = Width, Height = Height };
            Position = new Position { X = x, Y = y };
        }
        public Position Position { get; } = new Position();
        public Size Size { get; } = new Size();
        public virtual void Draw() =>
            Console.WriteLine($"Shape {Position} - {Size}");
        public virtual void Move(Position NewPosition)
        {
            Position.X = NewPosition.X;
            Position.Y = NewPosition.Y;
            Console.WriteLine($"Moved: {Position}");
        }
        public abstract void ReShape(int Width, int Height);
    }
}
