using System;
using System.Collections.Generic;

namespace Binary_Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            var newBT = new TreeNode("drinks");
            var lChild = new TreeNode("hot");
            var tea = new TreeNode("tea");
            var coffee = new TreeNode("coffee");
            lChild.leftChild = tea;
            lChild.rightChild = coffee;
            var rChild = new TreeNode("cold");
            newBT.leftChild = lChild;
            newBT.rightChild = rChild;

            // Console.WriteLine(PreOrderTraverse(newBT));
            // Console.WriteLine(InOrderTraversal(newBT));
            // Console.WriteLine(PostOrderTraversal(newBT));
            // LevelOrderTraversal(newBT);
            // Console.WriteLine(SearchTree(newBT, "coffee"));
            InsertNode(newBT, new TreeNode("cola"));
            // LevelOrderTraversal(newBT);
            // var dNode = GetDeepestNode(newBT);
            // DeleteDeepestNode(newBT, dNode);
            // LevelOrderTraversal(newBT);
            // DeleteNode(newBT ,"Tea");
            // LevelOrderTraversal(newBT);
            // DeleteBinaryTree(newBT);
            LevelOrderTraversal(newBT);
            // Console.WriteLine(newBT.data);
            LevelOrderTraversal(InvertBT(newBT));
            
        }

        // Functions on Binary Trees using Linkedlist
        public static string PreOrderTraverse(TreeNode bt)
        {
            if (bt == null) {
                return "";
            }
            string finalString = bt.data + " " + PreOrderTraverse(bt.leftChild) + PreOrderTraverse(bt.rightChild); 
            return finalString;
        }
        public static string InOrderTraversal(TreeNode bt)
        {
            if (bt == null) {
                return "";
            }
            string finalString = InOrderTraversal(bt.leftChild) + bt.data + " " + InOrderTraversal(bt.rightChild);
            return finalString;
        }
        public static string PostOrderTraversal(TreeNode bt)
        {
            if (bt == null) {
                return "";
            }
            string finalString = PostOrderTraversal(bt.leftChild) + PostOrderTraversal(bt.rightChild) + bt.data + " ";
            return finalString;
        }
        public static void LevelOrderTraversal(TreeNode bt)
        {
            if (bt == null) {
                Console.WriteLine("This is an empty binary tree");
                return;
            }
            var queue = new QueueLL();
            queue.Enqueue(bt);
            while (!(queue.IsEmpty())) {
                var root = queue.Dequeue();
                Console.Write(root.data + " ");
                if (root.leftChild != null) {
                    queue.Enqueue(root.leftChild);
                }
                if (root.rightChild != null) {
                    queue.Enqueue(root.rightChild);
                }
            } Console.WriteLine();
        }
        public static bool SearchTree(TreeNode rootNode, string rand)
        {
            if (rootNode == null) {
                return false;
            }
            var queue = new QueueLL();
            queue.Enqueue(rootNode);
            while (!(queue.IsEmpty())) {
                var root = queue.Dequeue();
                if (root.data == rand) return true;
                if (root.leftChild != null) {
                    queue.Enqueue(root.leftChild);
                } 
                if (root.rightChild != null) {
                    queue.Enqueue(root.rightChild);
                }
            }
            return false;
        }
        public static void InsertNode(TreeNode rootNode, TreeNode newNode)
        {
            if (rootNode == null) {
                rootNode = newNode;
            } else {
                var queue = new QueueLL();
                queue.Enqueue(rootNode);
                while (!(queue.IsEmpty())) {
                    var root = queue.Dequeue();
                    if (root.leftChild == null) {
                        root.leftChild = newNode;
                        return;
                    } else {
                        queue.Enqueue(root.leftChild);
                    }

                    if (root.rightChild == null) {
                        root.rightChild = newNode;
                        return;
                    } else {
                        queue.Enqueue(root.rightChild);
                    }
                }
            }
        }
        public static TreeNode GetDeepestNode(TreeNode rootNode)
        {
            if (rootNode == null) {
                throw new InvalidOperationException("This is an empty Tree");
            }
            var queue = new QueueLL();
            queue.Enqueue(rootNode);
            var rootList = new List<TreeNode>();
            // TreeNode root;
            while (!(queue.IsEmpty())) {
                var root = queue.Dequeue();
                rootList.Add(root);
                if (root.leftChild != null) queue.Enqueue(root.leftChild);
                if (root.rightChild != null) queue.Enqueue(root.rightChild);
            }
            
            return rootList[rootList.Count - 1];
        }
        public static void DeleteDeepestNode(TreeNode rootNode, TreeNode dNode)
        {
            if (rootNode == null) {
                return;
            }
            var queue = new QueueLL();
            queue.Enqueue(rootNode);
            while (!(queue.IsEmpty())) {
                var root = queue.Dequeue();
                if (root == dNode) {
                    root = null;
                    return;
                }
                if (root.rightChild != null) {
                    if (root.rightChild == dNode) {
                        root.rightChild = null;
                        return;
                    } else {
                        queue.Enqueue(root.rightChild);
                    }
                }
                if (root.leftChild != null) {
                    if (root.leftChild == dNode) {
                        root.leftChild = null;
                        return;
                    } else {
                        queue.Enqueue(root.leftChild);
                    }
                }
            }
        }
        public static void DeleteNode(TreeNode rootNode, string nodeData)
        {
            if (rootNode == null) {
                Console.WriteLine("This Binary Tree does not exist!");
                return;
            }
            var queue = new QueueLL();
            queue.Enqueue(rootNode);
            while (!(queue.IsEmpty())) {
                var root = queue.Dequeue();
                if (root.data == nodeData) {
                    var dummy = GetDeepestNode(rootNode);
                    root.data = dummy.data;
                    DeleteDeepestNode(rootNode, dummy);
                    return;
                }
                if (root.leftChild != null) {
                    queue.Enqueue(root.leftChild);
                }
                if (root.rightChild != null) {
                    queue.Enqueue(root.rightChild);
                }
            } 
            Console.WriteLine("There is no such item in this binary tree");
            return;  
        }
        public static void DeleteBinaryTree(TreeNode rootNode)
        {
            if (rootNode == null) {
                return;
            }
            rootNode.data = null;
            rootNode.leftChild = null;
            rootNode.rightChild = null;
            Console.WriteLine("Binary Tree deleted, waiting for garbage collection to clean it up");
        }
        public static TreeNode InvertBT(TreeNode rootNode)
        {
            if (rootNode == null) return rootNode;
            if (rootNode.leftChild == null && rootNode.rightChild == null) {
                return rootNode;
            } else if (rootNode.leftChild == null) {
                rootNode.leftChild = rootNode.rightChild;
                rootNode.rightChild = null;
                return rootNode;
            } else if (rootNode.rightChild == null) {
                rootNode.rightChild = rootNode.leftChild;
                rootNode.leftChild = null;
                return rootNode;
            } else {
                var temp = rootNode.leftChild;
                rootNode.leftChild = InvertBT(rootNode.rightChild);
                rootNode.rightChild = InvertBT(temp);
            }
            return rootNode;
        }
    }
}
