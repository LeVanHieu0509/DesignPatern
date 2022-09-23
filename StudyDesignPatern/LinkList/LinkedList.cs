using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDesignPatern.LinkList
{
    class LinkedList
    {
        //lock object
        public static readonly object key = new object();
        //apply singleton partern in LinkList
        public static volatile LinkedList linkedList;

        private Node head = null;
        private int count = 0;
        private LinkedList(Node head)
        {
            this.head = head;
        }
        private LinkedList()
        {
        }

        //Singleton
        public static LinkedList GetInstance()
        {
            if (linkedList == null)
            {
                lock (key)
                    if (linkedList == null)
                    {
                        linkedList = new LinkedList();
                    }
            }
            return linkedList;
        }

        public Node push(int element)
        {
            Node current;
            Node node = new Node(element, null);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                current = this.head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = node;
            }
            this.count++;
            return node;
        }
        public int size()
        {
            return this.count;
        }
        public string toString()
        {
            StringBuilder stringBuilder = new StringBuilder(count);
            stringBuilder.Append("[");

            Node currentNode = this.head;

            while (currentNode != null)
            {
                stringBuilder.Append(currentNode.getData());
                if (currentNode.getNext() != null)
                {
                    stringBuilder.Append(", ");
                }
                currentNode = currentNode.getNext();
            }
            stringBuilder.Append(" ]");
            return stringBuilder.ToString();
        }

        public Node getElementAt(int index)
        {
            if (index > this.size() && index < 0)
            {
                return null;
            }
            Node current = this.head;
            for (int i = 0; i < index && current != null; i++)
            {
                current = current.next;
            }
            return current;
        }

        public Node insertAt(int element, int index)
        {
            if (index < 0 || index > this.size())
            {
                return null;
            }
            Node node = new Node(element, null);
            if (index == 0)
            {
                var current = this.head;
                node.next = current;
                this.head = node;
            }
            else
            {
                var previous = getElementAt(index - 1);
                var current = previous.next;
                node.next = current;
                previous.next = node;
            }
            this.count++;
            return node;
        }

        public int indexOf(int element)
        {
            var current = this.head;
            for (var i = 0; i < this.size() && current != null; i++)
            {
                if (element == current.getData())
                {
                    return i;
                }
                current = current.next;
            }
            return -1;
        }
        public Node removeAt(int index)
        {
            if (index < 0 || index > this.size())
            {
                return null;
            }
            var current = this.head;
            if (index == 0)
            {
                this.head = current.next;
            }
            else
            {
                var previous = getElementAt(index - 1);
                current = previous.next;
                previous.next = current.next;
            }
            this.count--;
            return current;
        }

        public Node remove(int element)
        {
            var index = this.indexOf(element);
            return this.removeAt(index);
        }

        public bool isEmpty()
        {
            return this.size() == 0;
        }

        public Node getHead()
        {
            return this.head;
        }

        public void clear()
        {
            this.head = null;
            this.count = 0;
        }
    }
    
}
