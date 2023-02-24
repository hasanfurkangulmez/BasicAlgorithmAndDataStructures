using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithmAndDataStructures.BasicOOP
{
    public class Person
    {
        public Person()
        {

        }
        public Person(string name)
        {
            Name= name;
        }
        public Person(string name, int age)
        {
            Name= name;
            Age= age;
        }
        //public string Name { get; set; }
        private string _name;
        public string Name { get => _name; set => _name = value; }
        public int Age { get; set; }
    }
}