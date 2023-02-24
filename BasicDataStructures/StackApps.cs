using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicAlgorithmAndDataStructures.BasicDataStructures
{
    internal class StackApps
    {
        public StackApps()
        {
            StactStepExample();
        }
        public static void StactStepExample()
        {
            Console.Write("Please enter a number : ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            var sayiYigini = new Stack<int>();

            while (sayi > 0)
            {
                int k = sayi % 10;
                sayiYigini.Push(k);
                sayi = sayi / 10;
            }

            int i = 0;
            int n = sayiYigini.Count - 1;
            foreach (var s in sayiYigini)
            {
                Console.WriteLine($"\t{s,7} x " +
                    $"{Math.Pow(10, n - i),7}\t = " +
                    $"{s * Math.Pow(10, n - i),7}");
                i++;
            }
        }
        private void StackExample()
        {
            Stack<char> CharStack = new Stack<char>();

            for (int i = 0; i < 5; i++)
            {
                CharStack.Push((char)(new Random().Next(65, 90)));
                Console.WriteLine(CharStack.Peek() + " added");
            }

            string[] Options = { "Push", "Peek", "Pop", "Clear", "Count" };
            for (int i = 0; i < Options.Length; i++)
                Console.WriteLine($"{Array.IndexOf(Options, Options[i])}. {Options[i]}");

            Console.Write($"\tEnter Your Selection : ");
            int SelectOption = int.Parse(Console.ReadLine());

            switch (Options[SelectOption])
            {
                case "Push":
                    Console.Write($"\tEnter Your Piece : ");
                    for (int i = 0; i < 5; i++)
                    {
                        CharStack.Push((char)(new Random().Next(65, 90)));
                        Console.WriteLine(CharStack.Peek() + " added");
                    }
                    break;
                case "Peek":
                    Console.WriteLine(CharStack.Peek());
                    break;
                case "Pop":
                    Console.WriteLine(CharStack.Pop() + " deleted!");
                    Console.WriteLine(CharStack.Peek());
                    break;
                case "Clear":
                    CharStack.Clear();
                    Console.WriteLine("Cleaned!");
                    break;
                case "Count":
                    Console.WriteLine(CharStack.Count());
                    break;
                default:
                    break;
            }
        }
    }
}
