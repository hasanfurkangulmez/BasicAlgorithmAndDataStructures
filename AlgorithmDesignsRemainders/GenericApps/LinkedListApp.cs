using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithmAndDataStructures.AlgorithmDesignsRemainders.GenericApps
{
    public class StaticDemo<T>
    {
        public static int x;
    }
    public class LinkedListNode<T>
    {
        public LinkedListNode(T value) => Value = value;
        public T Value { get; }
        public LinkedListNode<T> Next { get; internal set; }//Forward: İleri
        public LinkedListNode<T> Previous { get; internal set; }
    }
    public class LinkedListApp<T> : IEnumerable<T>
    {
        public LinkedListNode<T> First { get; private set; }
        public LinkedListNode<T> Last { get; private set; }

        public LinkedListNode<T> LastAdd(T Node)
        {
            var NewNode = new LinkedListNode<T>(Node);
            if (First == null)
            {
                First = NewNode;
                Last = First;
            }
            else
            {
                LinkedListNode<T> Previous = Last;
                Last.Next = NewNode;
                Last = NewNode;
                Last.Previous = Previous;
            }
            return NewNode;
        }
        public IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> Current = First;
            while (Current != null)
            {
                yield return Current.Value;
                Current = Current.Next;
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
