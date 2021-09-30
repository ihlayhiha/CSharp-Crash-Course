using System;

namespace Binary_Trees
{
    public class TreeNode
    {
        public string data;
        public TreeNode leftChild;
        public TreeNode rightChild;
        public TreeNode(string data)
        {
            this.data = data;
            this.leftChild = null;
            this.rightChild = null;
        }
    }
}