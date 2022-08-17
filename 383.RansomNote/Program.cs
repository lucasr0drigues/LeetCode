//Input: ransomNote = "a", magazine = "b"
//Output: false
Console.WriteLine(new Solution().CanConstruct("a", "b"));

//Input: ransomNote = "aa", magazine = "ab"
//Output: false
Console.WriteLine(new Solution().CanConstruct("aa", "ab"));

//Input: ransomNote = "aa", magazine = "aab"
//Output: true
Console.WriteLine(new Solution().CanConstruct("aa", "aab"));


Console.WriteLine(new Solution().CanConstruct("abc", "aba"));

public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        var arrMagazine = magazine.ToCharArray();

        foreach (var item in ransomNote)
        {
            Array.Sort(arrMagazine);
            var index = Array.BinarySearch(arrMagazine, item);

            if (index < 0)
                return false;

            arrMagazine[index] = '\0';
            
        }

        return true;
    }
}