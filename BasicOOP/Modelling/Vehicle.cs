using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithmAndDataStructures.BasicOOP.Modelling
{
    public class Vehicle : Tool
    {
        #region Field Variabls
        private string brand, model, colour;
        private int year;
        #endregion
        #region Properties
        public string Brand { get => brand; set => brand = value; }
        public string Model { get => model; set => model = value; }
        public string Colour { get => colour; set => colour = value; }
        public int Year { get => year; set => year = value; }
        #endregion
        #region Constructors
        public Vehicle()
        {

        }
        public Vehicle(string brand, string model, string colour, int year)
        {
            Brand = brand;
            Model = model;
            Colour = colour;
            Year = year;
        }
        #endregion
        #region Methods
        public void Execute() =>
            Console.WriteLine($"The tool worked.");
        public void Stop() =>
            Console.WriteLine($"Vehicle stopped.");

        public override string ToString()
        {
            Console.WriteLine(
                new string('-', 30) +
                $"\nBrand:  {this.Brand}" +
                $"\nModel:  {Model}" +
                $"\nColor:  {Colour}" +
                $"\nYear:   {Year}" +
                $"\nEngine: {Engine}" +
                $"\nVolume: {Volume}" +
                $"\n{new string('-', 30)}");
            return Brand + " " + Model;
        }
        #endregion

    }
}
