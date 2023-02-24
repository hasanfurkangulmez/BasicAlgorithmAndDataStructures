using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithmAndDataStructures.BasicDataStructures
{
    internal class DictionaryApps
    {
        public DictionaryApps()
        {
            UserDataTypeDictionaryExample();
        }

        public void UserDataTypeDictionaryExample()
        {
            Dictionary<int, Personel> PersonelList = new Dictionary<int, Personel>()
            {
                {110, new Personel("Mehmet", "Sonsoz", 7500)},
                {120, new Personel("Ahmet", "Can", 9000)}
            };

            PersonelList.Add(100, new Personel("Zeynep", "Coskun",5000));
            foreach (var item in PersonelList)
            {
                System.Console.WriteLine(item);
            }
        }

        private void BasicDictionaryExample()
        {
            Dictionary<int, string> PhoneCodes = new Dictionary<int, string>(){
                {332, "Konya"},
                {424, "Elazığ"},
                {466, "Art"},
                {422, "Malatya"}
            };

            PhoneCodes.Add(322, "Adana");
            PhoneCodes.Add(212, "İstanbul");
            PhoneCodes.Add(216, "İstanbul");

            PhoneCodes[466] = "Artvin";

            if (!PhoneCodes.ContainsKey(312))
            {
                PhoneCodes.Add(312, "Ankara");
            }

            if (!PhoneCodes.ContainsValue("Malatya"))
            {
                PhoneCodes.Add(422, "Malatya");
            }

            PhoneCodes.Remove(322);
            foreach (var item in PhoneCodes)
            {
                Console.WriteLine(item);
            }
        }
    }
}
namespace BasicAlgorithmAndDataStructures.BasicDataStructures
{
    public class Personel
    {
        public Personel(string adi, string soyadi, decimal maas)
        {
            Adi = adi;
            Soyadi = soyadi;
            Maas = maas;
        }
        public int SicilNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public decimal Maas { get; set; }

        public override string ToString()
        {
            return $"{Adi,-10} {Soyadi,-15} {Maas,-10}";
        }
    }
}