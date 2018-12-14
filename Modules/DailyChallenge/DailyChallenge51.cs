using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    /*
     * Implement an LRU (Least Recently Used) cache. It should be able to be initialized with a cache size n, and contain the following methods:
•	set(key, value): sets key to value. If there are already n items in the cache and we are adding a new item, then it should also remove the least recently used item.
•	get(key): gets the value at key. If no such key exists, return null.
Each operation should run in O(1) time.

     */

    public class DailyChallenge51<Key,Value>
    {
        private uint _n;
        private LinkedList<KeyValuePair<Key, Value>> _items = new LinkedList<KeyValuePair<Key, Value>>();
        private Dictionary<Key, LinkedListNode<KeyValuePair<Key, Value>>> _cache = new Dictionary<Key, LinkedListNode<KeyValuePair<Key, Value>>>();

        public DailyChallenge51(uint n)
        {
            _n = n;
        }

        public void Set(Key key, Value value)
        {
            if (_cache.ContainsKey(key))
            {
                _items.Remove(_cache[key]);
                _cache[key] = _items.AddLast(new KeyValuePair<Key, Value>(key, value));

            }
            else
            {
                if (_items.Count == _n)
                {
                    _cache.Remove(_items.First.Value.Key);
                    _items.RemoveFirst();

                }
                _cache[key] = _items.AddLast(new KeyValuePair<Key, Value>(key, value));
            }
        }

        public Value Get(Key key)
        {
            if (_cache.TryGetValue(key, out LinkedListNode<KeyValuePair<Key, Value>> value) == false)
            {
                return default(Value);
            }
            _items.Remove(value);
            _items.AddLast(value);
            return value.Value.Value;
        }
    }
}
