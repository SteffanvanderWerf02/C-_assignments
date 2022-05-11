using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers1 = new Stack<int>();
            Stack<int> numbers2 = new Stack<int>();

            numbers1.Push(8);
            numbers1.Push(6);
            numbers1.Push(4);
            numbers1.Push(2);
            numbers1.Push(1);

            numbers2.Push(9);
            numbers2.Push(7);
            numbers2.Push(5);
            numbers2.Push(3);
            numbers2.Push(0);

            makeInOrder(numbers1, numbers2);

        }

        static void makeInOrder(Stack<int> first, Stack<int> second)
        {
            while (first.Count >= 0 && second.Count >= 0)
            {
                if (first.Count == 0)
                {
                    Console.WriteLine(second.Pop());
                    break;
                }
                if (second.Count == 0)
                {
                    Console.WriteLine(first.Pop());
                    break;
                }

                if (first.Peek() < second.Peek())
                {
                    Console.WriteLine(first.Pop());
                }
                else
                {
                    Console.WriteLine(second.Pop());
                }
            }
        }
    }
}

