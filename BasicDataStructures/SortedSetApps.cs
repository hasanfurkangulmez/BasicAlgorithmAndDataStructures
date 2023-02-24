using System;
using System.Collections;
using System.Collections.Generic;

namespace BasicAlgorithmAndDataStructures.BasicDataStructures
{
    internal class SortedSetApps
    {
        public SortedSetApps()
        {
            SortedSetClusterApps();
        }
        public static void SortedSetClusterApps()
        {
            // SortedSet Küme işlemeri 
            // var A = new SortedSet<int>() { 1, 2, 3, 4 };
            var A = new SortedSet<int>(RandomNumberProduce(10000));
            // var B = new SortedSet<int>() { 1, 2, 5, 6 };
            var B = new SortedSet<int>(RandomNumberProduce(10000));

            #region Print
            Console.WriteLine();
            Console.WriteLine("A Cluster");
            foreach (int s in A)
                Console.Write($"{s,5}");
            
            Console.WriteLine();
            Console.WriteLine("B Cluster");
            foreach (int s in B)
                Console.Write($"{s,5}");
            #endregion

            // Union
            // A.UnionWith(B);
            // A.IntersectWith(B);
            // A.ExceptWith(B);
            A.SymmetricExceptWith(B);
            Console.WriteLine("\n\n Elements of SymmetricExceptWith");
            foreach (var s in A)
                Console.Write($"{s,5}");
            Console.WriteLine("\n\nTotal Number : {0}", A.Count);
        }
        public void SortedSetExample()
        {
            SortedSet<string> SSList = new SortedSet<string>();
            if (SSList.Add("Mehmet"))
                Console.WriteLine("Mehmet added.");
            else
                Console.WriteLine("Insert failed.");
            Console.WriteLine($"{(SSList.Add("Ahmet") == true ? "Ahmet Added." : "InsertFailed")}");

            SSList.Add("Sule");
            SSList.Add("Neslihan");
            SSList.Add("Fahrettin");
            SSList.Add("Fatih");

            SSList.Remove("Sule");
            SSList.RemoveWhere(deger => deger.StartsWith("F"));

            Console.WriteLine("\nList of Names");
            foreach (string i in SSList)
                Console.WriteLine(i);
            Console.WriteLine($"Element Piece\t:{SSList.Count,5}");
        }
        public void UniqueNumbers()
        {
            var Numbers = new List<int>();
            var r = new Random();
            Console.WriteLine();
            Numbers.AddRange(RandomNumberProduce(int.Parse(Console.ReadLine())));
            Console.WriteLine("\nList of Numbers");
            Numbers.ForEach(N => Console.Write($"{N,-10}"));
            SortedSet<int> UniqueNumbersList = new SortedSet<int>(Numbers);
            Console.WriteLine();
            Console.WriteLine("\nList of Unique Numbers");
            foreach (int Number in UniqueNumbersList)
                Console.Write($"{Number,-10}");
            Console.WriteLine();
            Console.WriteLine($"\nThere are/is {UniqueNumbersList.Count} unique numbers.");
        }
        public static List<int> RandomNumberProduce(int n)
        {
            var ListExam = new List<int>();
            var r = new Random();
            for (int i = 0; i < n; i++)
                ListExam.Add(r.Next(0, 1000));
            return ListExam;
        }
    }
}