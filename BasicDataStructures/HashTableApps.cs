using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithmAndDataStructures.BasicDataStructures
{
    internal class HashTableApps{
        public HashTableApps()
        {
            HTCityExample();
        }

        private void HTCityExample(){
            Hashtable HTCity=new Hashtable(){
                {6, "ankara"},
                {34, "istanbul"},
                {35, "izmir"}
            };
            HTCity.Add(10, "balıkesir");

            foreach (DictionaryEntry item in HTCity)
            {
                Console.WriteLine($"{item.Key,-5} - {item.Value}");
            }

            var CKeys=HTCity.Keys;
            foreach (var item in CKeys)
            {
                Console.WriteLine(item);
            }

            ICollection CValue=HTCity.Values;
            foreach (var item in CValue)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("\nElemana erişme");
            Console.WriteLine(HTCity[34]);
            
            Console.WriteLine("\nEleman silme");
            HTCity.Remove(35);
            
            foreach (DictionaryEntry item in HTCity)
            {
                Console.WriteLine($"{item.Key,-5} " +
                    $"- {item.Value,-20}");
            }
        }

        private void LetterReplace(){
            Hashtable Letter=new Hashtable(){
                {'ü','u'},
                {'ö','o'},
                {'ı','i'},
                {'ğ','g'},
                {'ç','c'},
                {'ş','s'},
            };
            string Text2=Console.ReadLine();
            
            foreach (DictionaryEntry item in Letter)
            {
                Text2=Text2.Replace((char)item.Key, (char)item.Value);
            }

            Console.WriteLine(Text2);
        }
    }
}