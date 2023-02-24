using System;
using System.Linq;

namespace BasicAlgorithmAndDataStructures.BasicAlgorithmAndProgramming
{
    internal class VariableExamples
    {
        public VariableExamples()
        {
            EnumPrograms();
        }
        enum Programs { FruitExample, SplitText, SplitText_Trying, TextVowelsPiece }
        public void EnumPrograms()
        {
            for (int i = 0; i < 9; i++) Console.WriteLine($"{i,2}. {(Programs)i}");
            Console.Write("Please! Make a Choice: ");
            Programs EnumProgs = (Programs)int.Parse(Console.ReadLine());
            switch (EnumProgs)
            {
                case Programs.FruitExample: FruitExample(); break;
                case Programs.SplitText: SplitText(); break;
                case Programs.SplitText_Trying: SplitText_Trying(); break;
                case Programs.TextVowelsPiece: TextVowelsPiece(); break;
                default: Console.WriteLine("Incorrect Entry!"); break;
            }
        }
        public void FruitExample()
        {
            string[] Fruits = { "elma", "armut", "muz", "üzüm", "seftali" };
            var Fruit = from m in Fruits where m[0] == 'a' select m;
            foreach (string m in Fruit) Console.Write(m);
        }
        public void SplitText()
        {
            Console.Write("Enter a text : ");
            string splitText = Console.ReadLine();
            string[] SplittingText = splitText.Split(',');
            int n = SplittingText.Length;
            int[] NumericArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                NumericArray[i] = Convert.ToInt32(SplittingText[i].Length);
                Console.WriteLine("dizi[{0}] = {1}", i, NumericArray[i]);
            }
        }
        public void SplitText_Trying()//Copy
        {
            // konsoldan girilen değerin okunması 
            string ifade = Console.ReadLine();
            // ifadenin , karakterine bağlı olarak ayrıştırılması 
            string[] bolunmusIfade = ifade.Split(',');
            foreach (var item in bolunmusIfade) Console.WriteLine(item);
            // döngü ve sayısal dizi için dizi uzunluğunun tespit edilmesi
            int n = bolunmusIfade.Length;
            // sayısal dizinin deklare edilmesi 
            int[] sayisalDizi = new int[n];
            // ayrıştırma için döngü tasarımı
            for (int i = 0; i < n; i++)
            {
                sayisalDizi[i] = Convert.ToInt32(bolunmusIfade[i]);
                Console.WriteLine("dizi[{0}] = {1}", i + 1, sayisalDizi[i]);
            }
        }
        public void TextVowelsPiece()
        {
            Console.Write("Enter a text : ");
            string Text = Console.ReadLine();
            char[] VowelsArray = { 'A', 'E', 'I', 'İ', 'U', 'Ü', 'O', 'Ö', 'a', 'e', 'ı', 'i', 'u', 'ü', 'o', 'ö' };
            int VowelsPiece = 0;
            for (int i = 0; i < Text.Length; i++) for (int j = 0; j < VowelsArray.Length; j++) VowelsPiece = (Text[i] == VowelsArray[j]) ? VowelsPiece + 1 : VowelsPiece;
            Console.WriteLine($"\"{Text}\" ifadesinde {VowelsPiece} adet sesli harf tespit edildi.");
        }
    }
}