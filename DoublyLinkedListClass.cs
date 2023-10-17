﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DoublyLinkedList
{
    public class DoubleLinkedList
    {
        private Node root = null;
        private Node current = null;
        private int length;

        public Node Root
        {
            get { return this.root; }
            set { this.root = value; }
        }

        public int Length
        {
            get { return this.length; }
            set { this.length = value; }
        }

        public void Add(Node node)
        {
            node.Next = null;
            if (root == null)
            {
                root = node;
                length = 1;
                current = root;
                root.Prev = null;
            }
            else
            {
                current.Next = node;
                node.Prev = current;
                current = node;
                length++;
            }
        }

        public Node GetCurrent()
        {
            return this.current;
        }

        public Node GetRoot()
        {
            current = root;
            return this.root;
        }

        public Node GetNext()
        {
            if (current.Next != null)
            {
                current = current.Next;
                return current;
            }
            else
                return null;
        }

        public Node GetPrev()
        {
            if (current.Prev != null)
            {
                current = current.Prev;
                return current;
            }
            else
                return null;
        }

        public int GetLengthOfList()
        {
            return this.length;
        }

    }
    

}
