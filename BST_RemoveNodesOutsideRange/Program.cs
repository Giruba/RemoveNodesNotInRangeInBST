using System;

namespace BST_RemoveNodesOutsideRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Remove nodes in a BST that are not in the given range!");
            Console.WriteLine("--------------------------------------------------------");

            ProcessInput processInput = new ProcessInput();
            BST bstRoot = processInput.ConstructBST();
            processInput.GetProcessedBST(bstRoot);

            Console.ReadKey();
        }
    }
}
