using System;
using System.Collections.Generic;

namespace MinValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 66, 12, 25 };
            var min = GetMinimum(list);
            Console.WriteLine(min);
        }

        public static int GetMinimum(List<int> list)
        {
            if (list == null || list.Count == 0)
            {
                int min = list[0];
                foreach (var item in list)
                {
                    if (item < min)
                    {
                        min = item;
                    }
                }
                return min;
            }
            else
                throw new Exception("list is empty");
        }
    }
}
