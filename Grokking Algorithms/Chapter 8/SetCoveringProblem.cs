using System.Collections.Generic;

namespace Chapter_8
{
    /*
     * the greedy algorithm doesn't give the exact solution all the time, but it sometimes
     * better to get a faster approximate solution.
     * Analysis:
     * Time: 
     * Worst Case: O(n^2) compared to O(!n) for the exact solution.
     */
    public static class SetCoveringProblem
    {
        public static IEnumerable<string> Calculate(HashSet<string> states,
            Dictionary<string, HashSet<string>> stations)
        {
            var bestStations = new HashSet<string>();
            var coveredStates = new HashSet<string>();
            var bestStation = string.Empty;

            while(coveredStates.Count < states.Count)
            {
                int currentNumberOfUncoveredStates = 0;
                foreach (var station in stations)
                {
                    if (bestStations.Contains(station.Key))
                    {
                        continue;
                    }
                    int newNumberOfNewUncoverdStates = NumberOfUncoverdStates(coveredStates, station.Value);
                    if (newNumberOfNewUncoverdStates > currentNumberOfUncoveredStates)
                    {
                        bestStation = station.Key;
                        currentNumberOfUncoveredStates = newNumberOfNewUncoverdStates;
                    }
                }
                bestStations.Add(bestStation);
                coveredStates.UnionWith(stations[bestStation]);
            }

            return bestStations;

        }
        private static int NumberOfUncoverdStates(HashSet<string> coveredStates, HashSet<string> newStates)
        {
            int count = 0;
            foreach (var state in newStates)
            {
                if (!coveredStates.Contains(state))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
