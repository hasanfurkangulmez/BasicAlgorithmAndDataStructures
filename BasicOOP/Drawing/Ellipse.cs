using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithmAndDataStructures.BasicOOP.Drawing
{
    public class Ellipse : Shape
    {
        public override void Move(Position NewPosition)
        {
            Console.Write("Elips ");
            base.Move(NewPosition);
        }
    }
}
