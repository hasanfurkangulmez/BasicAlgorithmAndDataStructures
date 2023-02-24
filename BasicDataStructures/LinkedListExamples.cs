using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithmAndDataStructures.BasicDataStructures
{
    internal class LinkedListExamples
    {
        public LinkedListExamples()
        {
            Cities();
        }
        private static void Cities()
        {
            // LinkedList<T> Temelleri
            // Tanımlama
            LinkedList<string> cities = new LinkedList<string>();
            cities.AddFirst("Ordu");
            cities.AddFirst("Trabzon");
            cities.AddLast("İstanbul");

            cities.AddAfter(cities.Find("Ordu"), "Samsun");
            cities.AddBefore(cities.First.Next, "Giresun");
            cities.AddAfter(cities.Last.Previous, "Sinop");
            cities.AddAfter(cities.Find("Sinop"), "Zonguldak");

            Console.WriteLine();
            Console.WriteLine("Gidiş Güzergahı");
            Console.WriteLine();
            var eleman = cities.First;
            while (eleman != null)
            {
                Console.WriteLine(eleman.Value);
                eleman = eleman.Next;
            }

            Console.WriteLine();
            Console.WriteLine("Dönüş Güzergahı");
            Console.WriteLine();

            var gecici = cities.Last;
            while (gecici != null)
            {
                Console.WriteLine(gecici.Value);
                gecici = gecici.Previous;
            }

            Console.ReadKey();
        }
    }
}
