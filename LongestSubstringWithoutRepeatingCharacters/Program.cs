using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSubstringWithoutRepeatingCharacters
{
    /*
     * 
     * 给定一个字符串，找出不含有重复字符的最长子串的长度。

    示例 1:

    输入: "abcabcbb"
    输出: 3 
    解释: 无重复字符的最长子串是 "abc"，其长度为 3。
    示例 2:

    输入: "bbbbb"
    输出: 1
    解释: 无重复字符的最长子串是 "b"，其长度为 1。
    示例 3:

    输入: "pwwkew"
    输出: 3
    解释: 无重复字符的最长子串是 "wke"，其长度为 3。
     请注意，答案必须是一个子串，"pwke" 是一个子序列 而不是子串。
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test("abcabcbb"));
            Console.Read();

        }
        public static int LengthOfLongestSubstring(string s)
        {
            int longestString = 0, temp = 0; ;
            string tempstr=string.Empty;
            foreach (char c in s)
            {
                string str = Convert.ToString(c);
                if(!tempstr.Contains(str))
                {
                    tempstr = tempstr + str;
                    temp++;
                }
                else
                {
                    if(longestString<temp)
                    {
                        longestString = temp;
                    }
                    int t = tempstr.LastIndexOf(str);
                    tempstr = tempstr.Substring(t+1)+str;
                    temp = tempstr.Length;
                }
            }
            if (longestString < temp)
            {
                longestString = temp;
            }

            return longestString;
        }

        public static int test(string s)
        {
            var chars = s.ToCharArray();
            var maxLength = 0;
            var current = 0;
            var lengthTable = new int[256];
            for (var i = 0; i < lengthTable.Length; i++)
            {
                lengthTable[i] = -1;
            }

            for (var i = 0; i < chars.Length; i++)
            {
                var charVal = (int)(chars[i]);
                var found = lengthTable[charVal];

                if (found > -1 && found >= current)
                {
                    current = found + 1;
                }

                var newLength = i - current + 1;
                if (newLength > maxLength)
                {
                    maxLength = newLength;
                }

                lengthTable[charVal] = i;
            }

            return maxLength;
        }
        public static int test1(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            int maxstart = 0; int maxend = 0; int maxLength = 0;
            int startTemp = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (!dic.ContainsKey(s[i]))
                    dic.Add(s[i], i);
                else
                {
                    int x = dic[s[i]];
                    if (dic[s[i]] >= startTemp)
                    {
                        int length = i - 1 - startTemp + 1;
                        if (length > maxLength)
                        {
                            maxstart = startTemp;
                            maxend = i - 1;
                            maxLength = length;
                        }
                        startTemp = dic[s[i]] + 1;
                    }
                    dic[s[i]] = i;
                }
            }
            int len = s.Length - startTemp;
            if (len > maxLength)
                maxLength = len;
            return maxLength;
        }
    }
}
