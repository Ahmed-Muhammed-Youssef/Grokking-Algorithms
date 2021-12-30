using System;

namespace Chapter_4
{
    public static class DivideAndConquer
    {
        // 4.1
        public static int Sum(int[] arr)
        {
            return SumRec(arr, arr.Length - 1);
        }

        private static int SumRec(int[] arr, int i)
        {
            if(i < 0)
            {
                return 0;
            }
            if(i == 0)
            {
                return arr[0];
            }
            return arr[i] + SumRec(arr, i - 1);
        }
        // 4.2
        public static int Count(int[] arr)
        {
            return CountRec(arr, arr.Length - 1);
        }
        private static int CountRec(int[] arr, int i)
        {
            if (i < 0)
            {
                return 0;
            }
            if (i == 0)
            {
                return 1;
            }
            return 1+ CountRec(arr, i - 1);
        }

        // 4.3
        public static int Max(int[] arr)
        {
            if(arr.Length == 0)
            {
                throw new ArgumentException("The Array is Empty");
            }
            return MaxRec(arr, arr.Length - 2, arr[arr.Length - 1]);
        }

        private static int MaxRec(int[] arr, int i, int Max)
        {
            if(i < 0)
            {
                return Max;
            }
            if(Max < arr[i])
            {
                Max = arr[i];
            }
            return MaxRec(arr, i - 1, Max);
        }

        //4.4
        public static int BinarySearch(int[] arr, int key)
        {
            return BinarySearchRec(arr, key, left: 0, right: arr.Length - 1);
        }
        private static int BinarySearchRec(int[] arr, int key, int left, int right)
        {
            int middle = (left + right)/2;
            if(left > right)
            {
                return -1; //not found
            }
            else if(arr[middle] == key)
            {
                return middle;
            }
            else if(arr[middle] < key)
            {
                return BinarySearchRec(arr, key, middle + 1, right);
            }
            else
            {
                return BinarySearchRec(arr, key, left, middle - 1);
            }
        }
    }
}
