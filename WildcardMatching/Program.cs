using System;

namespace WildcardMatching
{
    /*
     * 给定一个字符串 (s) 和一个字符模式 (p) ，实现一个支持 '?' 和 '*' 的通配符匹配。

'?' 可以匹配任何单个字符。
'*' 可以匹配任意字符串（包括空字符串）。
两个字符串完全匹配才算匹配成功。

说明:

s 可能为空，且只包含从 a-z 的小写字母。
p 可能为空，且只包含从 a-z 的小写字母，以及字符 ? 和 *。
示例 1:

输入:
s = "aa"
p = "a"
输出: false
解释: "a" 无法匹配 "aa" 整个字符串。
示例 2:

输入:
s = "aa"
p = "*"
输出: true
解释: '*' 可以匹配任意字符串。
示例 3:

输入:
s = "cb"
p = "?a"
输出: false
解释: '?' 可以匹配 'c', 但第二个 'a' 无法匹配 'b'。
示例 4:

输入:
s = "adceb"
p = "*a*b"
输出: true
解释: 第一个 '*' 可以匹配空字符串, 第二个 '*' 可以匹配字符串 "dce".
示例 5:

输入:
s = "acdcb"
p = "a*c?b"
输入: false

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/wildcard-matching
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            while (true)
            {
                string s = Console.ReadLine();
                string p = Console.ReadLine();
                Console.WriteLine(IsMatch(s,p));
            }
        }
        public static bool IsMatch(string s, string p)
        {
            bool[,]  memo = new bool[s.Length+1, p.Length+1];
            int n = s.Length;
            int m = p.Length;
            memo[0, 0] = true;
            for (int j = 1; j <= m; j++)
            {
                if (p[j - 1] == '*')
                {
                    memo[0, j] = memo[0, j - 1];
                }
            }
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    if(s[i-1]==p[j-1]||p[j-1]=='?')
                    {
                        memo[i, j] = memo[i - 1, j - 1];
                    }else if(p[j-1]=='*')
                    {
                        memo[i, j] = memo[i, j - 1] || memo[i - 1,j];
                    }
                }
            }
            return memo[n, m];

       
        }

        public bool IsMatch2(string s, string p)
        {
            var result = new bool?[s.Length + 1, p.Length + 1];
            return Match(0, 0, s, p, result);
        }

        private bool Match(int i, int j, string s, string p, bool?[,] result)
        {
            if (result[i, j] != null)
            {
                return (bool)result[i, j];
            }

            bool r;
            if (j == p.Length)
            {
                r = i == s.Length;
                result[i, j] = r;
                return r;
            }
            if (j == p.Length - 1 && p[j] == '*')
            {
                result[i, j] = true;
                return true;
            }

            var isFirstMatch = p[j] == '*' || i < s.Length && (s[i] == p[j] || p[j] == '?');
            if (p[j] == '*')
            {
                r = Match(i, j + 1, s, p, result) || i < s.Length && Match(i + 1, j, s, p, result);
            }
            else
            {
                r = isFirstMatch && Match(i + 1, j + 1, s, p, result);
            }

            result[i, j] = r;
            return r;
        }


    }
}
