using System;

namespace BasicAlgorithmAndDataStructures.BasicAlgorithmAndProgramming
{
    internal class MathExamplesOne
    {
        public MathExamplesOne()
        {
            Console.Write("Please! Enter a number: ");
            int Number = int.Parse(Console.ReadLine());
            Console.WriteLine($"0 - {Number} is equal to {Zero_N_Numbers_Sum(Number)}\n" +
            $"0 - {Number} (Odd) is equal to {Zero_N_Odd_Numbers_Sum(Number)}\n" +
            $"0 - {Number} (Even) is equal to {Zero_N_Even_Numbers_Sum(Number)}");
        }
        public int Zero_N_Numbers_Sum(int n)
        { return n * (n + 1) / 2; }
        public int Zero_N_Odd_Numbers_Sum(int n)//((n + 1) / 2) * ((n + 1) / 2)
        { return (int)Math.Pow(((n + 1) / 2), 2); }
        public int Zero_N_Even_Numbers_Sum(int n)
        { return (n / 2) * ((n / 2) + 1); }
    }
}