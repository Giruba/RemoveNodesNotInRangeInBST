using System;
using System.Collections.Generic;
using System.Text;

namespace BST_RemoveNodesOutsideRange
{
    class ProcessInput
    {
        BST bstRoot;
        public ProcessInput() { }

        public BST ConstructBST() {
            Console.WriteLine("Enter the number of nodes in the BST");
            int noOfNodes = Int16.Parse(Console.ReadLine());
            for (int i = 0; i < noOfNodes; i++) {
                Console.WriteLine("Enter the value of the node:");
                int node = Int16.Parse(Console.ReadLine());
                bstRoot = new BST().insertInBST(bstRoot, node);
            }
            bstRoot.printInOrderTraversal(bstRoot);
            return bstRoot;
        }

        public void GetProcessedBST(BST root) {
            Console.WriteLine();
            Console.WriteLine("Enter the minimum value");
            int min = Int16.Parse(Console.ReadLine());

            Console.WriteLine("Enter the maximum value");
            int max = Int16.Parse(Console.ReadLine());

            bstRoot = bstRoot.removedNodesNotInRange(root, min, max);
            bstRoot.printInOrderTraversal(bstRoot);
        }

    }
}
