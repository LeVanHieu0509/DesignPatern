using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDesignPatern.LinkList
{
    class Node
    {
        public int element;
        public Node next;
        public Node(int element, Node next)
        {
            this.element = element;
            this.next = next;
        }

        public int getData()
        {
            return element;
        }
        public Node getNext()
        {
            return next;
        }
    }
}

