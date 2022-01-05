using System;
using System.Collections.Generic;

namespace Chapter_7
{
    public static class Test_7
    {
        public static void Main()
        {
            // Chapter 7: Graphs and Dijkstra algorithm
            Dictionary<string, Dictionary<string, int>> g0 = new Dictionary<string, Dictionary<string, int>>(){
                { "start", new Dictionary<string,int>(){ { "a", 6 }, { "b", 2 } } },
                { "a", new Dictionary<string,int>(){ { "fin", 1 } } },
                { "b", new Dictionary<string,int>(){ { "a", 3 }, { "fin", 5 } } },
                { "fin", new Dictionary<string,int>() }
            };

            // used to solve the 7.1 exercise
            Dictionary<string, Dictionary<string, int>> g1 = new Dictionary<string, Dictionary<string, int>>(){
                { "start", new Dictionary<string,int>(){ { "a", 5 }, { "b", 2 } } },
                { "a", new Dictionary<string,int>(){ { "c", 4 }, { "d", 2 } } },
                { "b", new Dictionary<string,int>(){ { "a", 8 }, { "d", 7 } } },
                { "c", new Dictionary<string,int>(){ { "d", 6 }, { "finish", 3 } } },
                { "d", new Dictionary<string,int>(){ { "finish", 1 } } },
                { "finish", new Dictionary<string,int>() }
            };
            Exercise1(g1);
        }

        private static void Exercise1(Dictionary<string, Dictionary<string, int>> g1)
        {
            WeightedGraph<string> graph = new WeightedGraph<string>(g1);
            var result = Dijkstra.FindPath("start", "finish", graph);

            Console.WriteLine("Exercise 7.1 solution");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
