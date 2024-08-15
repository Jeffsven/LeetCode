namespace _1609._Even_Odd_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Solution().IsEvenOddTree(null);
        }
    }


    public class Solution
    {
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

        List<List<int>> collection = new List<List<int>>();

        public bool IsEvenOddTree(TreeNode root)
        {
            int start = 0;
            return ReadNode(root, ref start);
        }

        private bool ReadNode(TreeNode root, ref int start)
        {

            if (root != null)
            {
                if (collection.Count <= start) collection.Add(new List<int>());
                collection[start].Add(root.val);
            }


            //even
            if (start % 2 == 0)
            {
                if (collection[start].Last() > root.val) return false;
            }
            //odd
            else
            {
                if (collection[start].Last() < root.val) return false;
            }


            start += 1;
            if (root.left != null) ReadNode(root.left, ref start);
            if (root.right != null) ReadNode(root.right, ref start);
            start -= 1;




            return true;
        }

    }
}