using LeetCode.Problems._217_ContainsDuplicate;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests.Problems._217_ContainsDuplicate
{
    public class _217_ContainsDuplicateTests
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3, 1 }, true)]
        [InlineData(new[] { 1, 2, 3, 4 }, false)]
        [InlineData(new[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]
        public void ContainsDuplicateTest(int[] input, bool output)
        {
            var solution = new _217_ContainsDuplicate_Solution();

            Assert.Equal(output, solution.ContainsDuplicate(input));
        }
    }
}
