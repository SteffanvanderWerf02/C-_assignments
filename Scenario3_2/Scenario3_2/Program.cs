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
            
            numbers1.Enqueue(8);
            numbers1.Enqueue(6);
            numbers1.Enqueue(4);
            numbers1.Enqueue(2);
            numbers1.Enqueue(1);

            numbers2.Enqueue(9);
            numbers2.Enqueue(7);
            numbers2.Enqueue(5);
            numbers2.Enqueue(3);
            numbers2.Enqueue(0);

            makeInOrder(numbers1, numbers2);

        }

        static void makeInOrder(Queue<int> first, Queue<int> second)
        {
           while (first.Count >= 0 && second.Count >= 0)
           {
                if (first.Count == 0)
                {
                    Console.WriteLine(second.Dequeue());
                    break;
                }
                if (second.Count == 0)
                {
                    Console.WriteLine(first.Dequeue());
                    break;
                }

                if (first.Peek() < second.Peek())
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
