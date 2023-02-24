using System;

namespace BasicAlgorithmAndDataStructures.BasicAlgorithmAndProgramming
{
    internal class BuiltInDataTypes
    {
        public BuiltInDataTypes()
        {
            string[] Types = { "SByte", "Byte", "Int16", "UInt16", "Int32", "Double" };
            Console.WriteLine($"{new string('-', 50)}\n\tBuilt-In Data Types\n{new string('-', 50)}");
            for (int i = 0; i < Types.Length; i++) Console.WriteLine($"{Array.IndexOf(Types, Types[i])}. {Types[i]}");
            Console.Write($"\t{new string('-', 25)}\n\tEnter Your Selection : ");
            int SelectTypes = int.Parse(Console.ReadLine());
            switch (Types[SelectTypes])
            {
                case "SByte": BuiltInSByte(); break;
                case "Byte": BuiltInByte(); break;
                case "Int16": BuiltInInt16(); break;
                case "UInt16": BuiltInUInt16(); break;
                case "Int32": BuiltInInt32(); break;
                case "Double": BuiltInDouble(); break;
                default: Console.WriteLine("Wrong Choose!"); break;
            }
        }
        private void BuiltInSByte()
        {
            Console.WriteLine($"\t{new string('-', 25)}\n" +
                $"Name            : {nameof(SByte),25}\n" +
                $"Min Value       : {SByte.MinValue,25}\n" +
                $"Max Value       : {SByte.MaxValue,25}\n" +
                $"Size(Byte)      : {sizeof(SByte),25}\n" +
                $"{new string('-', 50)}\n");
        }
        private void BuiltInByte()
        {
            Console.WriteLine($"\t{new string('-', 25)}" +
                $"Name            : {nameof(Byte),25}\n" +
                $"Min Value       : {Byte.MinValue,25}\n" +
                $"Max Value       : {Byte.MaxValue,25}\n" +
                $"Size(Byte)      : {sizeof(Byte),25}\n" +
                $"{new string('-', 50)}\n");
        }
        private void BuiltInInt16()
        {
            Console.WriteLine($"\t{new string('-', 25)}\n" +
                $"Name            : {nameof(Int16),25}\n" +
                $"Min Value       : {Int16.MinValue,25}\n" +
                $"Max Value       : {Int16.MaxValue,25}\n" +
                $"Size(Byte)      : {sizeof(Int16),25}\n" +
                $"{new string('-', 50)}\n");
        }
        private void BuiltInUInt16()
        {
            Console.WriteLine($"\t{new string('-', 25)}\n" +
                $"Name            : {nameof(UInt16),25}\n" +
                $"Min Value       : {UInt16.MinValue,25}\n" +
                $"Max Value       : {UInt16.MaxValue,25}\n" +
                $"Size(Byte)      : {sizeof(UInt16),25}\n" +
                $"{new string('-', 50)}\n");
        }
        private void BuiltInInt32()
        {
            Console.WriteLine($"\t{new string('-', 25)}\n" +
                $"Name            : {nameof(Int32),25}\n" +
                $"Min Value       : {Int32.MinValue,25}\n" +
                $"Max Value       : {Int32.MaxValue,25}\n" +
                $"Size(Byte)      : {sizeof(Int32),25}\n" +
                $"{new string('-', 50)}\n");
        }
        private void BuiltInDouble()
        {
            Console.WriteLine($"\t{new string('-', 25)}\n" +
                $"Name            : {nameof(Double),25}\n" +
                $"Min Value       : {Double.MinValue,25}\n" +
                $"Max Value       : {Double.MaxValue,25}\n" +
                $"Size(Byte)      : {sizeof(Double),25}\n" +
                $"{new string('-', 50)}\n");
        }
        ~BuiltInDataTypes()
        {
            Console.WriteLine($"Program has been terminated.");
        }
    }
}
