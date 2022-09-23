using Microsoft.CSharp.RuntimeBinder;
using StudyDesignPatern.LinkList;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace StudyDesignPatern.DoubleLinkedList
{
    public class DoubleLinkedList 
    {
        private NodeDB head = null;
        private NodeDB tail = null;
        private int size = 0; 

        private DoubleLinkedList(NodeDB head, NodeDB tail, int size)
        {
            this.head = head;
            this.tail = tail;
            this.size = size;
        }

        //clear
        public void clear()
        {
            NodeDB current = head;
            while(current != null)
            {
                NodeDB nextNode = current.getNext();
                nextNode.setNext(null);
                nextNode.setPrev(null);
                nextNode.setData(null);
                current = nextNode;
            }
            this.head = null;
            this.tail = null;
            size = 0;
        }
        //size
        public int sizeLinkedList()
        {
            return this.size;
        }
        //isEmpty
        public bool isEmpty()
        {
            //if size == 0 ==> true
            //if size != 0 ==> false

            return sizeLinkedList() == 0;
        }
        //addFirst
        public void addFirst(int element)
        {
            if (isEmpty())
            {
                head = tail = new NodeDB(element,null, null);
            }
            else
            {
                //create new node
                NodeDB newNode = new NodeDB(element,null,head);
                head.setPrev(newNode);
                head = head.getPrev();
            }
        }
        //addLast
        public void addLast(int element)
        {
            if (isEmpty())
            {
                head = tail = new NodeDB(element, null, null);
            }
            else
            {
                NodeDB newNode = new NodeDB(element, tail, null);
                tail.setNext(newNode);
                tail = tail.getNext();
            }
        }

        //removeFirst and return data
        public int? removeFirst()
        {
            if (isEmpty()) {
                throw new System.Exception("Empty LinkedList");
            }

            int? data = head.getData();
            head = head.getNext();
            size--;
            if (isEmpty()) tail = null;
            else head.setPrev(null);

            return data;
        }
        //removeLast
        public int? removeLast()
        {
            if (isEmpty())
            {
                throw new System.Exception("Empty LinkedList");
            }
            int? data = tail.getData();
            tail = tail.getPrev();
            size--;
            if (isEmpty()) head = null;
            else tail.setNext(null);

            return data;
        }
        //remove Node
        public int? removeNode(NodeDB nodeElement)
        {
            if (nodeElement.getNext() == null) removeLast();
            if (nodeElement.getPrev() == null) removeFirst();

            nodeElement.getPrev().setNext(nodeElement.getNext());
            nodeElement.getNext().setPrev(nodeElement.getPrev());

            int? data= nodeElement.getData();
            size--;

            //Memory leak
            nodeElement.setData(null);
            nodeElement.setPrev(null);
            nodeElement.setNext(null);

            nodeElement = null;

            return data;
        }

        //Romove object
       
        public Boolean removeObject(Object obj)
        {
            //solution
            //Nếu như object null thì phải loop qua tất cả các
            //linkedlist xem data thằng nào null => remove first gặp

            //Nếu như object != null => tìm cho đến khi nào data của
            //Node = object thì remove Node đó

            NodeDB currentNode = head;

            if(obj == null)
            {
                while (currentNode != null ) {
                    if(currentNode.getData() == null)
                    {
                        removeNode(currentNode);
                        return true;
                    }
                }
                currentNode = currentNode.getNext();
            }
            else
            {
                while(currentNode != null)
                {
                    if(currentNode.getData() == 1)
                    {
                        removeNode(currentNode);
                        return true;
                    }
                    currentNode = currentNode.getNext();
                }
            }
            return false;
        }
        //removeAt
        public int? removeAt(int index)
        {
            if(index < 0 || index >= size)
            {
                return -1;
            }

            int i = 0;

            NodeDB currentNode;

            if (index < size / 2)
            {
                currentNode = head;
                while (i != index)
                {
                    currentNode = currentNode.getNext();
                    i++;
                }
            }
            else
            {
                currentNode = tail;
                while (i != index)
                {
                    currentNode = currentNode.getPrev();
                    i--;
                }
            }
            return removeNode(currentNode);
        }
        //indexOf
        public NodeDB indexOf(int index)
        {
            var i = 0;
            NodeDB currentNode = head;

            return currentNode;
        }
        //toString
        //add


    }
}
