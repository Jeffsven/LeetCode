using System;
using System.Linq;
using System.Collections.Generic;

namespace _67._Add_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = new Solution().AddBinary("1010", "1011");
        }
    }

    public class Solution
    {
        public string AddBinary(string a, string b)
        {
            var maxlength = Math.Max(a.Length, b.Length);

            if (a.Length < maxlength) a = new string('0', maxlength - a.Length) + a;
            if (b.Length < maxlength) b = new string('0', maxlength - b.Length) + b;

            string c = "";
            bool carrier = false;

            for (int i = maxlength - 1; i >= 0; i--)
            {
                if (a[i] is '0' && b[i] is '0')
                {
                    c = (carrier ? "1" : "0") + c;
                    carrier = false;
                }
                else if (a[i] is '0' && b[i] is '1')
                {
                    c = (carrier ? "0" : "1") + c;
                }
                else if (a[i] is '1' && b[i] is '0')
                {
                    c = (carrier ? "0" : "1") + c;
                }
                else
                {
                    c = (carrier ? "1" : "0") + c;
                    carrier = true;
                }
            }

            if (carrier) c = "1" + c;
            
            return c;
        }
    }
}
