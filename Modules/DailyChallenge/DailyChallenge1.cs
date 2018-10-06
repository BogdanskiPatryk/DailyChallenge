using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge
{
    public class DailyChallenge1
    {
        /*
         * Given the root to a binary tree, implement serialize(root), which serializes the tree into a string, and deserialize(s), which deserializes the string back into the tree.
            For example, given the following Node class
            class Node:
                def __init__(self, val, left=None, right=None):
                    self.val = val
                    self.left = left
                    self.right = right
            The following test should pass:
            node = Node('root', Node('left', Node('left.left')), Node('right'))
            assert deserialize(serialize(node)).left.left.val == 'left.left'
         */

        public class Node
        {
            public string Value { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
        }

        public string Serialize(Node node)
        {
            StringBuilder sb = new StringBuilder();
            SerializeIntern(node, sb, 0, 0);
            return sb.ToString();
        }

        private void SerializeIntern(Node node, StringBuilder sb, int level, int index)
        {
            sb.AppendLine($"{level}.{index}.{node.Value}");
            if (node.Left != null)
            {
                SerializeIntern(node.Left, sb, level + 1, index * 2);
            }
            if (node.Right != null)
            {
                SerializeIntern(node.Right, sb, level + 1, index * 2 + 1);
            }
        }

        public Node Deserialize(string data)
        {
            var queue = new Queue<string>();
            using (StringReader sr = new StringReader(data))
            {
                string line = sr.ReadLine();
                do
                {
                    queue.Enqueue(line);
                    line = sr.ReadLine();
                }
                while (string.IsNullOrWhiteSpace(line) == false);
            }
            return DeserializeIntern(queue, 0, 0);
        }

        private Node DeserializeIntern(Queue<string> rows, int level, int index)
        {
            if (rows.Any() == false)
            {
                return null;
            }
            Node node = null;
            string strLine = rows.Peek();
            ParseLine(strLine, out int readLevel, out int readIndex, out string value);
            if (level == readLevel && index == readIndex)
            {
                rows.Dequeue();
                node = new Node() { Value = value };
                node.Left = DeserializeIntern(rows, level + 1, index * 2);
                node.Right = DeserializeIntern(rows, level + 1, index * 2 + 1);
            }
            return node;
        }

        private void ParseLine(string strLine, out int level, out int index, out string value)
        {
            int indexFirstDot = strLine.IndexOf('.');
            int indexSecondDot = strLine.IndexOf('.', indexFirstDot + 1);
            level = int.Parse(strLine.Substring(0, indexFirstDot));
            index = int.Parse(strLine.Substring(indexFirstDot + 1, indexSecondDot - indexFirstDot - 1));
            value = strLine.Substring(indexSecondDot + 1);
        }
    }
}