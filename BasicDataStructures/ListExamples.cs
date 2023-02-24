using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithmAndDataStructures.BasicDataStructures
{
    internal class ListExamples
    {
        public ListExamples()
        {
            CityApps();
        }

        private void ListExamplesOne()
        {
            List<string> cities = new List<string>()
            {
                "İstanbul",
                "Ankara",
                "İzmir"
            };
            cities.ForEach(c => Console.WriteLine(c));
            var citiesTwo = cities;
            citiesTwo.ForEach(citiesTwo => Console.WriteLine(citiesTwo));
            citiesTwo.Remove("Ankara");
            cities.ForEach(c => Console.WriteLine(c));
            cities.Add("Ankara");
            citiesTwo.ForEach(citiesTwo => Console.WriteLine(citiesTwo));
        }

        #region CityApps
        /// <summary>
        /// List the city and add city
        /// </summary>
        public static void CityApps()
        {
            // Sehir Listesi
            var Cities = new List<City>()
            {
                new City(6,"Ankara"),
                new City(34,"İstanbul"),
                new City(55,"Samsun"),
                new City(23,"Elazığ"),
                new City(44,"Malatya")
            };

            Cities.Sort();
            Cities.ForEach(s => Console.WriteLine(s));
        }
        #endregion
    }
    /// <summary>
    /// Examples, Data type of cities.
    /// </summary>
    public class City : IComparable<City>
    {
        public int PlateNumber { get; set; }
        public string CityName { get; set; }

        public City(int plateNumber, string cityName)
        {
            PlateNumber = plateNumber;
            CityName = cityName;
        }
        public override string ToString()
        {
            return $"{PlateNumber,-5} {CityName,-15}";
        }

        public int CompareTo(City other)
        {
            if (this.PlateNumber < other.PlateNumber)
            {
                return -1;
            }
            else if (this.PlateNumber == other.PlateNumber)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}