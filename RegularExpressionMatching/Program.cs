using System;
using System.Collections;
using System.Collections.Generic;

namespace RegularExpressionMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public bool isMatch(string s, string p)
        {
            if (string.IsNullOrEmpty(p)) return string.IsNullOrEmpty(s);
            bool firstmatch = (!string.IsNullOrEmpty(s) && (p[0] == s[0]) || p[0] == '.');
            if (p.Length >= 2 && p[1] == '*')
            {
                return (isMatch(s, p.Substring(2)) || (firstmatch && isMatch(s.Substring(1), p)));
            }
            else
            {
                return firstmatch && isMatch(s.Substring(1), p.Substring(1));
            }
        }

     
    }
}
