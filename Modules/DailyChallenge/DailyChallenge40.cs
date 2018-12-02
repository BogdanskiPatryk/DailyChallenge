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
         

        public List<string> Proceed(IEnumerable<Tuple<string, string>> list, string start)
        {
            List<List<string>> result = ProceedIntern(list.ToList(), start);
            // remove deathends
            result = result.Where(x => x.Any(f => f == null) == false).ToList();
            return SelectList(result);

        }

        private List<List<string>> ProceedIntern(List<Tuple<string,string>> list, string start)
        {
            List<List<string>> result = new List<List<string>>();
            if (list.Count == 1)
            {
                if (start == list[0].Item1)
                {
                    result.Add(new List<string>() { list[0].Item1, list[0].Item2 });
                }
                else
                {
                    result.Add(new List<string>() { null });
                }
                return result;
            }
            foreach(Tuple<string,string> tuple in list.Where(x => x.Item1 == start))
            {
                var res = ProceedIntern(list.Except(new[] { tuple }).ToList(), tuple.Item2);
                if (res.Any() == false)
                {
                    result.Add(new List<string>() { null });
                }
                foreach (var list2 in res)
                {
                    List<string> flight = new List<string>()
                    {
                        start
                    };
                    flight.AddRange(list2);
                    result.Add(flight);
                }
            }
            return result;
        }

        private List<string> SelectList(List<List<string>> lists)
        {
            if (lists.Any() == false)
            {
                return null;
            }
            List<Tuple<int, string>> res = new List<Tuple<int, string>>();
            int i = 0;
            foreach(var list in lists)
            {
                res.Add(new Tuple<int, string>(i, string.Join("", list)));
            }
            res = res.OrderBy(x => x.Item2).ToList();
            return lists[res[0].Item1];
        }
    }
}
