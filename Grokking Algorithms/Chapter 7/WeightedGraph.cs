using System;
using System.Collections.Generic;

namespace Chapter_7
{
    public class WeightedGraph<T>
    {
        public Dictionary<T, Dictionary<T, int>> AdjacencyList { get; set; }
        public int NodeCount { get; private set; }

        public WeightedGraph()
        {
            AdjacencyList = new Dictionary<T, Dictionary<T, int>>();
        }
        public WeightedGraph(Dictionary<T, Dictionary<T, int>> list)
        {
            AdjacencyList = new Dictionary<T, Dictionary<T, int>>();
            foreach (var vertix in list)
                AddEdges(vertix.Key, vertix.Value);
        }
        public void AddVertix(T vertix)
        {
            AdjacencyList.Add(vertix, new Dictionary<T, int>());
            NodeCount++;
        }
        public void AddEdges(T toNode, Dictionary<T, int> edges)
        {
            if (!AdjacencyList.ContainsKey(toNode))
            {
                AddVertix(toNode); // You can throw an exception instead but doing this will make it usefull to add both a new vertix and its edges.
            }
            foreach (var edge in edges)
            {
                if (!AdjacencyList.ContainsKey(edge.Key))
                {
                    AddVertix(edge.Key); // again you can throw an exception instead but this makes creating a new vertix and its edges easier.
                }
                if (AdjacencyList[toNode].ContainsKey(edge.Key))
                {
                    throw new Exception("Redundent edge, the nodes must be unique");
                }
                AdjacencyList[toNode].Add(edge.Key, edge.Value);
            }
        }
    }
}
