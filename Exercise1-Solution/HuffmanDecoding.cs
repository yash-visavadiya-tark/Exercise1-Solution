using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_Solution
{
    public class HuffmanDecoding
    {
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
            int asciiValue = 65;
            Dictionary<String, char> mapDictionary = dictionary.ToDictionary(key => key, value => (char)(asciiValue++)); ;

            return DecodeHuffmanString(archive, mapDictionary);
        }
    }
}
