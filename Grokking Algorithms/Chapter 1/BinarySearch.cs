using System;

namespace Chapter_1
{
    public static class BinarySearch
    {
        /*
         * Note: the array must be sorted.
         * Analysis (Given the array is sorted)
         * Time:
         * Best Case: O(1)
         * Worst Case: O(Log(n)) (Logarithmic Time)
         * Memory:
         * O(1)
        */
        public static int Search (int[] arr, int key)
        {
            int left = 0;
            int right = arr.Length - 1;
            int middle;
            while (left <= right)
            {
                middle = (left + right)/2;
                if(arr[middle] == key)
                {
                    return middle;
                }
                else if(arr[middle] < key)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }
            return -1;   //not found
        }
    }
}
