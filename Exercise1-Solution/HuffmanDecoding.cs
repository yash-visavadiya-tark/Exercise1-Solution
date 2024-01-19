using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_Solution
{
    public class HuffmanDecoding
    {
        private Dictionary<String, char> MapDictionaryStringToChar(String[] dictionary)
        {
            var map = new Dictionary<String, char>();

            for (int i = 0; i < dictionary.Length; i++)
            {
                map[dictionary[i]] = (char)(i + 65);
            }
            return map;
        }

        private String DecodeHuffmanString(String archive, Dictionary<String, char> mapDictionary)
        {
            StringBuilder decodedString = new StringBuilder();
            StringBuilder decodeChar = new StringBuilder();

            foreach (char ch in archive)
            {
                decodeChar.Append(ch);
                if (mapDictionary.ContainsKey(decodeChar.ToString()))
                {
                    decodedString.Append(mapDictionary[decodeChar.ToString()]);
                    decodeChar.Clear();
                }
            }
            return decodedString.ToString();
        }

        public String Decode(String archive, String[] dictionary)
        {
            Dictionary<String, char> mapDictionary = MapDictionaryStringToChar(dictionary);

            return DecodeHuffmanString(archive, mapDictionary);
        }
    }
}
