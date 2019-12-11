using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LL00SingleLinkedList
{
    class MyLinkedListEnumerator<T> : IEnumerator<T>
    {
        private MyLinkedList<T> _list;
        private ListNode<T> _current;

        public MyLinkedListEnumerator(MyLinkedList<T> list)
        {
            _list = list;
            Reset();
        }

        public T Current
        {
            get { return _current.value; }
        }

        object IEnumerator.Current
        {
            get { return _current.value; }
        }

        public void Dispose(){}

        public bool MoveNext()
        {
            if (_current == null && _list.head != null)
            {
                _current = _list.head;
                return true;
            }
            else if (_current == null)
            {
                return false;
            }
            _current = _current.Next;
            if (_current == null) return false;
            return true;
        }

        public void Reset()
        {
            _current = null;
        }
    }
}
