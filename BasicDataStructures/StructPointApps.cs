﻿using System;

namespace BasicAlgorithmAndDataStructures.BasicDataStructures
{
    public struct StructPointApps
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return $"{X},{Y}";
        }

        // Default ctor tanımlanamaz!
        public StructPointApps(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Yapımıza yeni üye -> Metot. 
        public void SetOrigin()
        {
            X = 0;
            Y = 0;
        }

        public void Change()
        {
            var gecici = X;
            X = Y;
            Y = gecici;
        }

        public static void ExampleRun()
        {
            // struct -> değer tipli 
            var n1 = new StructPointApps(3, 4);
            Console.WriteLine($"n1: {n1}");

            n1.Change();
            Console.WriteLine($"n1: {n1}");

            var n2 = n1;
            Console.WriteLine($"n2: {n2}");
            n2.X = -1 * n2.X;

            Console.WriteLine($"n1: {n1}");
            Console.WriteLine($"n2: {n2}");

        }
    }
}


