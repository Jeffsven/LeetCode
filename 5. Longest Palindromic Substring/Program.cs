//using System;

//namespace _5._Longest_Palindromic_Substring
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string input = "aaaa";

//            string output = new Solution().LongestPalindrome(input);

//            Console.WriteLine(input);
//            Console.WriteLine(output);
//        }
//    }


//    public class Solution
//    {
//        public string LongestPalindrome(string s)
//        {
//            string buffer = s[0].ToString();
//            string current_char = string.Empty;
//            string prev_char = string.Empty;

//            int centreIDx = 0;
//            int centerIdxSize = 0;
//            int counter = 0;
            
//            bool mirror = false;

//            for (int i = 0; i < s.Length; i++)
//            {
//                var svalue = s[i].ToString();

//                //bab type
//                if (svalue == prev_char)
//                {
//                    if (!mirror)
//                    {
//                        centreIDx = i - 1;
//                        mirror = true;
//                    }
//                }
//                //bb type
//                if (svalue == current_char)
//                {
//                    centerIdxSize++;
//                    if (!mirror)
//                    {
//                        centreIDx = i;
//                        mirror = true;
//                    }
//                }
//                prev_char = current_char;
//                current_char = svalue;


//                if (mirror)
//                {
//                    var mirror_idx = (centreIDx * 2) - i /*- skipbit*/;
//                    mirror = mirror_idx >= 0;
//                    if (mirror) mirror = svalue == s[mirror_idx].ToString();

//                    if (mirror)
//                    {
//                        var output = s.Substring(mirror_idx, i - mirror_idx + 1);
//                        if (buffer.Length < output.Length) buffer = output;
//                    }

//                    //reset flag
//                    else
//                    {
//                        prev_char = current_char = string.Empty;
//                        centerIdxSize = 0;
//                        i = counter++;
//                    }
//                }
//            }
//            return buffer;
//        }
//    }
//}
