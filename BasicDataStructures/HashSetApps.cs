using System;
using System.Collections;
using System.Collections.Generic;

namespace BasicAlgorithmAndDataStructures.BasicDataStructures
{
    public class HashSetApps
    {
        public HashSetApps()
        {
            
        }

        private void HSAlphabetExamples(){
            HashSet<char> Vowels = new HashSet<char>(){
                'e','ı','i','u','ü','o','ö','b'
            };
            Vowels.Add('a');
            Vowels.Remove('b');
            CollectionPrint(Vowels);
            
            var Alphabet=new List<char>();
            for (int i = 97; i < 123; i++)
            {
                Alphabet.Add((char)i);
            }
            CollectionPrint(Alphabet);

            //Vowels.ExceptWith(Alphabet);
            Vowels.UnionWith(Alphabet);
            //Vowels.IntersectWith(Alphabet);
            //Vowels.SymmetricExceptWith(Alphabet);
            CollectionPrint(Vowels);
        }
        private void CollectionPrint(IEnumerable Collection){
            Console.WriteLine();
            int i = 0;
            foreach (char k in Collection)
            {
                Console.Write($"{k,5}");
                i++;
            }
            Console.WriteLine();
            Console.WriteLine("Number of Elements : {0}", i);
            Console.WriteLine();
        }
    }
}