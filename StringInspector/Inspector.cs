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
        private Dictionary<Char, int> _frequency;
        private Char _mostUsed;

        public Inspector(string article)
        {
            _text = new StringBuilder(article);
            _frequency = new Dictionary<char, int>();
            _mostUsed = Parse();
        }

        public void Append(string text)
        {
            _text = new StringBuilder(text);
            _mostUsed = Parse();
        }

        public Char Parse()
        {
            //loop though all the characters of the given text
            foreach (Char c in _text.ToString())
            {    
                if (_frequency.ContainsKey(c))
                {
                    //if we previously found the character, add 1 to the count
                    _frequency[c]++;
                }
                else
                {
                    //First time seeing this character, lets add it
                    _frequency.Add(c, 1);
                }

                //Check if the current character is now the "most frequent"
                if (_mostUsed == '\0' || _frequency[c] > _frequency[_mostUsed])
                    _mostUsed = c;
            }

            return GetMostUsed();
        }

        public Char GetMostUsed()
        {
            return _mostUsed;
        }

        public override string ToString()
        {
            StringBuilder results = new StringBuilder();

            //loop through the dictionary and display each character that was in the article and the number of times it was found
            foreach (KeyValuePair<Char, int> kvp in _frequency)
            {
                results.AppendFormat("({0}, {1})", kvp.Key, kvp.Value);
            }

            return results.ToString();
        }

    }
}
