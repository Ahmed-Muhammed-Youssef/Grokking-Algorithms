using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9
{
    public static class Test_9
    {
        public static void Main()
        {
            // book example: knabsack problem
            double sackSize = 4;
            Dictionary<string, CostValuePair> items = new Dictionary<string, CostValuePair>()
            {
                {"stereo", new CostValuePair(){ Cost = 4, Value = 3000 } },
                {"labtop", new CostValuePair(){ Cost = 3, Value = 2000 } },
                {"guitar", new CostValuePair(){ Cost = 1, Value = 1500 } }
            };
            var result = DynamicProgrammingKnapsack.Calcaulte(sackSize, items);
            Console.WriteLine("Example: knabsack problem");
            foreach (var item in result.Item2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(">>> max value = " + result.Item1.ToString());


            // book example: Optimizing your travel itinerary
            sackSize = 2;
            items = new Dictionary<string, CostValuePair>()
            {
                 {"westminster", new CostValuePair(){ Cost = 0.5, Value = 7 } },
                {"globe theatre", new CostValuePair(){ Cost = 0.5, Value = 6 } },
                {"national gallery", new CostValuePair(){ Cost = 1, Value = 9 } },
                {"british museum", new CostValuePair(){ Cost = 2, Value = 9 } },
                {"st. paul", new CostValuePair(){ Cost = 0.5, Value = 8 } }
            };
            result = DynamicProgrammingKnapsack.Calcaulte(sackSize, items);
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Example: Optimizing your travel itinerary");
            foreach (var item in result.Item2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(">>> max value = " + result.Item1.ToString());


            // 9.2 Exercise
            sackSize = 6;
            items = new Dictionary<string, CostValuePair>()
            {
                {"water", new CostValuePair(){ Cost = 3, Value = 10 } },
                {"book", new CostValuePair(){ Cost = 1, Value = 3 } },
                {"food", new CostValuePair(){ Cost = 2, Value = 9 } },
                {"jacket", new CostValuePair(){ Cost = 2, Value = 5 } },
                {"camera", new CostValuePair(){ Cost = 1, Value = 6 } }
            };
            result = DynamicProgrammingKnapsack.Calcaulte(sackSize, items);
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("9.2 exercise:");
            foreach (var item in result.Item2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(">>> max value = " + result.Item1.ToString());
        }
    }
}
