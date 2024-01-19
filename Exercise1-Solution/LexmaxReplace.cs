using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_Solution
{
    public class LexmaxReplace
    {
        private String SortInDescendingOrder(String t)
        {
            char[] arr = t.ToCharArray();
            Array.Sort(arr, new Comparison<char>((c1, c2) => c2.CompareTo(c1)));
            return new String(arr);
        }

        public String Get(String s, String t)
        {
            t = SortInDescendingOrder(t);

            StringBuilder ans = new StringBuilder();
            int sIndex = 0, tIndex = 0;
            while (sIndex < s.Length && tIndex < t.Length)
            {
                if (s[sIndex] >= t[tIndex])
                {
                    ans.Append(s[sIndex]);
                    sIndex++;
                }
                else
                {
                    ans.Append(t[tIndex]);
                    sIndex++;
                    tIndex++;
                }
            }
            ans.Append(s.Substring(sIndex));

            return ans.ToString();
        }

    }
}
