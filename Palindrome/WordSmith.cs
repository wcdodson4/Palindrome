using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Palindrome
{
    public class WordSmith
    {
        public WordSmith()
        {

        }
        public bool IsAPalindrome(string word)
        {
            return word.SequenceEqual(word.Reverse());
        }
    }

    
}
