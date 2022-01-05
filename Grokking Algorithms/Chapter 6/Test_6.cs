using System;
using System.Collections.Generic;

namespace Chapter_6
{
    public static class Test_6
    {
        public static void Main()
        {
            //Chapter 6: Graphs and BFS
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

            var g = new Dictionary<int, HashSet<int>>(){
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
            Console.WriteLine(result);
        }
    }
}
