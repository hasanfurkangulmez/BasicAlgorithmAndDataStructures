using System;
using System.Collections.Generic;

namespace BasicAlgorithmAndDataStructures.BasicDataStructures
{
    public class MathematicalClass
    {
        /*MathematicalClass deneme= new MathematicalClass();
            deneme.ElementAdd(new int[]{25,22});
            deneme.Print();
            Console.WriteLine(deneme.ArithmeticAverage());*/
        public List<int> Seri { get; set; }
        public MathematicalClass(params int[] Numbers)
        {
            Seri = new List<int>();
            ElementAdd(Numbers);
            /*
            Seri = new List<int>();
            foreach (var Number in Numbers)
            {
                ElementAdd(Number);
            }*/
        }
        public void ElementAdd(int Number)
        {
            Seri.Add(Number);
        }
        public void ElementAdd(int[] Numbers)
        {
            Seri.AddRange(Numbers);
        }
        public void Print()
        {
            Console.WriteLine();
            if (Seri != null)
                Seri.ForEach(s => Console.Write("{0,5}", s));
            else
                Console.WriteLine("\aSeri empty!");
            Console.WriteLine();
        }
        public int BiggestValueBring()
        {
            int Biggest = int.MinValue;
            foreach (var Number in Seri)
                Biggest = Math.Max(Biggest, Number);
            return Biggest;
        }
        public int SmallestValueBring()
        {
            int Smallest = int.MaxValue;
            foreach (var Number in Seri)
                Smallest = Math.Min(Smallest, Number);
            return Smallest;
        }
        public int SumBring()
        {
            int Sum = 0;
            foreach (var Number in Seri)
                Sum += Number;
            return Sum;
        }
        public int OddNumber()
        {
            int Sum = 0;
            for (int i = 0; i < Seri.Count; i++)
            {
                if (Seri[i] % 2 == 1)
                    Sum += Seri[i];
            }
            return Sum;
        }
        public int EvenNumber()
        {
            int Sum = 0;
            for (int i = 0; i < Seri.Count; i++)
            {
                if (Seri[i] % 2 == 0)
                    Sum += Seri[i];
            }
            return Sum;
        }
        public double ArithmeticAverage()
        {
            return (double)SumBring() / Seri.Count;
        }
    }
}