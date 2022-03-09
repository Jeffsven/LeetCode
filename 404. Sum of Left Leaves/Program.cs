using System;
using System.Linq;
using System.Collections.Generic;

namespace _404._Sum_of_Left_Leaves
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Solution
    {
        List<int> leftnodeVal = new List<int>();
        public int SumOfLeftLeaves(TreeNode root)
        {
            var leftnode = root.left;
            if (leftnode != null)
            {
                if (leftnode.left is null && leftnode.right is null) leftnodeVal.Add(leftnode.val);
                else SumOfLeftLeaves(leftnode);
            }
            var rightnode = root.right;
            if(rightnode != null)
            {
                SumOfLeftLeaves(rightnode);
            }

            return leftnodeVal.Sum();
        }
    }
}
