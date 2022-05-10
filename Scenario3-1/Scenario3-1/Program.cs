using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr2D = new int[4,5] { 
                {3, 13, 53, 11, 30},
                {4, 143, 3, 15, 39},
                {7, 133, 32, 16, 65},
                {2, 643, 5, 10, 37}
            };
            
            for (int row = 0; row < arr2D.GetLength(0); row++)
            {
                int heighest = 0;
                for (int col = 0; col < arr2D.GetLength(1); col++)
                {
                    if (arr2D[row, col] > heighest)
                    {
                        heighest = arr2D[row,col];
                    }
                }
                Console.WriteLine(heighest);
            }
        } 
        
    }
}