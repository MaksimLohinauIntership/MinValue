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
    }
}
