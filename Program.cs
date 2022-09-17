using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a option.\n1.Create a Binary Tree\n2.Create BST shown in fig.\n3.Find 63 in tree");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch (option)
            {
                case 1:
                    Tree1<int> tree1 = new Tree1<int>(56);
                    tree1.Insert(30);
                    tree1.Insert(70);
                    tree1.Display();
                    break;
                case 2:
                    Tree2<int> tree2 = new Tree2<int>(56);
                    tree2.Insert(30);
                    tree2.Insert(70);
                    tree2.Insert(22);
                    tree2.Insert(40);
                    tree2.Insert(60);
                    tree2.Insert(95);
                    tree2.Insert(11);
                    tree2.Insert(65);
                    tree2.Insert(3);
                    tree2.Insert(16);
                    tree2.Insert(63);
                    tree2.Insert(67);
                    tree2.Display();
                    tree2.GetSize();
                    break;
                case 3:
                    Tree3<int> bst3 = new Tree3<int>(56);
                    bst3.Insert(30);
                    bst3.Insert(70);
                    bst3.Insert(22);
                    bst3.Insert(40);
                    bst3.Insert(60);
                    bst3.Insert(95);
                    bst3.Insert(11);
                    bst3.Insert(65);
                    bst3.Insert(3);
                    bst3.Insert(16);
                    bst3.Insert(63);
                    bst3.Insert(67);
                    bst3.Display();
                    
                    bool result = bst3.IfExists(63, bst3);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}
