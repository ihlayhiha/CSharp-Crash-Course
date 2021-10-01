using System;

namespace binary_search_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var newBST = new BSTNode(70);
            BSTNode.InsertNode(newBST, 50);
            BSTNode.InsertNode(newBST, 90);
            // BSTNode.InsertNode(newBST, 30);
            BSTNode.InsertNode(newBST, 60);
            BSTNode.InsertNode(newBST, 80);
            BSTNode.InsertNode(newBST, 100);
            BSTNode.InsertNode(newBST, 20);
            BSTNode.InsertNode(newBST, 40);
            // Console.WriteLine(newBST.leftChild.data);
            // BSTNode.LevelOrderTraversal(newBST);
            // BSTNode.PreOrderTraversal(newBST);
            // BSTNode.InOrderTraversal(newBST);
            // BSTNode.PostOrderTraversal(newBST);
            Console.WriteLine(BSTNode.SearchItem(newBST, 330));
            Console.WriteLine(BSTNode.MinimumKey(newBST).data);
            Console.WriteLine(BSTNode.MaximumKey(newBST).data);
            Console.WriteLine(newBST);


            var sol = new BSTNode(65);
            BSTNode.InsertNode(sol, 34);
            BSTNode.InsertNode(sol, 80);
            BSTNode.InsertNode(sol, 45);
            BSTNode.InsertNode(sol, 77);
            BSTNode.InsertNode(sol, 95);
            BSTNode.InsertNode(sol, 79);
            Console.WriteLine(sol);
            Console.WriteLine(BSTNode.DeleteNode(sol, 65));
            // BSTNode.DeleteEntireBST(sol);
            // Console.WriteLine(sol);
            // BSTNode.InsertNode(sol, 58);
            // Console.WriteLine(sol);
        }
    }
}
