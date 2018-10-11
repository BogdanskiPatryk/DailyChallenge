using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge5
    {
        private class Node
        {
            public int Element;
            public int Both;
        }

        private int _firstAddress = -1;
        private int _lastAddress = -1;

        public void Add(int element)
        {
            Node first = DereferencePointer(_firstAddress);
            if (first == null)
            {
                // First element
                first = new Node() { Element = element, Both = 0 };
                _firstAddress = GetPointer(first);
                _lastAddress = _firstAddress;
                return;
            }
            // Add
            Node newNode = new Node() { Element = element, Both = _lastAddress };
            Node last = DereferencePointer(_lastAddress);
            last.Both = _lastAddress ^ GetPointer(newNode);
            _lastAddress = GetPointer(newNode);
        }

        public int Get(int index)
        {
            if (index < 0 || _firstAddress == -1)
            {
                throw new ArgumentOutOfRangeException();
            }
            int i = 0;
            int currentAdd = _firstAddress;
            while (true)
            {
                Node currentNode = DereferencePointer(currentAdd);
                if (i++ == index)
                {
                    return currentNode.Element;
                }
                if (currentAdd == _lastAddress)
                {
                    throw new ArgumentOutOfRangeException();
                }
                currentAdd = currentAdd ^ currentNode.Both;
            }
        }

        #region memory

        private List<Node> _memoryAccess = new List<Node>();

        private int GetPointer(Node node)
        {
            int index = _memoryAccess.IndexOf(node);
            if (index < 0)
            {
                _memoryAccess.Add(node);
                index = _memoryAccess.Count - 1;
            }
            return index;
        }

        private Node DereferencePointer(int pointer)
        {
            if (pointer < 0 || pointer >= _memoryAccess.Count)
            {
                return null;
            }
            return _memoryAccess[pointer];
        }

        #endregion memory
    }
}