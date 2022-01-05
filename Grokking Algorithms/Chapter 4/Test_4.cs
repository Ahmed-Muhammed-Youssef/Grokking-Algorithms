using System;
using System.Collections.Generic;

namespace Chapter_4
{
    public static class Test_4
    {
        public static void Main()
        {
            //Chapter 4: Divide and Conquer
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            Console.WriteLine(DivideAndConquer.Sum(arr));
            Console.WriteLine(DivideAndConquer.Count(arr));
            Console.WriteLine(DivideAndConquer.Max(arr));
            Console.WriteLine(DivideAndConquer.BinarySearch(arr, 1));
            List<int> li = new List<int>() { 7, 2, 3, 4, 5, 6, 1 };
            li = Quicksort.SortRec(li);
            foreach (var item in li)
            {
                Console.WriteLine(item);
            }
        }
    }
}
