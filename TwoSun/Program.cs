using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSun
{
    class Program
    {
        public static int[] _nums = { 2, 7, 11, 15 };
        public static int _target = 9;
        static void Main(string[] args)
        {
            int[] arr=TwoSum(_nums, _target);
            foreach (var a in arr)
            {
                Console.WriteLine($"{a}");
            }
            Console.ReadKey();
        }
        public static int [] TwoSum(int[] nums,int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for(int i=0;i<nums.Length;i++)
            {
                int result = target - nums[i];
                if(dic.ContainsKey(result))
                {
                    return new int[] { dic[result], i };
                }
                dic.Add(nums[i], i);
            }
            return null;
        }
    }
}
