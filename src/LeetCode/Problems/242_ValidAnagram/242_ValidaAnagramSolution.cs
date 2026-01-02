using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems._242_ValidAnagram
{
    public class _242_ValidaAnagramSolution
    {
        public static bool IsAnagram(string s, string t)
        {
            if(s.Length != t.Length)
                return false;

            var dictionary = new Dictionary<char, int>();

            for(var i = 0; i < s.Length; i++)
            {
                dictionary[s[i]]++;
            }

            return true;
        }
    }
}
