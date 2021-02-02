using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Gist.LeetCode.ProblemSet
{
    /// <summary>
    /// Q：https://leetcode-cn.com/problems/two-sum/
    /// A：https://leetcode-cn.com/problems/two-sum/solution/leetcode-1-two-sum-liang-shu-zhi-he-c-ha-xi-biao-d/
    /// </summary>
    public class LC0001_TwoSum
    {
        // Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        // You may assume that each input would have exactly one solution, and you may not use the same element twice.
        // You can return the answer in any order.


        public static int[] TwoSum_1(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { 0, 0 };
        }

        public static int[] TwoSum_2(int[] nums, int target)
        {
            Dictionary<int, int> kvs = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                // 需要对重复值进行判断；因为结果的唯一，所以若有重复值，且答案中包含了重复值的话，说明必有 重复值*2==target; 否则直接忽略重复值即可
                if (kvs.ContainsKey(nums[i]))
                {
                    if (nums[i] * 2 == target)
                    {
                        return new int[] { i, kvs[nums[i]] };
                    }
                }
                else
                {
                    kvs.Add(nums[i], i);
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (kvs.ContainsKey(complement) && kvs[complement] != i)
                {
                    return new int[] { i, kvs[complement] };
                }
            }
            return new int[] { 0, 0 };
        }

        public static int[] TwoSum_3(int[] nums, int target)
        {
            Dictionary<int, int> kvs = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (kvs.ContainsKey(complement) && kvs[complement] != i)
                {
                    return new int[] { i, kvs[complement] };
                }
                // 需要对重复值进行判断,若结果包含了重复值，则已经被上面给return了；所以此处对于重复值直接忽略
                if (!kvs.ContainsKey(nums[i]))
                {
                    kvs.Add(nums[i], i);
                }
            }
            return new int[] { 0, 0 };
        }
    }
}
