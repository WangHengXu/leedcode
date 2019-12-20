using System;

namespace SelectSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] temp = { 12, 9, 3, 7, 14, 11 };
            Sort(temp);
            foreach (var item in temp)
            {
                Console.Write($"{ item},");
            }
        }
        public static void Sort(int[] temp)
        {
            for (int j = 0; j < temp.Length; j++)
            {
                int min = temp[j];
                int minindex = j;
                for (int i = j+1; i < temp.Length; i++)
                {
                    if (temp[i] < min)
                    {
                        minindex = i;
                        min = temp[i];
                    }
                }
                if (minindex != j)
                {
                    temp[minindex] = temp[j];
                    temp[j] = min;
                }
            }
          
        }
    }
}
