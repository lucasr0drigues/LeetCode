//Input: num = 14
//Output: 6
Console.WriteLine(new Solution().NumberOfSteps(14));

//Input: num = 8
//Output: 4
Console.WriteLine(new Solution().NumberOfSteps(8));

//Input: num = 123
//Output: 12
Console.WriteLine(new Solution().NumberOfSteps(123));

//Input: num = 0
//Output: 0
Console.WriteLine(new Solution().NumberOfSteps(0));

public class Solution
{
    public int NumberOfSteps(int num)
    {
        var count = 0;
        while (num > 0)
        {
            count++;
            if (num % 2 == 0)
                num = num / 2;
            else
                num = num - 1;
        }

        return count;
    }
}