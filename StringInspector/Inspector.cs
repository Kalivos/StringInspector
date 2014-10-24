using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInspector
{
    public class Inspector
    {
        private StringBuilder _text;
        private Dictionary<Char, int> _characterCounts;
        private Char _mostUsed;

        /// <summary>
        /// Class for determining which character occurs the most often in a string. 
        /// </summary>
        /// <param name="article">text to search</param>
        public Inspector(string article)
        {
            _text = new StringBuilder(article);
            _characterCounts = new Dictionary<char, int>();
            _mostUsed = Parse();
        }

        /// <summary>
        /// Appends additional text that should be added to the already existing results.
        /// Does NOT reset character counts.
        /// </summary>
        /// <param name="text">Text that should be added </param>
        public void Append(string text)
        {
            _text = new StringBuilder(text);
            _mostUsed = Parse();
        }

        /// <summary>
        /// Parses a string to find the number of times each character in the article is used
        /// </summary>
        /// <returns>Most used character</returns>
        public Char Parse()
        {
            //loop though all the characters of the given text
            foreach (Char c in _text.ToString())
            {    
                if (_characterCounts.ContainsKey(c))
                {
                    //if we previously found the character, add 1 to the count
                    _characterCounts[c]++;
                }
                else
                {
                    //First time seeing this character, lets add it
                    _characterCounts.Add(c, 1);
                }

                //Check if the current character is now the most common
                if (_mostUsed == '\0' || _characterCounts[c] > _characterCounts[_mostUsed])
                    _mostUsed = c;
            }

            return GetMostUsed();
        }

        /// <summary>
        /// Most used character in the given article
        /// </summary>
        /// <returns>Most used character</returns>
        public Char GetMostUsed()
        {
            return _mostUsed;
        }

        /// <summary>
        /// Returns the number of times the most used character was found
        /// </summary>
        /// <returns>Number of occurrences</returns>
        public int GetNumberTimesUsed()
        {
            return GetNumberTimesUsed(_mostUsed);
        }

        /// <summary>
        /// Returns the number of times a character was found
        /// </summary>
        /// <param name="character">The character whos times found is being requested</param>
        /// <returns>Number of occurrences</returns>
        public int GetNumberTimesUsed(Char character)
        {
            int count = 0;

            //check if character is in dictionary prior to pulling value
            if (character != '\0' && _characterCounts.ContainsKey(character))
                count = _characterCounts[character];

            return count;
        }

        /// <summary>
        /// Returns a string of all characters found and the number of times they were used.
        /// </summary>
        /// <returns>String: (Key, Value)</returns>
        public override string ToString()
        {
            StringBuilder results = new StringBuilder();

            //loop through the dictionary and display each character that was in the article and the number of times it was found
            foreach (KeyValuePair<Char, int> kvp in _characterCounts)
            {
                results.AppendFormat("({0}, {1})", kvp.Key, kvp.Value);
            }

            return results.ToString();
        }

    }
}
