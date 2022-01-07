using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9
{
    public static class DynamicProgrammingKnapsack
    {
        private static (double?, List<string>)[,] table; // used for momoization
        public static (double, List<string>) Calcaulte(double maxAffordableCost, Dictionary<string, CostValuePair> items)
        {
            double leastCost = items.Values.Min(v => v.Cost);
            int nColumns = (int)(maxAffordableCost / leastCost);
            int nRows = items.Keys.Count;
            if(!IsValidProblem(maxAffordableCost, nColumns, leastCost))
            {
                throw new InvalidOperationException("the problem doesn't meet the algorithm's criteria");
            }
            table = new (double?, List<string>)[nRows, nColumns];
            int row = 0;
            foreach (var item in items)
            {
                for (int column = 0; column < nColumns; column++)
                {
                    double columnAffordableCost = (column + 1) * leastCost;
                    double? previousMaxValue = null;
                    if (HasValueAt(row - 1, column, nRows, nColumns)) // checks if there is a previous max value
                    {
                        previousMaxValue = table[row - 1, column].Item1;
                    }
                    // check if the current item can be afforded in the current cell
                    if(item.Value.Cost > columnAffordableCost)
                    {
                        if (previousMaxValue != null)
                        {
                            table[row, column] = table[row - 1, column];
                        }
                        else
                        {
                            table[row, column] = (null, null);
                        }
                    }
                    else
                    {
                        // calculate the new max
                        double newMaxValue = item.Value.Value;
                        List<string> newItems = new List<string>() { item.Key };
                        double remainingAffordableCost = columnAffordableCost - item.Value.Cost;
                        int fillerColumn = (int)(remainingAffordableCost / leastCost) - 1;
                        if (HasValueAt(row - 1, fillerColumn, nRows, nColumns)) // is there a value that can fill the remaining empty space?
                        {
                            newMaxValue += (double)table[row - 1, fillerColumn].Item1;
                            newItems.AddRange(table[row - 1, fillerColumn].Item2);
                        }
                        // note that: if the first condition is true it won't check the second condition which would make bugs if it was possible
                        if (previousMaxValue == null || newMaxValue > previousMaxValue) // if there is no a previousMax or the newMax is just better
                        {
                            table[row, column].Item1 = newMaxValue;
                            table[row, column].Item2 = new List<string>(newItems);
                        
                        }
                        else // the previous max value is just better than the new mav value.
                        {
                            table[row, column] = table[row - 1, column]; // gets the previous max
                        }
                    }
                        
                    
                }
                row++;
            }
            return ((double, List<string>)) table[items.Keys.Count - 1, nColumns - 1];
        }
        private static bool HasValueAt(int i, int j, int rows, int columns)
        {
            if(i >= 0 && i < rows && j >= 0 && j < columns)
            {
                if(table[i, j] != (null, null))
                {
                    return true;
                }
            }
            return false;
        }
        private static bool IsValidProblem(double sizeOfSack, int arraySize, double smallestItemSize)
        {
            if(sizeOfSack == (double)(smallestItemSize) * arraySize)
            {
                return true;
            }
            return false;
        }
    }
    // helper class
    public class CostValuePair
    {
        public double Value { get; set; }
        public double Cost { get; set; }
    }
}
