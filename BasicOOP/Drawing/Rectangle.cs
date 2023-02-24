using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithmAndDataStructures.BasicOOP.Drawing
{
    public class Rectangle : Shape
    {
        public override void Draw() =>
            Console.WriteLine($"Rectangle {Position} - {Size}");
        public override void Move(Position NewPosition)
        {
            Console.Write("Rectangle ");
            base.Move(NewPosition);
        }
    }
}