using Desk.Gist.LeetCode.ProblemSet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Desk.Gist.Test.LeetCode.ProblemSet
{
    public class LC0001_TwoSum_Test
    {
        [Fact]
        public void Test()
        {
            // Arrange
            int[] nums = { 1, 3, 2, 9, 8, 6, 7, 5 };
            int target = 16;
            int[] expected = { 3, 6 };

            // Act
            var result1 = LC0001_TwoSum.TwoSum_1(nums, target).OrderBy(x => x);
            var result2 = LC0001_TwoSum.TwoSum_2(nums, target).OrderBy(x => x);
            var result3 = LC0001_TwoSum.TwoSum_3(nums, target).OrderBy(x => x);

            // Assert
            Assert.Equal(expected, result1);
            Assert.Equal(expected, result2);
            Assert.Equal(expected, result3);
        }
    }
}
