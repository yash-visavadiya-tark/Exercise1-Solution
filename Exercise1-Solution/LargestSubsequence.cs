using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_Solution
{
    public class LargestSubsequence
    {
        public String GetLargest(String s)
        {
            var largestString = new StringBuilder("");
            int n = s.Length;
            Stack<char> st = new Stack<char>();

            int i = 0;
            while (i < n)
            {
                while (st.Count > 0 && st.Peek().CompareTo(s[i]) < 0)
                {
                    st.Pop();
                }
                st.Push(s[i]);
                i++;
            }

            while (st.Count > 0)
            {
                largestString.Append(st.Pop());
            }

            return new String(largestString.ToString().Reverse().ToArray());
        }
    }
}
