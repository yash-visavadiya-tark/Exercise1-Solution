using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_Solution
{
    public class Mailbox
    {
        private Dictionary<char, int> CountMap(String s, char ignore = ' ')
        {
            Dictionary<char, int> count = new Dictionary<char, int>();

            foreach (char ch in s)
            {
                if (ch == ignore)
                    continue;
                if (count.Keys.Contains(ch))
                    count[ch]++;
                else
                    count[ch] = 1;
            }
            return count;
        }

        private bool CheckIfPossible(Dictionary<char, int> current, Dictionary<char, int> collection)
        {
            foreach (char ch in current.Keys)
            {
                if (!(collection.ContainsKey(ch) && collection[ch] >= current[ch]))
                {
                    return false;
                }
            }
            return true;
        }

        public int Impossible(String collection, String[] address)
        {
            int ans = 0;
            Dictionary<char, int> collectionCount = CountMap(collection);

            foreach (String s in address)
            {
                Dictionary<char, int> currentCount = CountMap(s);

                if(!CheckIfPossible(currentCount, collectionCount)){
                    ans++;
                }
            }

            return ans;
        }
    }
}
