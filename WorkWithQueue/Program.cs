using System;

namespace WorkWithQueue
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class QueueItem
    {
        public int value { get; set; }
        public QueueItem Next { get; set; }
    }

    class Queue
    {
        QueueItem head;
        QueueItem tail;

        public bool IsEmpty
        {
            get
            {
                return head == null;
            }
        }

        public void Enqueue(int value)
        {
            var item = new QueueItem
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

        public int Dequeue()
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



