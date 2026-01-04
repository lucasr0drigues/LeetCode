using LeetCode.Problems._49_GroupAnagrams;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Tests.Problems._49_GroupAnagrams
{
    public class _49_GroupAnagramsTests
    {
        public static IEnumerable<object[]> GroupAnagramsCases =>
        new List<object[]>
        {
            new object[]
            {
                new[] { "act", "pots", "tops", "cat", "stop", "hat" },
                new[]{new[] { "hat" },new[] { "act", "cat" }, new[] { "stop", "pots", "tops" }}
            },
            new object[]
            {
                new[] { "x" },
                new[]{ new[] { "x" }}
            },
            new object[]
            {
                new[] { "" },
                new[]{ new[] { "" }}
            }
        };

        [Theory]
        [MemberData(nameof(GroupAnagramsCases))]
        public void GroupAnagrams_Test(string[] input, string[][] output)
        {
            var solution = new _49_GroupAnagramsSolution();

            var result = solution.GroupAnagrams(input);

            var orderedOutput = output
                .Select(g => g.OrderBy(x => x).ToArray())
                .OrderBy(g => g.Length)
                .ThenBy(g => string.Join(",", g))
                .ToArray();

            var orderedResult = result
                .Select(g => g.OrderBy(x => x).ToArray())
                .OrderBy(g => g.Length)
                .ThenBy(g => string.Join(",", g))
                .ToArray();

            Assert.Equal(orderedOutput, orderedResult);
        }
    }
}
