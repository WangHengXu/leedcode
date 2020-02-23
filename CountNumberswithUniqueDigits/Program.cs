using System;

namespace CountNumberswithUniqueDigits
{
    /*
     * 给定一个非负整数 n，计算各位数字都不同的数字 x 的个数，其中 0 ≤ x < 10n 。

示例:

输入: 2
输出: 91
解释: 答案应为除去 11,22,33,44,55,66,77,88,99 外，在 [0,100) 区间内的所有数字。

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/count-numbers-with-unique-digits
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
     */

    internal class Program
    {
        public int CountNumbersWithUniqueDigits(int n)
        {
            if (n == 0) return 1;
            if (n == 1) return 10;
            int sum = 0 + 1 + 9;
            for (int i = 2; i <= n; i++)
            {
                sum = sum + 9 * JieCheng(i - 1);
            }
            return sum;
        }

        public int JieCheng(int k)
        {
            int sum = 1;
            for (int i = 9; 10 - k <= i; i--)
            {
                sum *= i;
            }
            return sum;
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}