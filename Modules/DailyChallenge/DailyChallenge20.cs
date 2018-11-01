using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge20
    {
        private class Room
        {
            public List<Lecture> Lectures = new List<Lecture>();
        }

        private class Lecture
        {
            public int Start;
            public int End;
        }

        public int Proceed(IEnumerable<Tuple<int,int>> data)
        {
            IEnumerable<Tuple<int, int>> sorted = data.OrderBy(x => x.Item1);
            List<Room> rooms = new List<Room>();
            foreach (var lecture in sorted)
            {
                if (TryAddForExistingRoom(rooms, lecture))
                {
                    continue;
                }
                Room room = new Room();
                room.Lectures.Add(new Lecture { Start = lecture.Item1, End = lecture.Item2 });
                rooms.Add(room);
            }
            return rooms.Count;
        }

        private bool TryAddForExistingRoom(List<Room> rooms, Tuple<int, int> lecture)
        {
            foreach (var room in rooms)
            {
                Lecture lastLect = room.Lectures.Last();
                if (lecture.Item1 >= lastLect.End)
                {
                    // Add on end
                    room.Lectures.Add(new Lecture { Start = lecture.Item1, End = lecture.Item2 });
                    return true;
                }
            }
            return false;
        }
    }
}
