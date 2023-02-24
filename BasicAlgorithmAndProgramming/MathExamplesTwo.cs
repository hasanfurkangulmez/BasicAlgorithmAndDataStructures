using System;

namespace BasicAlgorithmAndDataStructures.BasicAlgorithmAndProgramming
{
    internal class MathExamplesTwo
    {
        public MathExamplesTwo()
        {
            int[] Numbers = new int[25];
            for (int i = 0, j = 1; i < Numbers.Length && j <= 25; i++, j++)
            {
                Numbers[i] = new Random().Next(0, 100);
                Console.Write(Numbers[i] + "\t");
                if (j % 5 == 0) Console.WriteLine("\n" + new string('-', 5));
            }
            Console.WriteLine("Arithmetic Mean is equal to {0:F4}", ArithmeticMean(Numbers));
            Console.WriteLine("Standard Deviation is equal to {0:F4}", StandardDeviation(Numbers));
        }
        public double ArithmeticMean(int[] X)
        {
            double Sum = 0;
            for (int i = 0; i < X.Length; i++) Sum += X[i];
            return Sum / X.Length;
        }
        public double StandardDeviation(int[] X)
        {
            double arithmeticMean = ArithmeticMean(X);
            double Sum = 0, Difference = 0;
            for (int i = 0; i < X.Length; i++)
            {
                Difference = X[i] - arithmeticMean;
                Sum += Math.Pow(Difference, 2);
            }
            return Math.Sqrt(Sum / (X.Length - 1));
        }
    }
}