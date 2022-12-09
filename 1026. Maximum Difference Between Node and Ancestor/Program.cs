namespace _1026._Maximum_Difference_Between_Node_and_Ancestor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode t = new TreeNode()
            //Console.WriteLine("Hello, World!");
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
        int max = 0;

        public int MaxAncestorDiff(TreeNode root)
        {
            if (root is null) return 0;
            List<int> ancestor = new List<int>() { root.val };

            DeepSearch(root.left, ancestor);
            DeepSearch(root.right, ancestor);
            return max;
        }

        public void DeepSearch(TreeNode root, List<int> ancestor)
        {
            if (root is null) return;
            ancestor.ForEach(x =>
            {
                int diff = Math.Abs(x - root.val);
                if (diff > max) max = diff;
            });
            ancestor.Add(root.val);
            DeepSearch(root.left, ancestor);
            DeepSearch(root.right, ancestor);
            ancestor.RemoveAt(ancestor.Count - 1);
        }
    }
}