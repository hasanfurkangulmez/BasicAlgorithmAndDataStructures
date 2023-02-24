using System;
using System.Collections;
using System.Text;

namespace BasicAlgorithmAndDataStructures.BasicDataStructures
{
    internal class ArrayListExamples
    {
        public ArrayListExamples()
        {
            AListMethod();
        }

        private static void AListMethod()
        {
            ArrayList arrayList = new ArrayList()
            {
                10
            };
            arrayList.Add("Examples"); //boxing
            arrayList.Add(true);
            arrayList.Add('e');

            foreach (var e in arrayList)
                Console.Write($"{e} ");

            int[] numbers = new int[] { 23, 44, 55 };
            arrayList.AddRange(numbers);

            Console.WriteLine();

            foreach (var e in arrayList)
                Console.Write($"{e} ");

            Console.WriteLine();

            Console.WriteLine(arrayList[4].ToString());

            var x = (int)arrayList[0]; // unboxing
            Console.WriteLine((int)x + 10);

            arrayList.Remove(10);
            arrayList.RemoveAt(1);
            arrayList.RemoveRange(3, 2);

            foreach (var e in arrayList)
            {
                Console.Write($"{e} ");
            }
        }

    }
}
