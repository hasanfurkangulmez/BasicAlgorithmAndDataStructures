using System;
using System.Collections;
using System.Collections.Generic;

namespace BasicAlgorithmAndDataStructures.BasicDataStructures
{
    public struct StructStudentApps
    {
        public StructStudentApps(int number, string name, string surname, bool gender = true)
        {
            Number = number;
            Name = name;
            Surname = surname;
            Gender = gender;
        }

        public int Number { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Gender { get; set; }

        public override string ToString()
        {
            return $"{Number,-5} {Name,-10} {Surname,-10} {string.Format("{0,-8}", Gender == true ? "Male" : "Female")}";
        }

        public static void Run()
        {
            List<StructStudentApps> StudentList=new List<StructStudentApps>(){
                new StructStudentApps(10,"Ahmet","Yılmaz"),
                new StructStudentApps(20, "Fatma", "Dag", false),
                new StructStudentApps(30, "Mehmet", "Avşar", true),
                new StructStudentApps(40, "Asaf", "Karlıdağ")
            };

            StudentList.ForEach(o => Console.WriteLine(o));
            Console.ReadKey();
        }

    }
}