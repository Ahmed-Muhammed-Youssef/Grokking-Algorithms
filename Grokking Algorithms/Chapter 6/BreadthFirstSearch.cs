using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6
{

    /*
     * Analysis:
     * Time: 
     * Worst Case: O(V+E) Where V is the number of vertices and E is the number of edges.
     * Memory: 
     * Worst Case: O(V) we store the vertices visited.
     */
    public static class BreadthFirstSearch
    {
        public static bool RecursiveSearch<T>(Graph<T> graph, T root, T target, Stack<T> visited = null)
        {
            if (visited == null)
            {
                visited = new Stack<T>();
            }
            visited.Push(root);
            if (root.Equals(target))
            {
                return true;
            }
            foreach (var edge in graph.AdjacencyList[root])
            {
                if( RecursiveSearch(graph, edge, target, visited))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool Search<T>(Graph<T> graph, T root, T target, Stack<T> visited = null)
        {
            Queue<T> searchQueue = new Queue<T>();
            if(visited == null)
            {
                visited= new Stack<T>();
            }
            visited.Push(root);
            searchQueue.Enqueue(root);
            while(searchQueue.Count > 0)
            {
                T currentElement = searchQueue.Dequeue();
                visited.Push(currentElement);
                if (currentElement.Equals(target))
                {
                    return true;
                }
                foreach (var edge in graph.AdjacencyList[currentElement])
                {
                    if (!visited.Contains(edge))
                    {
                        searchQueue.Enqueue(edge);
                    }
                }
            }
            return false;
        }
    }
}
