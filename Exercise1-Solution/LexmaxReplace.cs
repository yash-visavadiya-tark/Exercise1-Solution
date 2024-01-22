using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_Solution
{
    public class LexmaxReplace
    {
        public String Get(String s, String t)
        {
            //t = SortInDescendingOrder(t);

            var extraString = (from ch in t
                 orderby ch descending
                 select ch).ToList();

            StringBuilder ans = new StringBuilder();
            int sIndex = 0, extraStringIndex = 0;

            while (sIndex < s.Length && extraStringIndex < extraString.Count)
            {
                if (s[sIndex] >= extraString[extraStringIndex])
                {
                    ans.Append(s[sIndex]);
                    sIndex++;
                }
                else
                {
                    ans.Append(extraString[extraStringIndex]);
                    sIndex++;
                    extraStringIndex++;
                }
            }
            ans.Append(s.Substring(sIndex));

            return ans.ToString();
        }

    }
}
