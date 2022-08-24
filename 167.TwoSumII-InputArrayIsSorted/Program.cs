//Input: numbers = [2, 7, 11, 15], target = 9
//Output: [1,2]
//Explanation: The sum of 2 and 7 is 9.Therefore, index1 = 1, index2 = 2.We return [1, 2].
var teste = new Solution().TwoSum(new int[] { 2, 7, 11, 15 }, 9);
Array.ForEach(teste, Console.WriteLine);
Console.WriteLine();

//Input: numbers = [2, 3, 4], target = 6
//Output: [1,3]
//Explanation: The sum of 2 and 4 is 6.Therefore index1 = 1, index2 = 3.We return [1, 3].
teste = new Solution().TwoSum(new int[] { 2, 3, 4 }, 6);
Array.ForEach(teste, Console.WriteLine);
Console.WriteLine();

//Input: numbers = [-1, 0], target = -1
//Output: [1,2]
//Explanation: The sum of - 1 and 0 is -1.Therefore index1 = 1, index2 = 2.We return [1, 2].
teste = new Solution().TwoSum(new int[] { -1, 0 }, -1);
Array.ForEach(teste, Console.WriteLine);
Console.WriteLine();

public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        var l = 0;
        var r = numbers.Length - 1;

        while (l < r)
        {
            if (numbers[l] + numbers[r] > target)
                r--;
            else if (numbers[l] + numbers[r] < target)
                l++;
            else
                return new int[] { l+1, r+1 };
        }

        return new int[] { };
    }
}