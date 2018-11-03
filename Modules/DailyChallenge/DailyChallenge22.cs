using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge22
    {
        /*
         * You are given an M by N matrix consisting of booleans that represents a board. Each True boolean represents a wall. Each False boolean represents a tile you can walk on.
Given this matrix, a start coordinate, and an end coordinate, return the minimum number of steps required to reach the end coordinate from the start. If there is no possible path, then return null. You can move up, left, down, and right. You cannot move through walls. You cannot wrap around the edges of the board.
For example, given the following board:
[[f, f, f, f],
[t, t, f, t],
[f, f, f, f],
[f, f, f, f]]
and start = (3, 0) (bottom left) and end = (0, 0) (top left), the minimum number of steps required to reach the end is 7, since we would need to go through (1, 2) because there is a wall everywhere else on the second row.

         * 
         */


        public class Point : IEquatable<Point>
        {
            public int Row;
            public int Col;

            public bool Equals(Point other)
            {
                return other.Row == Row && other.Col == Col;
            }
        }

        private class PointComparer : IEqualityComparer<Point>
        {
            public bool Equals(Point x, Point y)
            {
                return x.Equals(y);
            }

            public int GetHashCode(Point obj)
            {
                int hash = 23;
                hash = hash * 31 + obj.Col;
                hash = hash * 31 + obj.Row;
                return hash;
            }
        }

        private List<Point> _visited;
        private List<Point> _toVisit;
        private Dictionary<Point, double> _score;
        private Dictionary<Point, double> _fScore;
        private Dictionary<Point, Point> _path;

        public int Proceed(bool [][] map, Point start, Point end)
        {
            _visited = new List<Point>();
            _toVisit = new List<Point>();
            _score = new Dictionary<Point, double>(new PointComparer());
            _fScore = new Dictionary<Point, double>(new PointComparer());
            _path = new Dictionary<Point, Point>(new PointComparer());
            _toVisit.Add(start);
            _score[start] = 0;
            _fScore[start] = Distance(start, end);
            while(_toVisit.Any())
            {
                Point current = _toVisit.OrderBy(x => _fScore[x]).First();
                _toVisit.Remove(current);
                _visited.Add(current);
                foreach (int row in new int[] { -1, 1 })
                {
                    Visit(current, new Point() { Row = current.Row + row, Col = current.Col },end, map);
                }
                foreach (int column in new int[] { -1, 1 })
                {
                    Visit(current, new Point() { Col = current.Col + column, Row = current.Row },end, map);
                }
            }
            if (_path.ContainsKey(end))
            {
                return ReconstructPath(end);
            }
            return -1;
        }

        private void Visit(Point current, Point toVisit, Point end, bool[][] map)
        {
            if (toVisit.Col < 0 || toVisit.Col >= map.Length || toVisit.Row < 0 || toVisit.Row >= map.Length)
            {
                return;
            }
            if (map[toVisit.Row][toVisit.Col])
            {
                // wall
                return;
            }
            if (_visited.Any(x => x.Equals(toVisit)))
            {
                return;
            }
            double newScore = _score[current] + Distance(current, toVisit);
            if (_toVisit.Any(x => x.Equals(toVisit)) == false)
            {
                _toVisit.Add(toVisit);
            }
            else if (newScore >= _score[toVisit])
            {
                return;
            }
            _path[toVisit] = current;
            _score[toVisit] = newScore;
            _fScore[toVisit] = newScore + Distance(toVisit, end);
        }

        private int ReconstructPath(Point point)
        {
            int result = 0;
            while (_path.TryGetValue(point, out point))
            {
                ++result;
            }
            return result;
        }

        private double Distance(Point current, Point end)
        {
            return Math.Sqrt(Math.Pow(end.Row - current.Row, 2) + Math.Pow(end.Col - current.Row, 2));
        }
    }
}
