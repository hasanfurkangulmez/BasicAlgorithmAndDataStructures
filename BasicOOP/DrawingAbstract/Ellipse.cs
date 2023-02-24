using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithmAndDataStructures.BasicOOP.DrawingAbstract
{
    public class Ellipse : Shape
    {
        public override void Move(Position NewPosition)
        {
            Console.Write("Elips ");
            base.Move(NewPosition);
        }

        public override void ReShape(int Width, int Height)
        {
            Size.Width = Width;
            Size.Height = Height;
        }
    }
}
