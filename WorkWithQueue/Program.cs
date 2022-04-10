using System;
using System.Collections;

namespace WorkWithQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue();
            for (int i = 0; i < 3; i++)
                queue.Enqueue(i);
            for (int i = 0; i < 3; i++)
                Console.WriteLine(queue.Dequeue());
            //Console.ReadKey();
        }
    }

    class QueueItem<TValue>
    {
        public TValue value { get; set; }
        public QueueItem<TValue> Next { get; set; }
    }

    class Queue<TValue>
    {
        QueueItem<TValue> head;
        QueueItem<TValue> tail;

        public bool IsEmpty
        {
            get
            {
                return head == null;
            }
        }

        public void Enqueue(TValue value)
        {
            var item = new QueueItem<TValue>
            {
                value = value
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

        public TValue Dequeue()
        {
            if (head == null)
            {
                throw new InvalidOperationException();
            }

            var result = head.value;
            head = head.Next;
            if (head == null)
                tail = null;
            return result;
        }
    }
}



