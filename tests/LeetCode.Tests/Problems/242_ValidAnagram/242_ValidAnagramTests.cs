using LeetCode.Problems._242_ValidAnagram;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests.Problems._242_ValidAnagram
{
    public class _242_ValidAnagramTests
    {
        [Theory]
        [InlineData("anabram", "anagram", false)]
        [InlineData("anagram", "naagram", true)]
        [InlineData("rat", "car", false)]
        public void IsAnagramTests(string s, string t, bool output)
        {
            var result = new _242_ValidaAnagramSolution().IsAnagram(s, t);

            Assert.Equal(output, result);
        }
    }
}
