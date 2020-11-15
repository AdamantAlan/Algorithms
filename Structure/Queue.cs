using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Queue<T>
    {
        private class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }
            public Node(T data, Node next)
            {
                this.Data = data;
                this.Next = next;
            }
        } 
        Node _head;
        Node _tail;
        int _count;
        public Queue()
        {
            _head = _tail = null;
            _count = 0;
        }
        public void Eniqueue(T item)
        {
            if(_tail == null)
            {
                _head = _tail = new Node(item, null);
            }
            else
            {
                _tail.Next = new Node(item, null);
            }
            _count++;
        }
        public T Dequeue()
        {
            if (_head == null)
                return default(T);
            T result = _head.Data;
            _head = _head.Next;
            return result;
        }
        public T Peek()
        {
            if (_head == null)
                return default(T);
            return _head.Data;
        }


    }
}
