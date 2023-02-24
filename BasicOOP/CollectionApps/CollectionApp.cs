using System;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Concurrent;
using System.Text;

namespace BasicAlgorithmAndDataStructures.BasicOOP.CollectionApps
{
    public class CollectionApp
    {
        public CollectionApp()
        {
            ArrayAppOne();
        }
        public void CollectionAppOne()
        {
            string s = "Hello";
            IEnumerator rator = s.GetEnumerator();
            while (rator.MoveNext())
            {
                char c = (char)rator.Current;
                Console.Write(c + ".");
            }
            // H.e.l.l.o
            Console.WriteLine();
            foreach (char c in s)
            {
                Console.Write(c + ".");
            }
            Console.WriteLine();
        }

        internal class MyCollection : IEnumerable
        {
            int[] Data = { 1, 2, 3 };

            public IEnumerator GetEnumerator()
            {
                foreach (int i in Data)
                    yield return i;
            }
        }

        internal class MyGenColleciton : IEnumerable<int>
        {
            int[] Data = { 1, 2, 3 };
            public IEnumerator<int> GetEnumerator()
            {
                foreach (int i in Data)
                    yield return i;
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        public void ArrayApp()
        {
            Array array = Array.CreateInstance(typeof(Int32), 3);
            array.SetValue(23, 0);
            array.SetValue(44, 1);
            array.SetValue(55, 2);
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array.GetValue(i));
        }

        public void ArrayAppOne()
        {
            int[] arr = { 0, 1, 2, 4, 5 };
            List<int> list = new List<int>();
            string[] names = { "Ali", "Merve", "Sefa" };
            for (int i = 5; i < 10; i++)
            {
                list.Add(i);
            }
            ProcessItems<int>(arr);
            ProcessItems<int>(list);
            ProcessItems<string>(names);
        }

        private static void ProcessItems<T>(IList coll)
        {
            Console.WriteLine("Is readonly returns {0} for this collection.", coll.IsReadOnly);
            foreach (T item in coll)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();
        }
    }
}
