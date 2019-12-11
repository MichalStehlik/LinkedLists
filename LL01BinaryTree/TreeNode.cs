using System;
using System.Collections.Generic;
using System.Text;

namespace LL01BinaryTree
{
    class TreeNode<T>
    {
        internal T value;

        public TreeNode(T value)
        {
            this.value = value;
        }

        internal TreeNode<T> left;
        internal TreeNode<T> right;
    }
}
