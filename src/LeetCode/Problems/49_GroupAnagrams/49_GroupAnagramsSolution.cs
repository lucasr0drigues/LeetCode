using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace LeetCode.Problems._49_GroupAnagrams
{
    public class _49_GroupAnagramsSolution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            if(strs.Length <= 1)
                return new List<IList<string>>() { new List<string>() { strs.FirstOrDefault()! } };

            var result = new Dictionary<string, IList<string>>();

            foreach(var word in strs)
            {
                int[] count = new int[26];
                //char[] count = new char[26]; // use char array to have a lower runtime

                foreach (var letter in word)
                {
                    count[letter - 'a'] += 1;
                    //count[letter - 'a']++;
                }

                var key = string.Join(" ", count);
                //string key = new string(count);

                if (!result.ContainsKey(key))
                    result[key] = new List<string>();

                result[key].Add(word);
            }

            return result.Values.ToList();
        }
    }
}
