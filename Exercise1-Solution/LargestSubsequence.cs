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
            var largestString = new StringBuilder();
            Stack<char> stack = new Stack<char>();

            int index = 0;
            while (index < s.Length)
            {
                while (stack.Count > 0 && stack.Peek().CompareTo(s[index]) < 0)
                {
                    stack.Pop();
                }
                stack.Push(s[index]);
                index++;
            }

            while (stack.Count > 0)
            {
                largestString.Append(stack.Pop());
            }

            return new String(largestString.ToString().Reverse().ToArray());
        }
    }
}
