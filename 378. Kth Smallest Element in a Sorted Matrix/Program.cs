using System;
using System.Linq;

namespace _378._Kth_Smallest_Element_in_a_Sorted_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[3][]
            {
                new int[]{ 1,5,9},
                new int[]{ 10,11,13},
                new int[]{ 12,13,15}
            };


            var res = new Solution().KthSmallest(matrix, 8);

        }
    }


    public class Solution
    {
        public int KthSmallest(int[][] matrix, int k)
        {
            return matrix.SelectMany(x => x).OrderBy(x => x).ToArray()[k - 1];
        }
    }
}
