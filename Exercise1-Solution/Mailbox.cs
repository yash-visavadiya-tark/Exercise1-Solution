using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_Solution
{
    public class Mailbox
    {
        private bool CheckIfPossible(Dictionary<char, int> current, Dictionary<char, int> collection)
        {
            int availableCharacters = current.Keys.Where(x => collection.ContainsKey(x) && collection[x] >= current[x]).Count();
            return  availableCharacters == current.Keys.Count();
        }

        public int Impossible(String collection, String[] address)
        {
            Dictionary<char, int> collectionCount = collection.GroupBy(x => x).
                                                                ToDictionary(g => g.Key, g => g.Count());

            int ans = 0;
            foreach (String s in address)
            {
                Dictionary<char, int> currentCount = s.GroupBy(x => x).
                                                        Where(x => x.Key != ' ').
                                                        ToDictionary(g => g.Key, g => g.Count());

                if(!CheckIfPossible(currentCount, collectionCount)){
                    ans++;
                }
            }

            return ans;
        }
    }
}
