using System;
using System.Text;

/// <summary>
/// /给定一个字符串，逐个翻转字符串中的每个单词。

/*示例：

输入: ["t","h","e"," ","s","k","y"," ","i","s"," ","b","l","u","e"]
输出: ["b","l","u","e"," ","i","s"," ","s","k","y"," ","t","h","e"]
注意：

单词的定义是不包含空格的一系列字符
输入字符串中不会包含前置或尾随的空格
单词与单词之间永远是以单个空格隔开的
进阶：使用 O(1) 额外空间复杂度的原地解法。*/

/// </summary>
namespace ReversWords
{
    internal class Program
    {
        public static void ReverseWords(char[] s)
        {
            int ringht = s.Length - 1;
            StringBuilder temp2 = new StringBuilder();
            StringBuilder temp3 = new StringBuilder();
            for (int i = ringht; i >= 0; i--)
            {
                if (s[i] != ' ')
                {
                    temp2.Insert(0, s[i]);
                }
                else
                {
                    temp3.Append(temp2.ToString() + " ");
                    temp2.Clear();
                }
            }
            temp3.Append(temp2.ToString() + " ");
            temp2.Clear();
            char[] v = temp3.ToString().ToCharArray();
            char[] tempchar = v;
            for (int i = 0; i < tempchar.Length - 1; i++)
            {
                s[i] = tempchar[i];
            }
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            char[] t = { 't', 'h', 'e', ' ', 's', 'k', 'y', ' ', 'i', 's', ' ', 'b', 'l', 'u', 'e' };
            ReverseWords(t);
        }
    }
}