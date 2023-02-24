using System;

namespace BasicAlgorithmAndDataStructures.BasicAlgorithmAndProgramming
{
    internal class MathExamplesFive
    {
        public MathExamplesFive()
        {

        }
        public void BinaryToDecimal()
        {
            Console.Write("Enter a Binary Number : ");
            string BinaryNumber = Console.ReadLine();
            int[] Digit = new int[BinaryNumber.Length];
            bool Check = true;
            int DecimalNumber = 0;
            for (int i = 0; i < BinaryNumber.Length; i++)
            {
                if (!(BinaryNumber[i] == '0' || BinaryNumber[i] == '1'))
                {
                    Console.WriteLine("\aInsert failed.");
                    Check = false;
                    break;
                }
                Digit[i] = (int)(BinaryNumber[i] - '0');
            }
            if (Check)
            {
                for (int i = 0; i < BinaryNumber.Length; i++) DecimalNumber += (int)Math.Pow(2, BinaryNumber.Length - 1 - i) * Digit[i];
                Console.WriteLine($"\t{BinaryNumber,-10} binary numbers is equal to {DecimalNumber,-10} decimal numbers.");
            }
        }
        public void TheMultiplicationTable()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++) Console.WriteLine("{0,5} \tx {1,5} = {2,5}", i, j, i * j);
                Console.WriteLine("\n\n -------------------- \n\n");
            }
        }
        public void SumOfDigit()
        {
            Console.Write("Please! Enter a Number: ");
            int Number = int.Parse(Console.ReadLine());
            int Sum = 0, Digit = 0;
            while (Number > 0)
            {
                Digit = Number % 10;
                Sum += Digit;
                Number = Number / 10;
            }
            Console.WriteLine($"Sum of Digit is equal to {Sum}");
        }
        public int Factorial(int Number)
        {
            if (Number < 0) return -1;
            else if (Number == 0) return 1;
            else return Number * Factorial(Number - 1);
        }
    }
}