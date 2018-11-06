using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge23
    {
        /*
         * Implement locking in a binary tree. A binary tree node can be locked or unlocked only if all of its descendants or ancestors are not locked.
Design a binary tree node class with the following methods:
•	is_locked, which returns whether the node is locked
•	lock, which attempts to lock the node. If it cannot be locked, then it should return false. Otherwise, it should lock it and return true.
•	unlock, which unlocks the node. If it cannot be unlocked, then it should return false. Otherwise, it should unlock it and return true.
You may augment the node to add parent pointers or any other property you would like. You may assume the class is used in a single-threaded program, so there is no need for actual locks or mutexes. Each method should run in O(h), where h is the height of the tree.

         */

        public class Node
        {
            private bool _locked;

            public Node Parent { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }

            private Guid _id = Guid.NewGuid();
            private List<Guid> _lockedBy = new List<Guid>();

            public bool IsLocked()
            {
                return _locked;
            }

            public bool Lock()
            {
                if (_locked || _lockedBy.Any())
                {
                    return false;
                }
                Node parent = Parent;
                while(parent != null)
                {
                    if (parent._locked)
                    {
                        return false;
                    }
                    parent = parent.Parent;
                }
                // We can lock
                parent = Parent;
                while (parent != null)
                {
                    parent._lockedBy.Add(_id);
                    parent = parent.Parent;
                }
                _locked = true;
                return true;
            }

            public bool Unlock()
            {
                if (_locked == false || _lockedBy.Any())
                {
                    return false;
                }
                Node parent = Parent;
                while (parent != null)
                {
                    if (parent._locked)
                    {
                        return false;
                    }
                    parent = parent.Parent;
                }
                // We can unlock
                parent = Parent;
                while (parent != null)
                {
                    parent._lockedBy.Remove(_id);
                    parent = parent.Parent;
                }
                _locked = false;
                return true;
            }
        }
    }
}
