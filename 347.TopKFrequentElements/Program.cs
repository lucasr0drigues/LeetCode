//Input: nums = [1, 1, 1, 2, 2, 3], k = 2
//Output: [1,2]
var result = new Solution().TopKFrequent(new int[] { 1, 1, 1, 2, 2, 3 }, 2);
Array.ForEach(result, Console.WriteLine);
Console.WriteLine();

//Input: nums = [1], k = 1
//Output: [1]
result = new Solution().TopKFrequent(new int[] { 1 }, 1);
Array.ForEach(result, Console.WriteLine);
Console.WriteLine();

//Input
//[1, 2]
//2
//Output
//[2]
//Expected
//[1, 2]
result = new Solution().TopKFrequent(new int[] { 1, 2 }, 2);
Array.ForEach(result, Console.WriteLine);

public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        // MY ANSWER BASED ON NEETCODE, USING INVERSE BUCKET SORT
        var dic = new Dictionary<int, int>();
        var freq = new List<int>[nums.Length + 1];

        for (int i = 0; i < nums.Length; i++)
        {
            if (!dic.ContainsKey(nums[i]))
                dic.Add(nums[i], 1);
            else
            dic[nums[i]] += 1;
        }

        foreach (var item in dic)
        {
            if (freq[item.Value] == null)
                freq[item.Value] = new List<int> { item.Key };
            else
                freq[item.Value].Add(item.Key);
        }

        var result = new List<int>();

        for (int i = freq.Length - 1; i >= 0; i--)
        {
            if (freq[i] != null)
            {
                foreach (var item in freq[i])
                {
                    result.Add(item);
                    if (result.Count == k)
                        return result.ToArray();
                }
            }
        }

        return result.ToArray();
    }
}