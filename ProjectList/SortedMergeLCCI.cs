﻿using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;

namespace ProjectList
{
    /*
     * 给定两个排序后的数组 A 和 B，其中 A 的末端有足够的缓冲空间容纳 B。 编写一个方法，将 B 合并入 A 并排序。

初始化 A 和 B 的元素数量分别为 m 和 n。

示例:

输入:
A = [1,2,3,0,0,0], m = 3
B = [2,5,6],       n = 3

输出: [1,2,2,3,5,6]

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/sorted-merge-lcci
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
     */

    public class SortedMergeLCCI
    {
        public void Merge(int[] A, int m, int[] B, int n)
        {

            int sum = m + n - 1;
            int Aright = m - 1, Bright = n - 1;
           
            while (true)
            {
                A[sum--] = Aright < 0 ? B[Bright--] : A[Aright] < B[Bright] ? B[Bright--] : A[Aright--];
                if (Aright < 0)
                {
                    for (int j = 0; j <= sum; j++)
                    {
                        A[j] = B[j];
                    }
                    break;
                }
                if (Bright < 0)
                {
                    break;
                }
                if (A[Aright] < B[Bright])
                {
                    A[sum ] = B[Bright];
                    Bright--;
                }
                else
                {
                    A[sum ] = A[Aright];
                    Aright--;
                }
                sum--;


            }
            //while (Bright >= 0)
            //{
            //    A[sum--] = Aright < 0 ? B[Bright--] : A[Aright] < B[Bright] ? B[Bright--] : A[Aright--];
            //}
        }
    }
}