using System;
using System.Linq;
using System.Collections.Generic;

namespace _1008._Construct_Binary_Search_Tree_from_Preorder_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] preorder = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var res = new Solution().BstFromPreorder(preorder);
        }
    }

    public class Solution
    {

        public TreeNode BstFromPreorder(int[] preorder)
        {
            var list = preorder.OrderBy(x => x).ToList();

            int median = list.Count / 2 + (list.Count % 2 is 0 ? 0 : 1);

            var leftlist = list.GetRange(0, median).OrderByDescending(x => x).ToList();
            leftlist.Remove(median);
            var rightlist = list.GetRange(median, list.Count - median).ToList();

            TreeNode maintree = new TreeNode();
            maintree.val = median;


            foreach (var small in leftlist)
            {
                var s = maintree.left;
                left(s)
            }

            return null;
        }

        TreeNode left(int no, TreeNode node)
        {
            node.left = new TreeNode(no);
            return node.left;
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
}
