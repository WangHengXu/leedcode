using System;

namespace LongestPalindromicSubstring
{
    class Program
    {
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
