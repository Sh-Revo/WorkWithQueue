using System;
using System.Collections;
using System.Threading;
using System.Collections.Generic;

namespace WorkWithQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var e in Sequence.Fibonacci)
            {
                Console.WriteLine(e);
                Thread.Sleep(100);
                if (Console.KeyAvailable)
                    break;
            }
        }
    }

    public class Sequence
    {
        public static IEnumerable<int> Fibonacci
        {
            get
            {
                int previous = 1;
                int current = 1;
                yield return 1;
                yield return 1;
                while (true)
                {
                    var newValue = current + previous;
                    previous = current;
                    current = newValue;
                    yield return current;
                }
            }
        }
    }
}
