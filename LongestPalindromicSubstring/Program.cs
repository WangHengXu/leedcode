using System;

namespace LongestPalindromicSubstring
{
    class Program
    {
        /*最长回文子串
         * 给定一个字符串 s，找到 s 中最长的回文子串。你可以假设 s 的最大长度为 1000。

示例 1：

输入: "babad"
输出: "bab"
注意: "aba" 也是一个有效答案。
示例 2：

输入: "cbbd"
输出: "bb"

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/longest-palindromic-substring
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LongestPalindrome("d");
        }
        public static string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return "";
            int start = 0, end = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int maxlen = Math.Max(expandAroundCenter(s, i, i), expandAroundCenter(s, i, i + 1));
                if (maxlen > end - start)
                {
                    start = i - (maxlen - 1) / 2;
                    end = i + (maxlen) / 2;
                }

            }
            Console.WriteLine(s.Substring(start, end-start+1 ));
            return s.Substring(start, end - start + 1);
        }
        public static int expandAroundCenter(string s, int left, int right)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }
            return right - left - 1;
        }

    }
}
