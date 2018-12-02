using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge40
    {
        /*
         * Given an unordered list of flights taken by someone, each represented as (origin, destination) pairs, and a starting airport, compute the person's itinerary. If no such itinerary exists, return null. If there are multiple possible itineraries, return the lexicographically smallest one. All flights must be used in the itinerary.
For example, given the list of flights [('SFO', 'HKO'), ('YYZ', 'SFO'), ('YUL', 'YYZ'), ('HKO', 'ORD')] and starting airport 'YUL', you should return the list ['YUL', 'YYZ', 'SFO', 'HKO', 'ORD'].
Given the list of flights [('SFO', 'COM'), ('COM', 'YYZ')] and starting airport 'COM', you should return null.
Given the list of flights [('A', 'B'), ('A', 'C'), ('B', 'C'), ('C', 'A')] and starting airport 'A', you should return the list ['A', 'B', 'C', 'A', 'C'] even though ['A', 'C', 'A', 'B', 'C'] is also a valid itinerary. However, the first one is lexicographically smaller.
         */
         
        private class Path
        {
            public List<string> Ports;
            public bool IsDeath;

            public string Flat()
            {
                if (IsDeath)
                {
                    return string.Empty;
                }
                return string.Join("", Ports);
            }
        }

        public List<string> Proceed(IEnumerable<Tuple<string, string>> list, string start)
        {
            List<Path> result = ProceedIntern(list.ToList(), start);
            // remove deathends
            result = result.Where(x => x.IsDeath == false).ToList();
            if (result.Any() == false)
            {
                return null;
            }
            return result.OrderBy(x => x.Flat()).First().Ports;

        }

        private List<Path> ProceedIntern(List<Tuple<string,string>> list, string start)
        {
            List<Path> result = new List<Path>();
            if (list.Count == 1)
            {
                if (start == list[0].Item1)
                {
                    result.Add(new Path { Ports = new List<string>() { list[0].Item1, list[0].Item2 } });
                }
                else
                {
                    result.Add(new Path { IsDeath = true });
                }
                return result;
            }
            foreach(Tuple<string,string> tuple in list.Where(x => x.Item1 == start))
            {
                var res = ProceedIntern(list.Except(new[] { tuple }).ToList(), tuple.Item2);
                if (res.Any() == false)
                {
                    result.Add(new Path { IsDeath = true });
                }
                foreach (var p in res)
                {
                    if (p.IsDeath)
                    {
                        result.Add(p);
                        continue;
                    }
                    Path path = new Path() { Ports = new List<string>() { start } };
                    path.Ports.AddRange(p.Ports);
                    result.Add(path);
                }
            }
            return result;
        }
    }
}
