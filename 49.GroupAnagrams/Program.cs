//Input: strs = ["eat", "tea", "tan", "ate", "nat", "bat"]
//Output: [["bat"],["nat","tan"],["ate","eat","tea"]]
var teste = new Solution().GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });
foreach (var item in teste)
{
    Console.WriteLine(string.Join(" ,",item));
}
Console.WriteLine();

//Input: strs = [""]
//Output: [[""]]
teste = new Solution().GroupAnagrams(new string[] { });
foreach (var item in teste)
{
    Console.WriteLine(string.Join(" ,", item));
}
Console.WriteLine();

//Input: strs = ["a"]
//Output: [["a"]]
teste = new Solution().GroupAnagrams(new string[] { "a" });
foreach (var item in teste)
{
    Console.WriteLine(string.Join(" ,", item));
}
Console.WriteLine();

//Input:
//["bdddddddddd","bbbbbbbbbbc"]
//Output:
//[["bdddddddddd","bbbbbbbbbbc"]]
//Expected:
//[["bbbbbbbbbbc"],["bdddddddddd"]]
teste = new Solution().GroupAnagrams(new string[] { "bdddddddddd", "bbbbbbbbbbc" });
foreach (var item in teste)
{
    Console.WriteLine(string.Join(" ,", item));
}
Console.WriteLine();

public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var result = new Dictionary<string, IList<string>>();

        foreach (var word in strs)
        {
            int[] count = new int[26];

            foreach (var letter in word)
            {
                count[letter - 'a'] += 1;
            }

            var key = string.Join(" ", count);

            if (!result.ContainsKey(key))
                result[key] = new List<string>();

            result[key].Add(word);
        }

        return result.Values.ToList();



        // ** ANOTHER WAY OF DOING IT THAT USES LINQ TO ORDER THE DICTIONARY KEY **

        //if (strs == null || strs.Length == 0)
        //    return new List<IList<string>>();

        //List<IList<string>> res = new List<IList<string>>();
        //Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

        //foreach (var str in strs)
        //{
        //    string cur = new string(str.OrderBy(x => x).ToArray());

        //    if (!dict.ContainsKey(cur))
        //        dict.Add(cur, new List<string>());

        //    dict[cur].Add(str);
        //}

        //foreach (var item in dict.Values)
        //    res.Add(item);

        //return res;
    }
}