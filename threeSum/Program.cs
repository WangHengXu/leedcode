using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threeSum
{
    /*
     给定一个包含 n 个整数的数组 nums，判断 nums 中是否存在三个元素 a，b，c ，使得 a + b + c = 0 ？找出所有满足条件且不重复的三元组。

注意：答案中不可以包含重复的三元组。

例如, 给定数组 nums = [-1, 0, 1, 2, -1, -4]，

满足要求的三元组集合为：
[
  [-1, 0, 1],
  [-1, -1, 2]
]*/
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { -1, 0, 1, 2, -1, -4 };
            IList<IList<int>>  t=ThreeSum(nums);
        }
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            List<List<int>> result = new List<List<int>>();
            List<int> temp = new List<int>();
            List<int> listA = nums.ToList();
            List<int> negativeList = listA.FindAll((i) => i < 0);
            List<int> plusList = listA.FindAll((i) => i > 0);
            List<int> negativeListDistinct = negativeList.Distinct().ToList();
            List<int> plusListDistinct = plusList.Distinct().ToList();
            negativeList.Sort();
            plusList.Sort();
            if (nums.Contains(0))
            {
                foreach (int item in negativeListDistinct)
                {
                    temp = new List<int>();
                    if(Math.Abs(item)>=plusList.Max())
                    {
                        break;
                    }
                    if (plusList.Contains(Math.Abs(item)))
                    {
                        temp.Add(item);
                        temp.Add(0);
                        temp.Add(Math.Abs(item));
                        result.Add(temp);
                    }
                }
            }
        
            for (int i = 0; i < negativeList.Count; i++)
            {
                while (negativeList[i] == negativeList[i + 1] )
                {
                   
                    if (i>=negativeList.Count - 2)
                        break;
                    i++;
                }
             
                for (int j = i + 1; j < negativeList.Count; j++)
                {
                    temp = new List<int>();
                    int sum = negativeList[i] + negativeList[j];
                    if (Math.Abs(sum) >= plusList.Max())
                    {
                        break;
                    }
                    if (plusList.Contains(Math.Abs(sum)))
                    {
                        temp.Add(negativeList[i]);
                        temp.Add(negativeList[j]);
                        temp.Add(Math.Abs(sum));
                        result.Add(temp);
                    }
                }
              
            }

            for (int i = 0; i < plusList.Count; i++)
            {
                while (plusList[i] == plusList[i + 1] )
                {
                    
                    if (i >= plusList.Count - 2)
                        break;
                    i++;
                }
              
                for (int j = i + 1; j < plusList.Count; j++)
                {
                    temp = new List<int>();
                    int sum = plusList[i] + plusList[j];
                    sum = -sum;
                    if (sum <= negativeList.Min())
                    {
                        break;
                    }
                    if (negativeList.Contains(sum))
                    {
                        temp.Add(plusList[i]);
                        temp.Add(plusList[j]);
                        temp.Add(sum);
                        result.Add(temp);
                    }
                }

            }

            return result as IList<IList<int>>;
           
           
        }
    }
}
