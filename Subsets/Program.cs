using System;
using System.Collections.Generic;
using System.Linq;
namespace Subsets
{
    /*
     * 给定一组不含重复元素的整数数组 nums，返回该数组所有可能的子集（幂集）。

说明：解集不能包含重复的子集。

示例:

输入: nums = [1,2,3]
输出:
[
  [3],
  [1],
  [2],
  [1,2,3],
  [1,3],
  [2,3],
  [1,2],
  []
]

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/subsets
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] t = {4,1,0};
            Subsets(t);
        }
        public static IList<IList<int>> Subsets(int[] nums)
        {
            IList<IList<int>> res = new List<IList<int>>();
            Array.Sort<int>(nums);
            Helper(0, nums, res, new List<int>());
            return res ;
        }
        public static void Helper(int i, int[] nums, IList<IList<int>> res, List<int> tmp)
        {
            res.Add(new List<int>(tmp));
            for (int j = i; j < nums.Length; j++)
            {
                tmp.Add(nums[j]);
                Helper(j + 1, nums, res, tmp);
                tmp.RemoveAt(tmp.Count - 1);
                //重复项处理
                while (j+1<nums.Length&&nums[j]==nums[j+1])
                {
                    j++;
                }
            }
        }
    }
}
