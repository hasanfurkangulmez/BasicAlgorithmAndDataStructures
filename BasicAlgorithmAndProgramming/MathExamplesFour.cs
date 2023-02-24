using System;

namespace BasicAlgorithmAndDataStructures.BasicAlgorithmAndProgramming
{
    internal class MathExamplesFour
    {
        public MathExamplesFour()
        {
            Console.Write($"Enter a number(First): ");
            int FirstNumber = int.Parse(Console.ReadLine());
            Console.Write($"Enter a number(Second): ");
            int SecondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("OBEB({0},{1})={2}\tOKEK({0},{1})={3}", FirstNumber, SecondNumber, OBEB(FirstNumber, SecondNumber), OKEK(FirstNumber, SecondNumber));
        }
        public static int OBEB(int n1, int n2)
        {
            int OBEB = 1, Divide = 2;
            while (n1 != 1 && n2 != 1)
            {
                for (int i = 2; i < (n1 > n2 ? n1 : n2); i++)
                {
                    if (n1 % Divide == 0 || n2 % Divide == 0)
                    {
                        if (n1 % Divide == 0 && n2 % Divide == 0) OBEB *= Divide;
                        if (n1 % Divide == 0) n1 /= Divide;
                        if (n2 % Divide == 0) n2 /= Divide;
                    }
                    else Divide++;
                }
            }
            return OBEB;
        }
        public static int OKEK(int n1, int n2)
        {
            int OKEK = 1, Divide = 2;
            while (n1 != 1 && n2 != 1)
            {
                for (int i = 0; i <= 100000; i++)//or n1*n2   /   (n1 > n2 ? n1 : n2)
                {
                    if (n1 % Divide == 0 || n2 % Divide == 0)
                    {
                        OKEK *= Divide;
                        if (n1 % Divide == 0) n1 /= Divide;
                        if (n2 % Divide == 0) n2 /= Divide;
                    }
                    else Divide++;
                }
            }
            return OKEK;
        }
    }
}