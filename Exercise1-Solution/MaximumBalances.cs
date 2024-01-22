using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_Solution
{
    public class MaximumBalances
    {
        public int Solve(String s)
        {
            int ans = 0;
            int openingBracketCount = (from ch in s
                                      where ch == '('
                                      select ch).Count();

            int closingBracketCount = (from ch in s
                                       where ch == ')'
                                       select ch).Count();

            //foreach (char c in s)
            //{
            //    if (c == '(')
            //        openingBracketCount++;
            //    else
            //        closingBracketCount++;
            //}

            ans = Math.Min(openingBracketCount, closingBracketCount);
            return ans * (ans + 1) / 2;
        }
    }
}
