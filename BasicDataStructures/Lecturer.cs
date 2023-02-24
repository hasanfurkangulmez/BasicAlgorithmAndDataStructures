using System;
using System.Collections.Generic;

namespace BasicAlgorithmAndDataStructures.BasicDataStructures
{
    public class Lecturer //OgretimElemani
    {
        public int RegistrationNumber { get; set; }//Sicil No
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Gender { get; set; }

        public Lecturer()
        {

        }

        public Lecturer(int registrationNumber, string name, string surname, bool gender)
        {
            RegistrationNumber = registrationNumber;
            Name = name;
            Surname = surname;
            Gender = gender;
        }
        public override string ToString()
        {
            return $"{RegistrationNumber,-5} " +
    $"{Name,-10} " +
    $"{Surname,-10} " +
    string.Format("{0,-8}", Gender == true ? "Bay" : "Bayan");
        }
        public static void Run()
        {
            // Tanımlama - Atama
            var List1 = new List<Lecturer>()
                {
                    new Lecturer(100,"Ahmet","Yalçın",true),
                    new Lecturer(101,"Aylin","Dag",false),
                    new Lecturer(102,"Mehmet","Yıldız",true),
                    new Lecturer(103,"Servet","Aydogdu",true),
                    new Lecturer(104,"Leyla","Aydın",false),
                    new Lecturer(105,"Selim","Asilhan",true)
                };

         
            Console.WriteLine("List 1");
            List1.ForEach(ogr => Console.WriteLine(ogr));
            Console.WriteLine();

            var List2 = List1;

            Console.WriteLine("List 2");
            List2.ForEach(ogr => Console.WriteLine(ogr));
            Console.WriteLine();
         

            List2.Add(new Lecturer(106, "Öner", "Han", true));
            List1.RemoveAt(0);

            Console.ReadKey();

            Console.WriteLine("List 1");
            List1.ForEach(ogr => Console.WriteLine(ogr));
            Console.WriteLine();

            Console.WriteLine("List 2");
            List2.ForEach(ogr => Console.WriteLine(ogr));
            Console.WriteLine();
        }
    }
}