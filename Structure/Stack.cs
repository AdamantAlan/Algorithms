using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Stack<T>
    {
        private class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }
            
            public Node(T data,Node next)
            {
                this.Data = data;
                this.Next = next;
            }
        }
        private Node _top;
        int _count;
        public Stack()
        {
            _top = null;
            _count = 0;
        }

        public void Push(T item)
        {
            _top = new Node(item, _top);
            _count++;
        }

        public T Pop()
        {
            T result = _top.Data;
            _top = _top.Next;
            _count--;
            return result;
        }
        public T Peek()
        {
            return _top.Data;
        }
    }
}
