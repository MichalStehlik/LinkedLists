using System;
using System.Collections.Generic;
using System.Text;

namespace LL00SingleLinkedList
{
    class MyLinkedList<T>
    {
        public ListNode<T> head;

        public void Add(T item)
        {
            ListNode<T> node = new ListNode<T>(item);
            if (head == null)
            {
                head = node;
            }
            else
            {
                ListNode<T> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = node;
            }
        }

        public int Count
        {
            get
            {
                int counter = 0;
                ListNode<T> current = head;
                while (current != null)
                {
                    counter++;
                    current = current.Next;
                }
                return counter;
            }
        }

        public void Clear()
        {
            head = null;
        }

        public void AddToStart(T item)
        {
            ListNode<T> node = new ListNode<T>(item);
            node.Next = head;
            head = node;
        }

        public bool Contains(T item)
        {
            ListNode<T> current = head;
            while (current != null)
            {
                if (current.value.Equals(item))
                {
                    return true;
                }   
                current = current.Next;
            }
            return false;
        }

        public int IndexOf(T item)
        // DU
        {
            return -1;
        }

        public T GetItem(int index)
        // DU
        {
            // throw IndexOutOfRangeException
            return default(T);
        }

        public void Insert(int index, T item)
        // DU
        {

        }

        public void Remove(T item)
        // SDU
        {

        }

        public void RemoveAt(int index)
        // SDU
        {

        }
    }
}
