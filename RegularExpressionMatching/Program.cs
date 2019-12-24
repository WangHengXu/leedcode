using System;

namespace RegularExpressionMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            while (true)
            {
                string s = Console.ReadLine();
                string p = Console.ReadLine();
                Console.WriteLine(IsMatch(s, p)); 
            }
        }
      static  bool?[,] memo;
        public static bool IsMatch(string s, string p)
        {
            memo = new bool?[s.Length+1, p.Length+1];
            return (bool)Match(0, 0, s, p);
        }
        public static bool? Match(int i, int j, string s, string p)
        {
            if (memo[i, j] != null)
            {
                return memo[i, j];
            }
            if (j >= p.Length)
            {
                return memo[i, j] = i==s.Length;
            }
            bool curmatch = (i < s.Length && (s[i] == p[j] || p[j] == '.'));
            if (j + 1 < p.Length && p[j + 1] == '*')
            {
                memo[i, j] = (bool)Match(i, j + 2, s, p) || (curmatch && (bool)Match(i + 1, j, s, p));
            }
            else 
            {
                memo[i, j] = curmatch && (bool)Match(i + 1, j + 1, s, p);
            }
            memo[i, j] = memo[i, j] ?? curmatch;
            return memo[i, j];
        }
    }
}
