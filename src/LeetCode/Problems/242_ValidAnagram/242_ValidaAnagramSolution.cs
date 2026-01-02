using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems._242_ValidAnagram
{
    public class _242_ValidaAnagramSolution
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            var dic = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                dic[s[i]] = dic.GetValueOrDefault(s[i]) + 1;
                dic[t[i]] = dic.GetValueOrDefault(t[i]) - 1;
            }

            foreach (var value in dic.Values)
                if (value != 0)
                    return false;

            return true;

            //if (s.Length != t.Length)
            //    return false;

            //var dictionaryS = new Dictionary<char, int>();
            //var dictionaryT = new Dictionary<char, int>();

            //for (var i = 0; i < s.Length; i++)
            //{
            //    dictionaryS[s[i]] = dictionaryS.GetValueOrDefault(s[i]) + 1;
            //    dictionaryT[t[i]] = dictionaryT.GetValueOrDefault(t[i]) + 1;
            //}

            //return dictionaryS.Count == dictionaryT.Count && !dictionaryS.Except(dictionaryT).Any();
        }
    }
}
