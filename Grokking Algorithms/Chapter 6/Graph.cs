using System;
using System.Collections.Generic;

namespace Chapter_6
{

    // Implementing graph data structure using adjacency list
    // A Hash table with node as a key and the value is a hash set of neighbouring nodes.
    // This graph is mainly a directed graph but it can also be used as an undirected graph.
    public class Graph <T>
    {
        public int NodeCount { get; private set; } = 0;
        public Dictionary<T, HashSet<T>> AdjacencyList { get; } = new Dictionary<T, HashSet<T>>();
        public Graph() { }
        public Graph(Dictionary<T, HashSet<T>> AdjacencyList)
        {
            foreach (var edge in AdjacencyList)
                AddEdges(edge.Key, edge.Value);
        }
        public void AddVertix(T vertix)
        {
            AdjacencyList.Add(vertix, new HashSet<T>());
            NodeCount++;
        }
        public void AddEdges(T toNode, IEnumerable<T> edges)
        {
            if (!AdjacencyList.ContainsKey(toNode))
            {
                AddVertix(toNode); // You can throw an exception instead but doing this will make it usefull to add both a new vertix and its edges.
            }
            foreach (var edge in edges)
            {
                if (!AdjacencyList.ContainsKey(edge))
                {
                    AddVertix(edge); // again you can throw an exception instead but this makes creating a new vertix and its edges easier.
                }
                if (!AdjacencyList[toNode].Add(edge))
                {
                    throw new Exception("Redundent edge, the nodes must be unique");
                }
            }
        }
    }
}
