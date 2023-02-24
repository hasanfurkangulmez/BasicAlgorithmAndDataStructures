using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithmAndDataStructures.BasicOOP.Modelling
{
    public class Tool
    {
        public string Engine { get; set; }
        public double Volume { get; set; }
        public void Clear() => Console.WriteLine("Tool cleaned.");
    }
    public enum Engine
    {
        Diesel,
        Gasoline,
        LPG,
        Electric,
        Jet
    }
    public enum Colour
    {
        White,
        Black,
        Gray,
        Red,
        Green,
        Blue
    }
}
