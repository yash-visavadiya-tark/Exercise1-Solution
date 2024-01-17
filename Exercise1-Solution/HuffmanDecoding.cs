using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_Solution
{
    public class HuffmanDecoding
    {
        private Dictionary<String, char> MapDictionaryToString(String[] dictionary)
        {
            var map = new Dictionary<String, char>();
            int i = 0;

            foreach (String word in dictionary)
            {
                map[word] = (char)(i++ + 65);
            }

            return map;
        }

        public String Decode(String archive, String[] dictionary)
        {
            var map = MapDictionaryToString(dictionary);
            var decodedString = new StringBuilder();

            String word = "";
            foreach (char ch in archive)
            {
                word += ch;
                if (map.ContainsKey(word))
                {
                    decodedString.Append(map[word]);
                    word = "";
                }
            }
            return decodedString.ToString();
        }
    }
}
