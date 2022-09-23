using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDesignPatern.DoubleLinkedList
{
    public class NodeDB
    {
        private int? data;
        private NodeDB previous;
        private NodeDB next;

        public NodeDB(int data,NodeDB previous, NodeDB next) {
            this.data = data;
            this.previous = previous;
            this.next = next;
        }

        //getData
        public int? getData()
        {
           return data;
        }
        //setData
        public int? setData(int? data)
        {
            return this.data = data;
        }
        //getPrev
        public NodeDB getPrev()
        {
            return previous;
        }
        //setPrev
        public NodeDB setPrev(NodeDB prev)
        {
            return this.previous = prev;
        }
        //getNext
        public NodeDB getNext()
        {
            return next;
        }
        //setNext
        public NodeDB setNext(NodeDB next)
        {
            return this.next = next;
        }

       
        //To String

    }
}
