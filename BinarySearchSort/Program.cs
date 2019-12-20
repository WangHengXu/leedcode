using System;

namespace BinarySearchSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] temp = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 ,13};
            Search(temp, 13);
        }
        public static void  Search(int[] temp,int Searchint)
        {
            int start = 0;
            int end = temp.Length-1;
            int middle = (start + end) / 2;
            while (start < end)
            {
                if (Searchint < temp[middle])
                {
                    end = middle - 1;
                    middle = (start + end) / 2;
                }
                if (Searchint > temp[middle])
                {
                    start = middle + 1;
                    middle = (start + end) / 2;
                }
                if (Searchint == temp[middle])
                {
                    Console.WriteLine($"{middle}");
                    return;
                }
            }
        }
    }
}
