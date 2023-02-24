using System;
using BasicAlgorithmAndDataStructures.BasicDataStructures;
using BasicAlgorithmAndDataStructures.BasicAlgorithmAndProgramming;
using BasicAlgorithmAndDataStructures.BasicMatrixApps;
using BasicAlgorithmAndDataStructures.BasicFileApps;
using BasicAlgorithmAndDataStructures.BasicOOP;
using BasicAlgorithmAndDataStructures.BasicOOP.Modelling;
//using BasicAlgorithmAndDataStructures.BasicOOP.Drawing;
using BasicAlgorithmAndDataStructures.BasicOOP.DrawingAbstract;
using System.Collections.Generic;
using BasicAlgorithmAndDataStructures.BasicOOP.Bank;
using System.Collections;
using System.Security.Cryptography.X509Certificates;
using BasicAlgorithmAndDataStructures.BasicOOP.CollectionApps;

namespace BasicAlgorithmAndDataStructures
{
    internal class Program
    {
        public static void ShapeDraw(Shape Shape) => Shape.Draw();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Algorithm and Data Structures\n" + new string('-', 100));
            /*Person P = new Person("Ahmet", 18);
            Console.WriteLine(P.Name + " : " + P.Age);
            Person P1 = new Person("Mehmet");
            Console.WriteLine(P1.Name + " : " + P1.Age);
            Person P2 = new Person();
            Console.WriteLine(P2.Name + " : " + P2.Age);*/
            /*string asdf = "Hello Cute World.";
            Console.WriteLine($"{asdf.WordNumber()}");*/
            /*Vehicle MyVehicle = new Vehicle("Skoda", "SuperB", "Gray", 2020);
            MyVehicle.Year = 2022;
            MyVehicle.Engine = Engine.Diesel.ToString();
            MyVehicle.Volume = 1.6;
            Console.WriteLine($"{MyVehicle.Brand}\n{MyVehicle.Model}\n{MyVehicle.Colour}\n{MyVehicle.Year}");
            Console.WriteLine($"{MyVehicle.Engine}\n{MyVehicle.Volume}");
            MyVehicle.Clear();*/
            /*Vehicle MyVehicle = new Vehicle();
            MyVehicle.Brand = "Skoda";
            MyVehicle.Model = "Superb";
            MyVehicle.Colour = Colour.Gray.ToString();
            MyVehicle.Year = 2022;
            MyVehicle.Engine = Engine.Diesel.ToString();
            MyVehicle.Volume = 1.6;
            Vehicle YourVehicle = new Vehicle
            {
                Brand = "Skoda",
                Model = "Octavia",
                Colour = Colour.White.ToString(),
                Year = 2023,
                Engine = Engine.Gasoline.ToString(),
                Volume = 1.5
            };
            MyVehicle.ToString();
            YourVehicle.ToString();
            MyVehicle.Clear();*/
            /*List<Vehicle> Fleet = new List<Vehicle>();
            Fleet.Add(new Vehicle
            {
                Brand = "Skoda",
                Model = "Octavia",
                Colour = Colour.White.ToString(),
                Year = 2023,
                Engine = Engine.Diesel.ToString(),
                Volume = 1.5
            });
            Fleet.Add(new Vehicle
            {
                Brand = "Opel",
                Model = "Corsa",
                Colour = Colour.White.ToString(),
                Year = 2014,
                Engine = Engine.Gasoline.ToString(),
                Volume = 1.4
            });
            Fleet.Add(new Vehicle
            {
                Brand = "Renault",
                Model = "Fluence",
                Colour = Colour.Black.ToString(),
                Year = 2017,
                Engine = Engine.Diesel.ToString(),
                Volume = 1.6
            });
            Fleet.RemoveAt(1);
            foreach (Vehicle vehicle in Fleet)
                vehicle.ToString();*/
            /*var r = new Rectangle();
            r.Position.X = 23;
            r.Position.Y = 43;
            r.Size.Width = 100;
            r.Size.Height = 50;
            r.Draw();*/
            /*var r = new Rectangle();
            r.Position.X = 55;
            r.Position.Y = 25;
            r.Size.Width = 200;
            r.Size.Height = 100;
            ShapeDraw(r);*/
            /*var r = new Rectangle();
            r.Position.X = 55;
            r.Position.Y = 25;
            r.Size.Width = 200;
            r.Size.Height = 100;
            ShapeDraw(r);
            r.Move(new Position { X = 20, Y = 30 });
            ShapeDraw(r);*/

            #region DrawingAbstract
            /*var r = new Rectangle();
            r.Position.X = 55;
            r.Position.Y = 25;
            r.Size.Width = 200;
            r.Size.Height = 100;
            ShapeDraw(r);
            r.Move(new Position { X = 20, Y = 30 });
            ShapeDraw(r);*/
            /*Shape S1 = new Rectangle();
            S1.Position.X = 50;
            S1.Position.Y = 50;
            S1.Size.Width = 100;
            S1.Size.Height = 50;
            ShapeDraw(S1);*/
            /*Shape S1 = new Rectangle(50,50,100,100);
            ShapeDraw(S1);*/
            #endregion

            #region Bank
            /*IBankAccount DepositAccount = new InvestmentAccount();
            DepositAccount.Deposit(100);
            DepositAccount.Withdraw(500);
            DepositAccount.Withdraw(50);
            Console.WriteLine(DepositAccount.ToString());*/
            /*IBankAccount InvestmentAccount = new InvestmentAccount();
            ITransfer ActiveAccount = new ActiveAccount();

            Console.WriteLine(ActiveAccount.ToString());
            Console.WriteLine(InvestmentAccount.ToString());

            ActiveAccount.Deposit(250);
            Console.WriteLine(ActiveAccount.ToString());
            Console.WriteLine(InvestmentAccount.ToString());

            InvestmentAccount.Deposit(500);
            Console.WriteLine(ActiveAccount.ToString());
            Console.WriteLine(InvestmentAccount.ToString());

            ActiveAccount.MakeTransfer(InvestmentAccount, 200);
            Console.WriteLine(ActiveAccount.ToString());
            Console.WriteLine(InvestmentAccount.ToString());*/
            #endregion

            new CollectionApp();

            Console.ReadKey();
        }
    }
}