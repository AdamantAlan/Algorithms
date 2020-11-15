using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Seach
{
 public static  class BinarySearch
    {
      public  static int BinarySearchAlg(this int value,int[] array, int searchedValue, int left, int right)
        {
            while (left <= right)
            {
                var middle = (left + right) / 2;
                if (searchedValue == array[middle])
                {
                    return middle;
                }
                else if (searchedValue < array[middle])
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }
            return -1;
        }
    }
}
