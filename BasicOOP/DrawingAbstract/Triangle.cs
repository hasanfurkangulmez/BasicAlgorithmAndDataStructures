using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithmAndDataStructures.BasicOOP.DrawingAbstract
{
    public class Triangle : Shape
    {
        public override void ReShape(int Width, int Height)
        {
            Size.Width = Width;
            Size.Height = Height;
        }
        public override void Draw()
        {
            Console.Write("Triangle ");
            base.Draw();
        }
    }
}
