using System;
using System.Collections.Generic;

namespace Chapter_7
{

    /*
     * this done by using the naive method
     * It can only be used with DAGs (directed acyclic graphs) without negative weights
     * 
     * Analysis:
     * Time Complexity:
     * Worst Case: O(E*logV) where V is the number of vertices and E is the total number of edges
     * Memory Complexity: 
     * Worst Case: O(n) where n is the number of nodes.
     */
    public static class Dijkstra
    {
        public static List<string> FindPath (string startNode, string target, WeightedGraph<string> weightedGraph)
        {
            Dictionary<string, string> parents = new Dictionary<string, string>();
            Dictionary<string, int> costs = new Dictionary<string, int>();
            HashSet<string> done = new HashSet<string>();

            costs.Add(startNode, 0);
            string node = startNode;

            while (node!= null && node!= target)
            {
                done.Add(node);
                int currentNodeCost = costs[node];
                string nextNode = null;
                foreach (var neighbouringNode in weightedGraph.AdjacencyList[node])
                {
                    UpdateCosts(parents, costs, node, currentNodeCost, neighbouringNode);
                    nextNode = CalculateNextNode(costs, done, nextNode, neighbouringNode);
                }
                node = nextNode;
            }
            List<string> result = new List<string>();

            node = target;
            while (true)
            {
                result.Add(node);
                if(!parents.TryGetValue(node, out node))
                {
                    break;
                }
            }
            return result;
        }

        private static string CalculateNextNode(Dictionary<string, int> costs, HashSet<string> done, string nextNode, KeyValuePair<string, int> neighbouringNode)
        {
            if (nextNode == null)
            {
                if (!done.Contains(neighbouringNode.Key))
                {
                    return neighbouringNode.Key;
                }
            }
            else if (!done.Contains(neighbouringNode.Key))
            {
                if (costs[neighbouringNode.Key] < costs[nextNode])
                {
                    return neighbouringNode.Key;
                }
            }

            return nextNode;
        }

        private static void UpdateCosts(Dictionary<string, string> parents, Dictionary<string, int> costs, string node, int currentNodeCost, KeyValuePair<string, int> neighbouringNode)
        {
            int curretnTotalCost = currentNodeCost + neighbouringNode.Value;
            if (!costs.ContainsKey(neighbouringNode.Key))
            {
                costs.Add(neighbouringNode.Key, curretnTotalCost);
                parents.Add(neighbouringNode.Key, node);
            }
            else
            {
                if (costs[neighbouringNode.Key] > curretnTotalCost)
                {
                    costs[neighbouringNode.Key] = curretnTotalCost;
                    parents[neighbouringNode.Key] =  node;
                }
            }
        }

    }
}
