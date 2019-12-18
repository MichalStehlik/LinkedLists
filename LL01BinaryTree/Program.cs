using System;

namespace LL01BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            MyBinaryTree<DictionaryTerm> tree = new MyBinaryTree<DictionaryTerm>();
            tree.Add(new DictionaryTerm("pes","dog"));
            tree.Add(new DictionaryTerm("kočka", "cat"));
            tree.Add(new DictionaryTerm("myš", "mouse"));
            tree.Add(new DictionaryTerm("kůň", "horse"));
            tree.Add(new DictionaryTerm("kráva", "cow"));
            tree.Add(new DictionaryTerm("antilopa", "antelope"));
            tree.Add(new DictionaryTerm("bizon", "bison"));
            tree.Add(new DictionaryTerm("žirafa", "giraffe"));
            TreeNode<DictionaryTerm> found = tree.Find(new DictionaryTerm("kočka", "swamp monster"));
            if (found != null) Console.WriteLine(found.value.English);
            Console.WriteLine(tree);
            Console.WriteLine(tree.Depth());
            Console.WriteLine(tree.Count());
            Console.ReadKey();
        }
    }
}
