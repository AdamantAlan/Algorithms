using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class TreeSort
    {
        public TreeSort(int data)
        {
            Data = data;
        }

       
        public int Data { get; set; }

        //левая ветка дерева
        public TreeSort Left { get; set; }

        //правая ветка дерева
        public TreeSort Right { get; set; }

        //рекурсивное добавление узла в дерево
        public void Insert(TreeSort node)
        {
            if (node.Data < Data)
            {
                if (Left == null)
                {
                    Left = node;
                }
                else
                {
                    Left.Insert(node);
                }
            }
            else
            {
                if (Right == null)
                {
                    Right = node;
                }
                else
                {
                    Right.Insert(node);
                }
            }
        }

        //преобразование дерева в отсортированный массив
        public int[] Transform(List<int> elements = null)
        {
            if (elements == null)
            {
                elements = new List<int>();
            }

            if (Left != null)
            {
                Left.Transform(elements);
            }

            elements.Add(Data);

            if (Right != null)
            {
                Right.Transform(elements);
            }

            return elements.ToArray();
        }

       
    }

    static public class AlgSort
    {
        static public int[] TreeSortAlg(this int[] value, int[] array)
        {
            var treeNode = new TreeSort(array[0]);
            for (int i = 1; i < array.Length; i++)
            {
                treeNode.Insert(new TreeSort(array[i]));
            }
            array= treeNode.Transform();
            return array;
        }
    }

}
