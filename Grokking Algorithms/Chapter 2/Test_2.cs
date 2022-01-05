using System;

namespace Chapter_2
{
    public static class Test_2
    {
        public static void Main()
        {
            // Chapter 2: selection sort
            int[] arr = { 17, 15, 12, 10, 5, 6, 7, 8, 11, 4, 9, 3, 13, 14, 2, 16, 1 };
            SelectionSort.SortDESC(arr);
            foreach (var item in arr)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine(new string('-', 50));
            SelectionSort.SortASC(arr);
            foreach (var item in arr)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
