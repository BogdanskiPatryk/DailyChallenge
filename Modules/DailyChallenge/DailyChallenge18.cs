using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge18
    {
        /*
         * A builder is looking to build a row of N houses that can be of K different colors. He has a goal of minimizing cost while ensuring that no two neighboring houses are of the same color.
Given an N by K matrix where the nth row and kth column represents the cost to build the nth house with kth color, return the minimum cost which achieves this goal.
         */

        private class Res
        {
            public int Position;
            public int Cost;
        }

        public int[] Proceed(int[][] matrix)
        {
            List<List<Res>> results = GetResult(-1, matrix.ToList());
            return results.OrderBy(x => x.Sum(k => k.Cost)).First().Select(x => x.Position).ToArray();
        }

        private List<List<Res>> GetResult(int excluded, List<int[]> matrix)
        {
            List<List<Res>> results = new List<List<Res>>();
            for (int k = 0; k < matrix[0].Length; ++k)
            {
                if (k == excluded)
                {
                    continue;
                }
                if (matrix.Count != 1)
                {
                    List<List<Res>> current = GetResult(k, matrix.Skip(1).ToList());
                    foreach(var c in current)
                    {
                        c.Insert(0, new Res { Position = k, Cost = matrix[0][k] });
                    }
                    results.AddRange(current);
                }
                else
                {
                    results.Add(new List<Res>() { new Res { Position = k, Cost = matrix[0][k] } });
                }
            }
            return results;
        }
    }
}
