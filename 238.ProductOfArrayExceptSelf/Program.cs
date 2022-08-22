//Input: nums = [1, 2, 3, 4]
//Output: [24,12,8,6]
var test = new Solution().ProductExceptSelf(new int[] { 1, 2, 3, 4 });
Array.ForEach(test, Console.WriteLine);
Console.WriteLine();

//Input: nums = [-1, 1, 0, -3, 3]
//Output: [0,0,9,0,0]
test = new Solution().ProductExceptSelf(new int[] { -1, 1, 0, -3, 3 });
Array.ForEach(test, Console.WriteLine);

public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        var result = new int[nums.Length];
        var prefix = 1;

        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = prefix;
            prefix *= nums[i];
        }

        var postfix = 1;
        for (int i = nums.Length-1; i >= 0; i--)
        {
            result[i] *= postfix;
            postfix *= nums[i];
        }

        return result;

    }
}