using System;
using System.Collections.Generic;
using System.Text;

namespace BST_RemoveNodesOutsideRange
{
    class BST
    {
        int data { get; set; }
        BST left { get; set; }
        BST right { get; set; }

        public static BST Root { get; set; }

        public BST() { }

        private BST(int data) {
            this.data = data;
            left = right = null;
        }

        public BST insertInBST(BST root, int data) {
            if (root == null)
            {
                root = new BST(data);
            }
            else {
                if (root.data < data)
                {
                    root.right = insertInBST(root.right, data);
                }
                else if (root.data > data) {
                    root.left = insertInBST(root.left, data);
                }    
            }
            return root;
        }

        public void printInOrderTraversal(BST root) {
            if (root != null) {
                Console.Write(root.data+"->");
                printInOrderTraversal(root.left);
                printInOrderTraversal(root.right);
            }
            if (root == null) return;
        }

        public BST removedNodesNotInRange(BST root, int min, int max) {
            if (root == null) {
                return null;
            }

            root.left = removedNodesNotInRange(root.left, min, max);
            root.right = removedNodesNotInRange(root.right, min, max);

            if (root.data < min)
            {
                BST nodeRight = root.right;
                root = null;
                return nodeRight;
            }
            else if (root.data > max) {
                BST nodeLeft = root.left;
                root = null;
                return nodeLeft;
            }

            return root;
        }
    }
}
