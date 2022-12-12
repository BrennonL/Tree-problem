using System;

namespace Tree // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tree = new BinarySearchTree();
            
            // Test functions
            tree.FindValue(20);
            tree.FindValue(4);

            tree.Insert(20);
            tree.Insert(12);
            tree.Insert(8);
            tree.Insert(11);
            tree.Insert(45);
            tree.Insert(32);
            tree.Insert(23);


            foreach (var item in tree)
            {
                Console.WriteLine(item);
            }
            // Test functions
            tree.FindValue(11);
            tree.FindValue(8);
        }
    }
}