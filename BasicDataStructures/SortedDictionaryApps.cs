using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithmAndDataStructures.BasicDataStructures
{
    internal class SortedDictionaryApps
    {
        public SortedDictionaryApps()
        {
            SDBookExample();
        }

        private void SDBookExample()
        {//SortedSet yerine List<int> kullanılabilir.
            SortedDictionary<string, SortedSet<int>> BookIndex = new SortedDictionary<string, SortedSet<int>>()
            {
                {"HTML", new SortedSet<int>(){8,10,12}},
                {"CSS", new SortedSet<int>(){70,98,90}},
                {"jQuery", new SortedSet<int>(){3,5,15}},
                {"SQL", new SortedSet<int>{70,80}}
            };
            BookIndex.Add("FTP", new SortedSet<int>() { 3, 5, 7 });
            BookIndex.Add("ASP.NET", new SortedSet<int>() { 50, 60 });
            foreach (var concept in BookIndex)
            {
                System.Console.WriteLine(concept.Key);
                foreach (var a in concept.Value)
                {
                    System.Console.WriteLine("\t >" + a);
                }
            }
        }
        private void SDBookExampleTwo()//List kullanılarak yapılan örnek
        {
            SortedDictionary<string, List<int>> BookIndex = new SortedDictionary<string, List<int>>()
            {
                {"HTML", new List<int>(){8,10,12}},
                {"CSS", new List<int>(){70,80,90}},
                {"jQuery", new List<int>(){3,5,15}},
                {"SQL", new List<int>{70,80}}
            };
            BookIndex.Add("FTP", new List<int>() { 3, 5, 7 });
            BookIndex.Add("ASP.NET", new List<int>() { 50, 60 });
            foreach (var concept in BookIndex)
            {
                System.Console.WriteLine(concept.Key);
                concept.Value.ForEach(a => Console.WriteLine("\t >" + a));
            }
        }
    }
}