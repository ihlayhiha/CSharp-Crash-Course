using System;
using System.Collections.Generic;

namespace binary_search_tree
{
    public class BSTNode
    {
        public int data;
        public BSTNode leftChild;
        public BSTNode rightChild;
        public BSTNode(int data)
        {
            this.data = data;
            this.leftChild = null;
            this.rightChild = null;
        }
        // printing by level order traversal
        public override string ToString()
        {
            var finalList = new List<int>();
            var root = this;
            var queue = new QueueLL();
            queue.Enqueue(root);
            while (!(queue.IsEmpty())) {
                var currRoot = queue.Dequeue();
                finalList.Add(currRoot.data);
                if (currRoot.leftChild != null) queue.Enqueue(currRoot.leftChild);
                if (currRoot.rightChild != null) queue.Enqueue(currRoot.rightChild);
            }
            return string.Join(" ", finalList);
        }

        // Functions on this Binary Search Tree
        public static void InsertNode(BSTNode rootNode, int val)
        {
            if (rootNode == null) {
                rootNode.data = val;
                return;
            }
            if (val < rootNode.data) {
                if (rootNode.leftChild == null) {
                    // Console.WriteLine("Node has been inserted");
                    rootNode.leftChild = new BSTNode(val);
                } else {
                    InsertNode(rootNode.leftChild, val);
                }
            } else if (val > rootNode.data) {
                if (rootNode.rightChild == null) {
                    // Console.WriteLine("Node has been inserted");
                    rootNode.rightChild = new BSTNode(val);
                } else {
                    InsertNode(rootNode.rightChild, val);
                }
            } else {
                throw new InvalidOperationException(val + " already exists");
            }
        }
        // TRAVERSALS   
        public static void LevelOrderTraversal(BSTNode rootNode)
        {
            if (rootNode == null) return;
            var queue = new QueueLL();
            queue.Enqueue(rootNode);
            while (!(queue.IsEmpty())) {
                var root = queue.Dequeue();
                Console.WriteLine(root.data);
                if (root.leftChild != null) queue.Enqueue(root.leftChild);
                if (root.rightChild != null) queue.Enqueue(root.rightChild);
            }
        }
        public static void PreOrderTraversal(BSTNode rootNode)
        {
            if (rootNode == null) return;
            Console.WriteLine(rootNode.data);
            PreOrderTraversal(rootNode.leftChild);  
            PreOrderTraversal(rootNode.rightChild);  
        }
        public static void InOrderTraversal(BSTNode rootNode)
        {
            if (rootNode == null) return;
            InOrderTraversal(rootNode.leftChild);
            Console.WriteLine(rootNode.data);
            InOrderTraversal(rootNode.rightChild);
        }
        public static void PostOrderTraversal(BSTNode rootNode)
        {
            if (rootNode == null) return;
            PostOrderTraversal(rootNode.leftChild);
            PostOrderTraversal(rootNode.rightChild);
            Console.WriteLine(rootNode.data);
        }
        // SEARCH
        public static bool SearchItem(BSTNode rootNode, int val)
        {
            if (rootNode == null) return false;
            if (rootNode.data == val) return true;
            while (rootNode != null) {
                var currValue = rootNode.data;
                if (val < currValue) {
                    rootNode = rootNode.leftChild;
                } else if (val > currValue) {
                    rootNode = rootNode.rightChild;
                } else {
                    return true;
                }
            }
            return false;
        }
        public static BSTNode MinimumKey(BSTNode rootNode)
        {
            if (rootNode == null)
                throw new InvalidOperationException("Can't perform this op on empty tree");
            while (rootNode.leftChild != null) {
                rootNode = rootNode.leftChild;
            }
            return rootNode;
        }
        public static BSTNode MaximumKey(BSTNode rootNode)
        {
            if (rootNode == null) 
                throw new InvalidOperationException("Can't perform this op on empty tree");
            while (rootNode.rightChild != null) {
                rootNode = rootNode.rightChild;
            }
            return rootNode;
        }
        public static void DeleteEntireBST(BSTNode root)
        {
            root.leftChild = null;
            root.rightChild = null;
            root.data = 0;
            root = null;
            Console.WriteLine("Binary Search Tree has been deleted");
            return;
        }

        public static BSTNode DeleteNode(BSTNode root, int val)
        {
            if (root == null) return root;
            if (val < root.data) {
                root.leftChild = DeleteNode(root.leftChild, val);
            } else if (val > root.data) {
                root.rightChild =  DeleteNode(root.rightChild, val);
            } else {
                    // no children
                if (root.leftChild == null && root.rightChild == null) {
                    return null;
                } else if (root.leftChild != null && root.rightChild == null) {
                    // one child
                    return root.leftChild;
                } else if (root.rightChild != null && root.leftChild == null) {
                    // one child
                    return root.rightChild;
                } else {
                    // two children
                    var temp = MinimumKey(root.rightChild);
                    root.data = temp.data;
                    root.rightChild = DeleteNode(root.rightChild, temp.data);
                }
            }
            return root;
        }
    }
}
