using System;

namespace Igdrasil
{
    class Program
    {
        static void Main(string[] args)
        {
            Derevo tree = new Derevo();

            tree.Root = tree.AddNode(9, tree.Root);
            tree.Root = tree.AddNode(0, tree.Root);
            tree.Root = tree.AddNode(44, tree.Root);
            tree.Root = tree.AddNode(45, tree.Root);
            tree.Root = tree.AddNode(6, tree.Root);
            tree.Root = tree.AddNode(10, tree.Root);
            tree.Root = tree.AddNode(-7, tree.Root);
            tree.Root = tree.AddNode(-12, tree.Root);
            tree.PrintTree(Console.WindowWidth / 2, 0, tree.Root);


            Console.SetCursorPosition(0, 25);
            Console.WriteLine(tree.SummaElements(tree.Root));
            Console.WriteLine(tree.CountElements(tree.Root));

        }
    }
}
