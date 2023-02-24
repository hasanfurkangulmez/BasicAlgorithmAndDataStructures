using System;
using System.Collections;

namespace BasicAlgorithmAndDataStructures.BasicDataStructures
{
    public class SortedListApps
    {
        public SortedListApps()
        {
            Basics();
        }
        public void Basics()
        {
            SortedList SList = new SortedList(){
                {1,"One"},
                {2,"Two"},
                {3,"Three"},
                {8,"Eight"},
                {5,"Five"},
                {6,"Six"}
            };
            SList.Add(4, "Four");
            foreach (DictionaryEntry item in SList)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            Console.WriteLine("Number of elements in the list  : {0}", SList.Count);
            Console.WriteLine("Capacity of list     : {0}", SList.Capacity);
            SList.TrimToSize();
            Console.WriteLine("Capacity of list     : {0}", SList.Capacity);

            //Will continue tomorrow
            Console.WriteLine(SList[4]);
            Console.WriteLine(SList.GetByIndex(0));
            Console.WriteLine(SList.GetKey(0));
            Console.WriteLine(SList.GetByIndex(SList.Count-1));
            
            var Keys=SList.Keys;
            Console.WriteLine("\nKEYS");
            foreach (var item in Keys)
                Console.WriteLine(item);
            var Values=SList.Values;
            Console.WriteLine("\nVALUES");
            foreach (var item in Values)
                Console.WriteLine(item);
            Console.WriteLine("\nUpdating");
            if (SList.ContainsKey(1))
                SList[1]="Bir";
            foreach (DictionaryEntry item in SList)
                Console.WriteLine($"{item.Key} - {item.Value}");
        }
        public void BookContentExample()
        {
            SortedList BookContent = new SortedList();
            BookContent.Add(1, "Önsöz");
            BookContent.Add(50, "Değişkenler");
            BookContent.Add(40, "Operatörler");
            BookContent.Add(60, "Döngüler");
            BookContent.Add(45, "İlişkisel Operatörler");

            Console.WriteLine("İçindekiler");
            Console.WriteLine(new string('-', 25));

            Console.WriteLine($"{"Konular",33} {"Sayfalar",8}");
            foreach (DictionaryEntry item in BookContent)
            {
                Console.WriteLine($"{item.Value,-33} {item.Key,8}");
            }
        }
    }
}