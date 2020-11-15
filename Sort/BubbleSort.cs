using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
   static class BubbleSort
    {
    internal  static int[] BubbleSortAlg(this int[] value,int[] item)
        {
            int temp;
            for (int i = 0; i < item.Length; i++)
            {
                for (int j = i + 1; j < item.Length; j++)
                {
                    if (item[i] > item[j])
                    {
                        temp = item[i];
                        item[i] = item[j];
                        item[j] = temp;
                    }
                }
            }
            return item;
        }

    }

}
