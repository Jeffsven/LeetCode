namespace _872._Leaf_Similar_Trees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
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
        string rootList1 = "";
        string rootList2 = "";

        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            DeepSearch(root1,ref rootList1);
            DeepSearch(root2,ref rootList2);

            return string.Join("@", rootList1) == string.Join("@", rootList2);
        }

        public void DeepSearch(TreeNode node, ref string s)
        {
            if (node is null) return;
            if (node.left == null && node.right == null) s += $"@{node.val}";
            DeepSearch(node.left, ref s);
            DeepSearch(node.right, ref s);
        }
    }
}