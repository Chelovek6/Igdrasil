using System;
using System.Collections.Generic;
using System.Text;

namespace Igdrasil
{
    class Node
    {
        private int _data;
        private Node _left;
        private Node _right;

        public Node()
        {
        }

        public Node(int inputDataNode)
        {
            Data = inputDataNode;
        }

        public Node(int data, Node left, Node right)
        {
            Data = data;
            Left = left;
            Right = right;
        }

        public int Data { get => _data; set => _data = value; }
        public Node Left { get => _left; set => _left = value; }
        public Igdrasil.Node Right { get => _right; set => _right = value; }
    }
}
