//Input: nums = [1, 2, 3, 1]
//Output: true
Console.WriteLine(new Solution().ContainsDuplicate(new int[] {1,2,3,1}));

//Input: nums = [1, 2, 3, 4]
//Output: false
Console.WriteLine(new Solution().ContainsDuplicate(new int[] { 1,2,3,4 }));

//Input: nums = [1, 1, 1, 3, 3, 4, 3, 2, 4, 2]
//Output: true
Console.WriteLine(new Solution().ContainsDuplicate(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }));

public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        var dic = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (dic.ContainsKey(nums[i]))
                return true;

            dic.Add(nums[i], i);
        }

        return false;
    }
}