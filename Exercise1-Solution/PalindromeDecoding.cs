using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_Solution
{
    public class PalindromeDecoding
    {
        private StringBuilder MakePalindrome(StringBuilder s, int position, int length)
        {
            var palindrome = new StringBuilder("");
            for (int i = position; i < position + length; i++)
            {
                palindrome.Append(s[i]);
            }
            return palindrome;
        }

        private void ReversePalindrome(StringBuilder palindrome)
        {
            for (int j = 0; j < palindrome.Length / 2; j++)
            {
                char copy = palindrome[j];
                palindrome[j] = palindrome[palindrome.Length - 1 - j];
                palindrome[palindrome.Length - 1 - j] = copy;
            }
        }

        public String Decode(String code, int[] position, int[] length)
        {
            StringBuilder ans = new StringBuilder(code);

            for (int i = 0; i < position.Length; i++)
            {
                StringBuilder palindrome = MakePalindrome(ans, position[i], length[i]);
                ReversePalindrome(palindrome);
                ans.Insert(position[i] + length[i], palindrome.ToString());
            }
            return ans.ToString();
        }
    }
}
