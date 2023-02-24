using System;
using System.Collections.Generic;

namespace BasicAlgorithmAndDataStructures.BasicAlgorithmAndProgramming
{
    internal class MathExamplesThree
    {
        public MathExamplesThree()
        {
            PrimeMultipliers(int.Parse(Console.ReadLine()));
        }
        public void PrimeNumber()
        {
            Console.Write("Enter a number: ");
            int EntryNumber = int.Parse(Console.ReadLine());
            if (EntryNumber <= 1) Console.WriteLine("The smallest prime number is " + EntryNumber);
            else
            {
                for (int i = 2; i < EntryNumber; i++)
                    if (EntryNumber % i == 0)
                    {
                        Console.WriteLine("This number is not a prime number!");
                        break;
                    }
                    else if (i == EntryNumber - 1) Console.WriteLine("This number is a Prime number!");
            }
        }
        public static void PrimeMultipliers(int n)
        {
            SortedSet<int> Multipliers = new SortedSet<int>();
            int i = 2, PrimeMultipliers_Sum = 0, PrimeMultipliers_Multiply = 1;
            while (n > 1)
            {
                if (n % i == 0)
                {
                    n /= i;
                    Multipliers.Add(i);
                }
                else i++;
            }
            List<int> Sum = new List<int>(Multipliers);
            Sum.ForEach(s => PrimeMultipliers_Sum += s);
            Sum.ForEach(s => PrimeMultipliers_Multiply *= s);
            Sum.ForEach(s => Console.Write($"{s}\t"));
            Console.WriteLine($"\nPrime Multipliers (Sum): {PrimeMultipliers_Sum}\tPrime Multipliers (Sum): {PrimeMultipliers_Multiply}");
        }
        public static int[] AsalCarpanlar(int n)//Copy
        {
            string carpanListesi = "";
            int i = 2;

            // asal carpanlari bulalım
            while (n > 1)
            {
                if (n % i == 0)
                {
                    n = n / i;
                    carpanListesi += i.ToString() + ",";
                }
                else i++;
            }

            carpanListesi = carpanListesi.Substring(0, carpanListesi.Length - 1);
            string[] carpanlar = carpanListesi.Split(",");

            string s = carpanlar[0];
            string y = s;

            for (i = 0; i < carpanlar.Length; i++)
            {
                if (!(s == carpanlar[i]))
                {
                    y = y + "," + carpanlar[i];
                    s = carpanlar[i];
                }
            }

            carpanlar = y.Split(',');
            int[] asalCarpanlar = new int[carpanlar.Length];
            for (i = 0; i < asalCarpanlar.Length; i++) asalCarpanlar[i] = Convert.ToInt32(carpanlar[i]);
            return asalCarpanlar;
        }
        public static int AsalCarpanlarinToplami(int n)//Copy
        {
            int[] asalCarpanlar = AsalCarpanlar(n);
            int t = 0;
            for (int i = 0; i < asalCarpanlar.Length; i++) t += asalCarpanlar[i];
            return t;
        }
        public static int AsalCarpanlarinCarpimi(int n)//Copy
        {
            int c = 1;
            int[] asalCarpanlar = AsalCarpanlar(n);
            for (int i = 0; i < asalCarpanlar.Length; i++) c *= asalCarpanlar[i];
            return c;
        }
    }
}