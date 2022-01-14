using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Value { get; set; }
    }
    class LinkedList<T>
    {
        private Node<T> _head;
        public int Length { get; private set; }
        public LinkedList()
        {
            _head = new Node<T>();
        }
        private Node<T> Find(int index)
        {
            if (index > Length)
                throw new IndexOutOfRangeException();
            Node<T> node = _head;
            for (int i = 0; i < index; i++)
            {
                node = node.Next;
            }
            return node;
        }
        public T At(int index)
          => Find(index).Value;
        public void Insert(Node<T> node, int index)
        {
            if (index > Length || index < 0)
                throw new IndexOutOfRangeException();
            if (index == 0)
            {
                node.Next = _head.Next;
                _head = node;
             
            }
            else
            {
                var node2 = Find(index - 1);
                if (index == Length)
                {
                    node2.Next = node;
                }
                else
                {
                    node.Next = node2.Next.Next;
                    node2.Next = node;
                }
            }

        }
        public void Delete(int index)
        {
            if (index > Length || index < 0)
                throw new IndexOutOfRangeException();
            if (index == 0)
            {
                PopFront();
            }
            else if (index == Length - 1)
            {
                Pop();
            }
            else
            {
                var node2 = Find(index - 1);
                node2.Next = node2.Next.Next;
            }
        }
        public void Add(T value)
        {
            Node<T> next = new Node<T> { Value = value };
            if (Length != 0)
            {
                Node<T> node = _head;
                while (node.Next != null)
                {
                    node = node.Next;
                }
                node.Next = next;
            }
            else
            {
                _head = next;
            }
            Length++;
        }
        public void AddFront(T value)
        {
            Node<T> node = new Node<T> { Value = value };

            if (Length != 0)
            {
                node.Next = _head;
                _head = node;
            }
            else
            {
                _head = node;
            }
            Length++;
        }
        public T Pop()
        {
            if (Length == 0)
            {
                throw new Exception("Must be at list 1 element in list");

            }
            else if (_head.Next == null)
            {
                T value = _head.Value;
                _head = null;
                Length--;
                return value;
            }
            else
            {
                Node<T> node = _head;
                while (node.Next.Next != null)
                {
                    node = node.Next;
                }
                T value = node.Next.Value;
                node.Next = null;
                Length--;
                return value;
            }

        }
        public T PopFront()
        {
            if (Length == 0)
            {
                throw new Exception("Must be at list 1 element in list");

            }
            else
            {
                T value = _head.Value;
                _head = _head.Next;
                Length--;
                return value;
            }
        }
        public void Replace(int index, T value)
        {
            Find(index).Value = value;
        }
        public void Print()
        {
            Node<T> node = _head;
            for(int i = 0; i < Length; i++)
            {
                Console.WriteLine(node.Value + " ");
                node = node.Next;
            }
        }
        public T this[int index]
        {
            get => At(index);
            set
            {
                if (index == Length)
                {
                    Add(value);
                }
                else
                {
                    Replace(index, value);
                }
            }
        }

    }
}