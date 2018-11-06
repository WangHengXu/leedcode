using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterCombinationsofaPhoneNumber
{
    /*
     * 给定一个仅包含数字 2-9 的字符串，返回所有它能表示的字母组合。

给出数字到字母的映射如下（与电话按键相同）。注意 1 不对应任何字母。



示例:

输入："23"
输出：["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"].
说明:
尽管上面的答案是按字典序排列的，但是你可以任意选择答案输出的顺序。
     */
    class Program
    {
        static void Main(string[] args)
        {
            LetterCombinations("423");
        }

        public static IList<string> LetterCombinations(string digits)
        {
            Dictionary<char, string> dic = new Dictionary<char, string>();
            dic.Add('2', "abc");
            dic.Add('3', "def");
            dic.Add('4', "ghi");
            dic.Add('5', "jkl");
            List<string> result = new List<string>();
            foreach (var v in dic[digits[0]])
            {
                result.Add(Convert.ToString(v));
            }
            for (int i = 1; i < digits.Length; i++)
            {
                    int t = result.Count;
                    for (int j = 0; j < t; j++)
                    {
                        for (int m = 0; m < dic[digits[i]].Length; m++)
                            result.Add(result[j] + Convert.ToString(dic[digits[i]][m]));
                    }
                    for(int j=0;j<t;j++)
                    {
                        result.RemoveAt(0);
                    }
            }
            IList<string> list=new List<string>();     
            foreach(var l in result)
            {
                list.Add(l);
            }
            return list;
        }
    }
}
