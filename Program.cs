using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Seach;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Algorithms Sort");
            {
                int[] array = new int[] { 4, 0, 10, 2, 8, 7, 5, 3, 2 };
                array.MegreSortAlg(array);
                foreach (var item in array)
                    Console.WriteLine(item.ToString());
            }

            
            Console.WriteLine("Algorithms Search");
            {
                int[] array = new int[] { 4, 0, 10, 2, 8, 7, 5, 3, 2 };
                array.QuickSortAlg(array);
                int temp=-1;
               
                Console.WriteLine(temp.BinarySearchAlg(array, 7, 0, 6).ToString());
            }
            Console.WriteLine("Structure");
           
            {
                Stack<int> stack = new Stack<int>();
                stack.Push(3);
                stack.Push(-7);
                stack.Push(8);
                stack.Pop();
                stack.Pop();
                Console.WriteLine(stack.Peek());
            }
            Console.ReadKey();
        }
    }
}
