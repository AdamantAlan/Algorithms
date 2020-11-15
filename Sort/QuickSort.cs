using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
   public static class QuickSort
    {
        public static void QuickSortAlg(this int[] value,int[] array)
        {
            QuickSortAlg(array, 0, array.Length - 1);
        }
        public static void QuickSortAlg(int[] array, int left, int right)
        {
            int i = left, j = right;
            int temp = array[(left + right) >> 1];

            while (i <= j)
            {
                while (array[i] < temp)
                {
                    i++;
                }

                while (array[j] > temp)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    int tmp = array[i];
                    array[i] = array[j];
                    array[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                QuickSortAlg(array, left, j);
            }

            if (i < right)
            {
                QuickSortAlg(array, i, right);
            }
        }
    }
}
