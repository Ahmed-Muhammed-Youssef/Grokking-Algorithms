using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8
{
    public static class Test_8
    {
        public static void Main()
        {
            HashSet<string> states = new HashSet<string>() { "mt", "wa", "or", "id", "nv", "ut", "ca", "az" };
            Dictionary<string, HashSet<string>> stations = new Dictionary<string, HashSet<string>>()
            {
                { "kone", new HashSet<string>(){ "id", "nv", "ut" }},
                { "ktwo", new HashSet<string>(){ "wa", "id", "mt" }},
                { "kthree", new HashSet<string>(){ "or", "nv", "ca" }},
                { "kfour", new HashSet<string>(){ "nv", "ut" }},
                { "kfive", new HashSet<string>() { "ca", "az" }}
            };
            var result = SetCoveringProblem.Calculate(states, stations);
            foreach (var station in result)
            {
                Console.WriteLine(station);
            }
        }
    }
}
