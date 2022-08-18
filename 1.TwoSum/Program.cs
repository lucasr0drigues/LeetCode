//Input: nums = [2, 7, 11, 15], target = 9
//Output: [0,1]
//Explanation: Because nums[0] +nums[1] == 9, we return [0, 1].
Array.ForEach( new Solution().TwoSum(new int[] { 2, 7, 11, 15 }, 9),Console.WriteLine);
Console.WriteLine();
//Input: nums = [3, 2, 4], target = 6
//Output: [1,2]
Array.ForEach(new Solution().TwoSum(new int[] { 3,2,4 }, 6), Console.WriteLine);
Console.WriteLine();
//Input: nums = [3, 3], target = 6
//Output: [0,1]
Array.ForEach(new Solution().TwoSum(new int[] { 3,3 }, 6), Console.WriteLine);
Console.WriteLine();

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] answer = new int[2];

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (i == j)
                    continue;

                if (nums[i] + nums[j] == target)
                {
                    answer[0]=i;
                    answer[1]=j;
                    return answer;
                }


            }
        }

        return answer;

    }
}