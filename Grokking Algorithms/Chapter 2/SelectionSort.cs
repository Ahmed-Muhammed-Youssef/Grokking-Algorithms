using System;

namespace Chapter_2
{
    public static class SelectionSort
    {
        /*
         * Analysis
         * Time:
         * Best Case: O(n)
         * Worst Case: O(n^2)
         * Memory:
         * O(1)
        */
        public static void SortDESC(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int maxValIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if(arr[j] > arr[maxValIndex])
                    {
                        maxValIndex = j;
                    }
                }
                int temp = arr[maxValIndex];
                arr[maxValIndex] = arr[i];
                arr[i] = temp;
            }
        }
        public static void SortASC(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minValIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minValIndex])
                    {
                        minValIndex = j;
                    }
                }
                int temp = arr[minValIndex];
                arr[minValIndex] = arr[i];
                arr[i] = temp;
            }
        }
    }
}
