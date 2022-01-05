using Chapter_1;
using Chapter_2;
using Chapter_3;
using Chapter_4;
using Chapter_6;
using Chapter_7;
using System;
using System.Collections.Generic;

namespace Grokking_Algorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Chapter 1: Binary Search 
            /*int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            Console.WriteLine($"{BinarySearch.Search(arr, 1)}");*/

            // Chapter 2: selection sort
            /*int[] arr = { 17, 15, 12, 10, 5, 6, 7, 8, 11, 4, 9, 3, 13, 14, 2, 16, 1};
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
            }*/

            // Chapter 3: Factorial
            /* Console.WriteLine(Factorial.CalculateRecursively(3));
             Console.WriteLine(Factorial.CalculateItteratively(3));*/

            //Chapter 4: Divide and Conquer
            /*int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            Console.WriteLine(DivideAndConquer.Sum(arr));
            Console.WriteLine(DivideAndConquer.Count(arr));
            Console.WriteLine(DivideAndConquer.Max(arr));
            Console.WriteLine(DivideAndConquer.BinarySearch(arr, 1));*/
            /*List<int> li = new List<int>() { 7, 2, 3, 4, 5, 6, 1 };
            li = Quicksort.SortRec(li);
            foreach (var item in li)
            {
                Console.WriteLine(item);
            }*/

            //Chapter 6
            //all the arrows are pointing downwords
            // 1
            // | \
            // 2  3
            // |  | \
            // 4  5->6
            // | /|
            // 7  8
            //    |
            //    9
            //    |
            //    10

            /* var g = new Dictionary<int, HashSet<int>>(){
                 { 1, new HashSet<int>(){ 2, 3} },
                 { 2, new HashSet<int>(){ 4 } },
                 { 3, new HashSet<int>(){ 5, 6 } },
                 { 4, new HashSet<int>(){ 7 } },
                 { 5, new HashSet<int>(){ 7,8,6 } },
                 { 8, new HashSet<int>(){ 9 } },
                 { 9, new HashSet<int>(){ 10 } }
             };
            Graph<int> graph = new Graph<int>(g);

             var result = BreadthFirstSearch.Search(graph, 7, 10);
             Console.WriteLine(result);*/

            //Test_7.Main();

        }
    }
}
