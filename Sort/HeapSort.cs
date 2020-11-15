using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
  static  class HeapSort
    {
        public static void HeapSortAlg(this int[] value,int[] array)
        {
            int lenght = array.Length;

            // Построение кучи (перегруппируем массив)
            for (int i = lenght / 2 - 1; i >= 0; i--)
                heapify(array, lenght, i);

            // Один за другим извлекаем элементы из кучи
            for (int i = lenght - 1; i >= 0; i--)
            {
                // Перемещаем текущий корень в конец
                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;

                // вызываем процедуру heapify на уменьшенной куче
                heapify(array, i, 0);
            }
        }

        // Процедура для преобразования в двоичную кучу поддерева с корневым узлом i, что является
        // индексом в arr[]. n - размер кучи

      static  void heapify(int[] array, int lenght, int i)
        {
            int largest = i;
            // Инициализируем наибольший элемент как корень
            int l = 2 * i + 1; // left = 2*i + 1
            int r = 2 * i + 2; // right = 2*i + 2

            // Если левый дочерний элемент больше корня
            if (l < lenght && array[l] > array[largest])
                largest = l;

            // Если правый дочерний элемент больше, чем самый большой элемент на данный момент
            if (r < lenght && array[r] > array[largest])
                largest = r;

            // Если самый большой элемент не корень
            if (largest != i)
            {
                int swap = array[i];
                array[i] = array[largest];
                array[largest] = swap;

                // Рекурсивно преобразуем в двоичную кучу затронутое поддерево
                heapify(array, lenght, largest);
            }
        }
    }
}
