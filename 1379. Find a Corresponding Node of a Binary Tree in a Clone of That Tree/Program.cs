using System;

namespace _1379._Find_a_Corresponding_Node_of_a_Binary_Tree_in_a_Clone_of_That_Tree
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
        public TreeNode(int x) { val = x; }
    }


    public class Solution
    {
        TreeNode ans, target;

        public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
        {
            this.target = target;
            GetTarget(original, cloned);
            return ans;
        }

        private void GetTarget(TreeNode o, TreeNode c)
        {
            if (o != null)
            {
                GetTarget(o.left, c.left);
                if (o == target) ans = c;
                GetTarget(o.right, c.right);
            }
        }
    }
}
