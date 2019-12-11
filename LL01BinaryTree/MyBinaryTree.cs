using System;
using System.Collections.Generic;
using System.Text;

namespace LL01BinaryTree
{
    class MyBinaryTree<T> where T : IComparable
    {
        protected TreeNode<T> _root = null;

        public void Add(T item)
        {
            Add(item, ref _root);
        }

        protected void Add(T item, ref TreeNode<T> node)
        {
            if (node == null)
            {
                node = new TreeNode<T>(item);
            }
            else if(item.CompareTo(node.value) == -1)
            {
                Add(item, ref node.left);
            }
            else
            {
                Add(item, ref node.right);
            }
        }

        public override string ToString()
        {
            return TreeToString(_root);
        }

        protected string TreeToString(TreeNode<T> node)
        {
            if (node == null) return "";
            return TreeToString(node.left) + " / " + node.value + " / " + TreeToString(node.right);
        }
        
        public TreeNode<T> Find(T item)
        {
            return Find(item, _root);
        }

        protected TreeNode<T> Find(T item, TreeNode<T> node)
        {
            if (node != null)
            {
                if (item.CompareTo(node.value) == 0)
                {
                    return node;
                }
                else if (item.CompareTo(node.value) == -1)
                {
                    return Find(item, node.left);
                }
                else
                {
                    return Find(item, node.right);
                }
            }
            return null;
        }
    }
}
