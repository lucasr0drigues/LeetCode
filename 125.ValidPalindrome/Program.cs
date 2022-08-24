//Input: s = "A man, a plan, a canal: Panama"
//Output: true
//Explanation: "amanaplanacanalpanama" is a palindrome.
Console.WriteLine(new Solution().IsPalindrome("A man, a plan, a canal: Panama"));

//Input: s = "race a car"
//Output: false
//Explanation: "raceacar" is not a palindrome.
Console.WriteLine(new Solution().IsPalindrome("raceacar"));

//Input: s = " "
//Output: true
//Explanation: s is an empty string "" after removing non-alphanumeric characters.
//Since an empty string reads the same forward and backward, it is a palindrome.
Console.WriteLine(new Solution().IsPalindrome(" "));

public class Solution
{
    public bool IsPalindrome(string s)
    {
        if (s.Length < 2)
            return true;

        s = s.ToLower();
        var l = 0;
        var r = s.Length - 1;

        while (l < r)
        {
            while (l < r && !isAlphaNumeric(s[l]))
            {
                l++;
            }

            while (r > l && !isAlphaNumeric(s[r]))
            {
                r--;
            }

            if (s[l] != s[r])
                return false;

            l++;
            r--;
        }

        return true;
    }

    public bool isAlphaNumeric(char s)
    {
        if ((s >= '0' && s <= '9') || (s >= 'A' && s <= 'Z') || (s >= 'a' && s <= 'z'))
            return true;

        return false;
    }

}