using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace BasicAlgorithmAndDataStructures.BasicDataStructures
{
    internal class QueueApps
    {
        public QueueApps()
        {
            Queue<int> QueueOne = new Queue<int>();

            for (int i = 0; i < 5; i++)
            {
                QueueOne.Enqueue((int)new Random().Next(0, 1000));
            }
            Console.WriteLine(QueueOne.Count + " piece");

            Console.WriteLine(QueueOne.Peek());
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(QueueOne.Dequeue() + " deleted!");
            }
            Console.WriteLine(QueueOne.Count + " piece");

            QueueOne.Clear();
            Console.WriteLine("Cleaned!");
            Console.WriteLine(QueueOne.Count + " piece");

        }
    }
}
