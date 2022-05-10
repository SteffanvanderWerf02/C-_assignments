using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbers1 = new Queue<int>();
            Queue<int> numbers2 = new Queue<int>();
            
            numbers1.Enqueue(321);
            numbers1.Enqueue(32);
            numbers1.Enqueue(43);
            numbers1.Enqueue(23);
            numbers1.Enqueue(21);

            numbers2.Enqueue(322);
            numbers2.Enqueue(31);
            numbers2.Enqueue(20);
            numbers2.Enqueue(19);
            numbers2.Enqueue(18);

            makeInOrder(numbers1, numbers2);

        }

        static void makeInOrder(Queue<int> first, Queue<int> second)
        {
            while (first.Count > 0 && second.Count > 0)
            {
                Console.WriteLine("First count " + first.Count);
                Console.WriteLine("Second count " + second.Count);

                if (first.Count == 0)
                {
                    Console.WriteLine(first.Dequeue());
                    continue;
                }

                if (second.Count == 0)
                {
                    Console.WriteLine(second.Dequeue());
                    continue;
                }

                if (first.Peek() >= second.Peek())
                {
                    Console.WriteLine(first.Dequeue());

                }
                else
                {
                    Console.WriteLine(second.Dequeue());
                }

            } 
        }
    }
}
