using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_Solution
{
    public class LexmaxReplace
    {
        private String SortStringInDescending(String t)
        {
            char[] arr = t.ToCharArray();
            Array.Sort(arr, new Comparison<char>((c1, c2) => c2.CompareTo(c1)));
            return new String(arr);
        }

        public String Get(String s, String t)
        {
            t = SortStringInDescending(t);

            StringBuilder ans = new StringBuilder("");
            int i = 0, j = 0;
            while (i < s.Length && j < t.Length)
            {
                if (s[i] >= t[j])
                {
                    ans.Append(s[i]);
                    i++;
                }
                else
                {
                    ans.Append(t[j]);
                    i++;
                    j++;
                }
            }
            ans.Append(s.Substring(i));

            return ans.ToString();
        }

    }
}
