using System;
using System.Collections;
using System.Collections.Generic;

namespace WorkWithQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            foreach (var value in queue)
            {
                Console.WriteLine(value);
            }
        }
    }

    public class QueueItem<T>
    {
        public T Value { get; set; }
        public QueueItem<T> Next { get; set; }
    }

    public class Queue<T> : IEnumerable<T>
    {
        QueueItem<T> head;
        QueueItem<T> tail;

        public bool IsEmpty
        {
            get
            {
                return head == null;
            }
        }

        public void Enqueue(T value)
        {
            var item = new QueueItem<T>
            {
                Value = value
            };
            if (head == null)
            {
                head = tail = item;
            }
            else
            {
                tail.Next = item;
                tail = item;
            }
        }


        public IEnumerator<T> GetEnumerator()
        {
            var current = head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
