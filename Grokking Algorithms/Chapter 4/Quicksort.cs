using System.Collections.Generic;

namespace Chapter_4
{
    public class Quicksort
    {
        /*
         * Analysis
         * Time:
         * Best Case is the average case.
         * Average Case: satck height * each stack level = O(log(n)) * O(n) = O(n*log(n))
         * Worst Case: satck height * each stack level = O(n) * O(n) = O(n^2)
         * Memory:
         * O(n)
        */
        public static List<int> SortRec(List<int> li)
        {
            if (li.Count < 2)
            {
                return li;
            }
            else
            {
                int pivot = PickPivot(li);
                List<int> less = new List<int>();
                List<int> bigger = new List<int>();
                for (int i = 0; i < li.Count; i++)
                {
                    if (i == pivot)
                    {
                        continue;
                    }
                    if (li[i] > li[pivot])
                    {
                        bigger.Add(li[i]);
                    }
                    else
                    {
                        less.Add(li[i]);
                    }
                }
                List<int> result = new List<int>();
                result.AddRange(SortRec(less));
                result.Add(li[pivot]);
                result.AddRange(SortRec(bigger));
                return result;
            }
        }
        private static int PickPivot(List<int> li)
        {
            return li.Count / 2; // a good pivot reduces the call stack height.
        }
    }
}
