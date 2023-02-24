using BasicAlgorithmAndDataStructures.BasicOOP.DrawingAbstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithmAndDataStructures.BasicOOP
{
    public static class StringExtension
    {
        public static int WordNumber(this string n) =>
            n.Split().Length;
    }
    public static class PositionExtension // Example or Try
    {
        public static void aa(this Position x) =>
            Console.WriteLine(x.X * 3);
    }
}
