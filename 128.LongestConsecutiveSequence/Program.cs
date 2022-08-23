//Input: nums = [100, 4, 200, 1, 3, 2]
//Output: 4
//Explanation: The longest consecutive elements sequence is [1, 2, 3, 4]. Therefore its length is 4.
Console.WriteLine(new Solution().LongestConsecutive(new int[] { 100, 4, 200, 1, 3, 2 }));


//Input: nums = [0, 3, 7, 2, 5, 8, 4, 6, 0, 1]
//Output: 9
Console.WriteLine(new Solution().LongestConsecutive(new int[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 }));

public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        if (nums.Length == 0)
            return 0;

        var hashSet = new HashSet<int>(nums);
        var longest = 0;

        foreach (var item in nums)
        {
            if(!hashSet.Contains(item-1))
            {
                var length = 1;

                while(hashSet.Contains(item+length))
                    length++;

                if (length > longest)
                    longest = length;

            }
        }

        return longest;
    }
}