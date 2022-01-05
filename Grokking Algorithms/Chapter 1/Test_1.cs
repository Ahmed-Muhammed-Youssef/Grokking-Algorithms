using System;

namespace Chapter_1
{
    public static class Test_1
    {
        public static void Main()
        {
            // Chapter 1: Binary Search 
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            Console.WriteLine($"{BinarySearch.Search(arr, 1)}");
        }
    }
}
