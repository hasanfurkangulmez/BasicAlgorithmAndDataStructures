using System;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Concurrent;
using System.Text;

namespace BasicAlgorithmAndDataStructures.AlgorithmDesignsRemainders.CollectionApps
{
    public class CollectionApp
    {
        private static bool ContainsZ(string obj)
        {
            return obj.Contains("Z");
        }

        private static void ProcessItems<T>(IList coll)
        {
            Console.WriteLine(
                "Is readonly returns {0} for this collection.",
                coll.IsReadOnly);

            foreach (T item in coll)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();
        }

        static void Yazdir(Array d)
        {
            Console.WriteLine(d.GetValue(0));
        }

        internal class MyCollection : IEnumerable
        {
            int[] data = { 1, 2, 3 };

            public IEnumerator GetEnumerator()
            {
                foreach (int i in data)
                    yield return i;
            }
        }

        internal class MyGenCollection : IEnumerable<int>
        {
            int[] data = { 1, 2, 3 };
            public IEnumerator<int> GetEnumerator()
            {
                foreach (int i in data)
                    yield return i;
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        /// <summary>
        /// Bu kod bloğunu çalıştırmak için Main() fonksiyonu içerisine
        /// AnaKod(); yazmalısınız. 
        /// </summary>
        static void AnaKod()
        {
            string s = "Merhaba";
            IEnumerator rator = s.GetEnumerator();
            while (rator.MoveNext())
            {
                char c = (char)rator.Current;
                Console.Write(c + ".");
            }
            // M.e.r.h.a.b.a.
            Console.WriteLine();
            foreach (char c in s)
            {
                Console.Write(c + ".");
            }
        }

        static void AnaKod_Array()
        {
            Array dizi = Array.CreateInstance(typeof(Int32), 3);
            dizi.SetValue(23, 0);
            dizi.SetValue(44, 1);
            dizi.SetValue(55, 2);

            for (int i = 0; i < dizi.Length; i++)
                Console.WriteLine(dizi.GetValue(i));
        }

        static void AnaKod_Array2()
        {
            Array d1 = Array.CreateInstance(typeof(String), 2);
            // int[] d = new int[2];
            Array d2 = Array.CreateInstance(typeof(Int32), 3);
            Array d3 = Array.CreateInstance(typeof(Double), 4);

            d1.SetValue("Merhaba", 0);
            d2.SetValue(23, 0);
            d3.SetValue(5.0, 0);

            Yazdir(d1);
            Yazdir(d2);
            Yazdir(d3);
        }

        static void AnaKod_Array3()
        {
            int[] arr = { 0, 1, 2, 4, 5 };
            List<int> list = new List<int>();

            string[] names = { "Ali", "Merve", "Sefa" };

            for (int x = 5; x < 10; x++)
            {
                list.Add(x);
            }

            ProcessItems<int>(arr);
            ProcessItems<int>(list);
            ProcessItems<string>(names);
        }

        static void ArraySearch()
        {
            // array search
            string[] names = { "Zafer", "Can", "Filiz", "Öner" };

            string m1 = Array.Find(names, ContainsZ);

            string m2 = Array.Find(names, delegate (string name)
            {
                return name.Contains("Z");
            });

            string m3 = Array.Find(names, n => n.Contains("Z"));
        }
    }
}
