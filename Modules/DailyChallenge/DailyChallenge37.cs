using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge37
    {
        /*
         * You have an N by N board. Write a function that, given N, returns the number of possible arrangements of the board where N 
         * queens can be placed on the board without threatening each other, i.e. no two queens share the same row, column, or diagonal.
         */

        class Point
        {
            public int X;
            public int Y;
        }

        public int Proceed(int N)
        {
            int result = ProceedIntern(0, N, new List<Point>());

            return result;
        }

        private int ProceedIntern(int columndIndex, int N, List<Point> infected)
        {
            if (columndIndex >= N)
            {
                return infected.Count >= N ? 1 : 0;
            }
            int result = 0;
            for (int row = 0; row < N; ++row)
            {
                if (Collision(columndIndex, row, N, infected) == false)
                {
                    List<Point> newInfected = new List<Point>();
                    newInfected.AddRange(infected);
                    newInfected.Add(new Point { X = columndIndex, Y = row });
                    result += ProceedIntern(columndIndex + 1, N, newInfected);
                }
            }
            return result;
        }

        private bool Collision(int x, int y, int N, List<Point> infected)
        {
            if (infected.Any(i => i.X == x))
            {
                return true;
            }
            if (infected.Any(i => i.Y == y))
            {
                return true;
            }
            // We do not need check on the right side
            int cX = x - 1;
            int cY = y - 1;
            while (cX >= 0 && cY>= 0)
            {
                if (infected.Any(i => i.X == cX && i.Y == cY))
                {
                    return true;
                }
                cX--;
                cY--;
            }
            cX = x - 1;
            cY = y + 1;
            while (cX >= 0 && cY < N)
            {
                if (infected.Any(i => i.X == cX && i.Y == cY))
                {
                    return true;
                }
                cX--;
                cY++;
            }
            return false;
        }
    }
}
