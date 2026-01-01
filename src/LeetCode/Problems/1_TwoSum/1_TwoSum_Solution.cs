using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems._1_TwoSum
{
    public class _1_TwoSum_Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dictionary = new Dictionary<int, int>();

            for(var i = 0; i < nums.Length; i++)
            {
                var missing = target - nums[i];

                if(dictionary.ContainsKey(missing))
                    return new int[] { dictionary[missing], i };

                dictionary[nums[i]] = i;
            }

            return new int[] { };
        }
    }
}
