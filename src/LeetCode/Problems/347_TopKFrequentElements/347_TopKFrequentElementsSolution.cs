using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LeetCode.Problems._347_TopKFrequentElements
{
    public class _347_TopKFrequentElementsSolution
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            if(nums.Length == 1)
                return nums;

            var count = new Dictionary<int, int>();
            List<int>[] freq = new List<int>[nums.Length +1];

            for(int i = 0; i < freq.Length; i++)
            {
                freq[i] = new List<int>();
            }

            foreach(var num in nums)
            {
                if (count.ContainsKey(num))
                    count[num]++;
                else
                    count[num] = 1;
            }

            foreach(var entry in count)
            {
                freq[entry.Value].Add(entry.Key);
            }

            var result = new int[k];

            int index = 0;
            for (int i = freq.Length - 1; i > 0 && index < k; i--)
            {
                foreach (int n in freq[i])
                {
                    result[index++] = n;
                    if (index == k)
                    {
                        return result;
                    }
                }
            }
            return result;
        }
    }
}
