using System;
using System.Collections.Generic;
using System.Linq;

namespace MinValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 66, 12, 25 };

            var min = GetMinimum(list);
            Console.WriteLine(min);

            var minSecondVariant = GetMinimumSecondVariant(list);
            Console.WriteLine(minSecondVariant);
        }

        public static int GetMinimum(List<int> list)
        {
            if (list == null || list.Count == 0)
                throw new InvalidOperationException("Sequence contains no elements");  
            
            else
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
        }

        public static int GetMinimumSecondVariant(List<int> list)
        {
            if (list == null || list.Count == 0)
                throw new InvalidOperationException("Sequence contains no elements");

            int num = 0;
            bool flag = false;

            foreach (int item in list)
            {
                if (flag)
                {
                    if (item < num)
                    {
                        num = item;
                    }
                }
                else
                {
                    num = item;
                    flag = true;
                }
            }

            if (flag)
            {
                return num;
            }
            throw new NullReferenceException();
        }
    }
}
