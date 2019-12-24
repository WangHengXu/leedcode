using System;
using System.Collections.Generic;

namespace LongestValidParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            while (true)
            {
              string s=  Console.ReadLine();
               Console.WriteLine( LongestValidParentheses2(s));
            }
            
        }
        public static int LongestValidParentheses(string s)
        {
            int maxLenth = 0;
            Stack<int> stack = new Stack<int>();
            stack.Push(-1);
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    stack.Push(i);
                }
                else 
                {
                    stack.Pop();
                    if (stack.Count == 0)
                        stack.Push(i);
                    else 
                    {
                        maxLenth = Math.Max(maxLenth, i - stack.Peek());
                    }
                }
            }
            return maxLenth;
        }

        public static int LongestValidParentheses2(string s)
        {
            int maxNum = 0;
            int[] dp = new int[s.Length];
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i].Equals(')'))
                {
                    if (i >= 1 && s[i - 1].Equals('('))
                    {
                        if (i == 1)
                            dp[i] = 2;
                        else
                            dp[i] = dp[i - 2] + 2;
                    }
                    else if (i - dp[i - 1] > 0 && s[i - dp[i - 1] - 1].Equals('('))
                    {
                        if (i - dp[i - 1] >= 2)
                            dp[i] = dp[i - 1] + dp[i - dp[i - 1] - 2] + 2;
                        else
                            dp[i] = dp[i - 1] + 2;
                    }
                }
                maxNum = maxNum > dp[i] ? maxNum : dp[i];

            }
            return maxNum;
        }
    }
}
