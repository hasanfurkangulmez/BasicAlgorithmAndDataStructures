using System;
using System.Collections;
using System.Text;

namespace BasicAlgorithmAndDataStructures.BasicDataStructures
{
    internal class ArrayExamples
    {
        public void ArrayExamples1()
        {
            // Array | Dizi | Tanimlama
            int[] sayilar = new int[] { 5, 3, 8, 10, 2, 18, 23, 44, 55, 6, 34, 19 };
            var numbers = Array.CreateInstance(typeof(int), sayilar.Length);
            var arr = new ArrayList(sayilar);

            sayilar.CopyTo(numbers, 0);
            Array.Sort(sayilar);
            Array.Sort(numbers);
            Array.Clear(sayilar, 2, 2);
            Console.WriteLine(Array.IndexOf(sayilar, 55));
            arr.Sort();

            // Dolaşma
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"sayilar[{i}] = " +
                    $"{sayilar[i],3} - " +
                    $"numbers[{i}] = " +
                    $"{numbers.GetValue(i),3} " +
                    $"arr[{i}] = " +
                    $"{arr[i],3}");
            }
        }
    }
}
