using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithmAndDataStructures.BasicOOP.Drawing
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        public override string ToString() =>
            $"X: {X}, Y: {Y}";
    }
    public class Size
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public override string ToString() =>
            $"Width : {Width}, Height : {Height}";
    }
    public class Shape
    {
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
    }
}
