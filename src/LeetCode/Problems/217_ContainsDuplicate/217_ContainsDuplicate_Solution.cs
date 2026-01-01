using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems._217_ContainsDuplicate
{
    public class _217_ContainsDuplicate_Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            var hashSet = new HashSet<int>();

            foreach (int i in nums)
            {
                if(hashSet.Contains(i))
                    return true;

                hashSet.Add(i);
            }

            return false;
        }

        //public bool ContainsDuplicate(int[] nums)
        //{
        //    var dictionary = new Dictionary<int, int>();

        //    for(int i = 0; i < nums.Length; i++)
        //    {
        //        if (dictionary.ContainsKey(nums[i]))
        //            return true;

        //        dictionary[nums[i]] = i;
        //    }

        //    return false;
        //}
    }
}
