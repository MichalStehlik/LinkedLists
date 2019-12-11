using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LL00SingleLinkedList
{
class MyLinkedList<T> : IList<T>
    {
        public T this[int index] { get => GetValue(index); set => SetValue(index, value); }

        public ListNode<T> head;

        public int Count {
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

        public bool IsReadOnly { get { return false; } }

        public void Add(T item)
        {
            ListNode<T> node = new ListNode<T>(item);
            if (head == null)
            {
                head = node;
            }
            else
            {
                var current = head;
                while (current.Next != null) current = current.Next;
                current.Next = node;
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

        public void CopyTo(T[] array, int arrayIndex)
        {
            var current = head;
            while (current != null)
            {
                array.SetValue(current.value, arrayIndex++);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new MyLinkedListEnumerator<T>(this);
        }

        public int IndexOf(T item)
        {
            var current = head;
            int pos = 0;
            while (current != null && !current.value.Equals(item))
            {
                current = current.Next;
                pos++;
            }
            if (current.value.Equals(item))
                return pos;
            return -1;
        }

        public void Insert(int index, T item)
        {
            if (index == 0)
            {
                AddToStart(item);
            }
            else
            {
                ListNode<T> newNode = new ListNode<T>(item);
                ListNode<T> node = GetNode(index);
                newNode.Next = node.Next;
                node.Next = newNode;
            }
        }

        public bool Remove(T item)
        {
            ListNode<T> current = head;
            ListNode<T> previous = null;

            while (current != null)
            {
                if (current.value.Equals(item))
                {
                    if (previous == null)
                    {
                        head = head.Next;
                    }
                    else
                    {
                        previous.Next = current.Next;
                    }
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }

        public void RemoveAt(int index)
        {
            var removed = GetNode(index);
            if (index == 0)
            {
                head = removed.Next;
            }
            else
            {
                var previous = GetNode(index - 1);
                previous.Next = removed.Next;
            }
        }

        public T GetValue(int index)
        {
            return GetNode(index).value;
        }

        public T SetValue(int index, T newValue)
        {
            GetNode(index).value = newValue;
            return newValue;
        }

        protected ListNode<T> GetNode(int index)
        {
            ListNode<T> current = head;
            for (int i = 0; i < index; i++)
            {
                if (current != null)
                {
                    current = current.Next;
                }
                else
                {
                    break;
                }
            }
            if (current == null)
            {
                throw new IndexOutOfRangeException(index.ToString());
            }
            return current;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new MyLinkedListEnumerator<T>(this);
        }
    }

    class MyLinkedListEnumerator<T> : IEnumerator<T>
    {
        protected ListNode<T> _current;
        protected MyLinkedList<T> _list;

        public MyLinkedListEnumerator(MyLinkedList<T> list)
        {
            _list = list;
            Reset();
        }

        public object Current 
        {
            get 
            {
                return _current.value; 
            } 
        }

        T IEnumerator<T>.Current { get { return _current.value; } }

        public void Dispose() {}

        public bool MoveNext()
        {
            if (_current == null && _list.head != null) 
            {
                _current = _list.head;
            }               
            else if (_current == null)
            {
                return false;
            }
            else
            {
                _current = _current.Next;
            }               
            if (_current == null) return false;
            return true;
        }

        public void Reset()
        {
            _current = null;
        }
    }
}
