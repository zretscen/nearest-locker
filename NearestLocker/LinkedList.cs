using System;

namespace NearestLocker
{
    public class LinkedList
    {
        private Node _head;

        public LinkedList(Node head)
        {
            this._head = head;
        }

        public void PrintAllNodes()
        {
            Node cur = _head;
            while (cur.Next != null)
            {
                Console.WriteLine(cur.Data);
                cur = cur.Next;
            }
        }

        public void Add(Block data)
        {
            Node toAdd = new Node();
            toAdd.Data = data;
            Node current = _head;
            // traverse all nodes (see the print all nodes method for an example)
            current.Next = toAdd;
        }
    }

    public class Node
    {
        public Node Next;
        public Block Data;
    }

    public class Block
    {
        int _x;
        int _y;
        bool _isLocker;
        Block _neighbor;

        public Block(int x, int y, bool isLocker, Block neighbor = null)
        {
            _x = x;
            _y = y;
            _isLocker = isLocker;
            _neighbor = neighbor;
        }
    }
}
