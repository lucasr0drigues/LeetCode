//Input: s = "anagram", t = "nagaram"
//Output: true
Console.WriteLine(new Solution().IsAnagram("anagram", "nagaram"));

//Input: s = "rat", t = "car"
//Output: false
Console.WriteLine(new Solution().IsAnagram("rat", "car"));

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        // ** MY SECOND SOLUTION - UNICODE FOLLOWUP ANSWER (SHOULD CONVERT TO CHAR) **

        if (s.Length != t.Length)
            return false;

        var dic = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            dic[s[i]] = dic.GetValueOrDefault(s[i]) + 1;
            dic[t[i]] = dic.GetValueOrDefault(t[i]) - 1;
        }

        foreach (var item in dic)
        {
            if (item.Value != 0)
                return false;
        }

        return true;




        // ** LETTERS ONLY LOWERCASE ONLY ANSWER **

        //if (s.Length != t.Length)
        //    return false;

        //int[] freq = new int[26];
        //for (int i = 0; i < s.Length; i++)
        //{
        //    freq[s[i] - 'a']++;
        //    freq[t[i] - 'a']--;
        //}

        //foreach (var f in freq)
        //{
        //    if (f != 0)
        //        return false;
        //}

        //return true;




        // ** MY FIRST SOLUTION **

        //char[] sArr = s.ToCharArray();
        //Array.Sort(sArr);
        //s = new string(sArr);

        //char[] tArr = t.ToCharArray();
        //Array.Sort(tArr);
        //t = new string(tArr);

        //if (s.Equals(t))
        //    return true;

        //return false;
    }
}