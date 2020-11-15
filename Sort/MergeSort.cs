using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static  class MergeSort
    {
        public static void MegreSortAlg(this int[] value,int[] items)
        {
            int leftSize = items.Length / 2;
            int rightSize = items.Length - leftSize;
            int[] left = new int[leftSize];
            int[] right = new int[rightSize];

            Array.Copy(items, 0, left, 0, leftSize);
            Array.Copy(items, leftSize, right, 0, rightSize);

            // Рекурсивное деление массива

            MegreSortAlg(null,left);
            MegreSortAlg(null,right);

            Merge(items, left, right);

        }

        static private void Merge(int[] items, int[] left, int[] right)
        {
            int leftIndex = 0;
            int rightIndex = 0;
            int targetIndex = 0;
            int remaining = left.Length + right.Length; // общая длинна правой и левой части сортируемого массива

            while (remaining > 0)
            {
                if (leftIndex >= left.Length)
                {
                    items[targetIndex] = right[rightIndex++];
                }

                else if (rightIndex >= right.Length)
                {
                    items[targetIndex] = left[leftIndex++];
                }

                else if (left[leftIndex].CompareTo(right[rightIndex]) < 0)
                {
                    items[targetIndex] = left[leftIndex++];
                }

                else
                {
                    items[targetIndex] = right[rightIndex++];
                }

                targetIndex++;
                remaining--;
            }
        }

    }
}
