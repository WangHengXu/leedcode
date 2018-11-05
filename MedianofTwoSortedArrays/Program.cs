using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedianofTwoSortedArrays
{
    /*  给定两个大小为 m 和 n 的有序数组 nums1 和 nums2 。

  请找出这两个有序数组的中位数。要求算法的时间复杂度为 O(log (m+n)) 。

  你可以假设 nums1 和 nums2 不同时为空。

  示例 1:

  nums1 = [1, 3]
      nums2 = [2]

      中位数是 2.0
  示例 2:

  nums1 = [1, 2]
      nums2 = [3, 4]

      中位数是(2 + 3)/2 = 2.5*/
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int m = nums1.Length;
            int n = nums2.Length;
            if(m>n)
            {
                int[] temp = nums1;
                nums1 = nums2;
                nums2 = temp;
                int t = m;
                m = n;
                n = t;
            }
            int iMin = 0, iMax = m,halflen = (m + n + 1) / 2;
            while(iMin<=iMax)
            {
                int i = (iMin + iMax) / 2;
                int j = halflen - i;
                if (i < iMax && nums1[i] < nums2[j - 1])
                    iMin = i + 1;
                if (i > iMin && nums1[i - 1] > nums2[j])
                    iMax = i - 1;
                else
                {
                    int maxLeft = 0;
                    if (i == 0) { maxLeft = nums2[j - 1]; }
                    else if (j == 0) { maxLeft = nums1[i - 1]; }
                    else { maxLeft = Math.Max(nums1[i - 1], nums2[j - 1]); }
                    if ((m + n) % 2 == 1) { return maxLeft; }

                    int minRight=0;

                    if (i == m) { minRight = nums2[j]; }
                    if (j == n) { minRight = nums1[i]; }
                    else { minRight = Math.Min(nums1[i], nums2[j]); }
                    return (maxLeft + minRight) / 2.0;

                }
            }
            return 0.0;
        }
    }
}
