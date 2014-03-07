using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2
{
    class LinkedList: IObservable
    {
        private class Node
        {
            public string item;
            public Node next;
            public Node prev;

            public Node(string s, Node nxt, Node prv)
            {
                item = s;
                next = nxt;
                prev = prv;
            }
        }
        
        List<IObserver> observers;
        Node head;
        Node tail;
        
        public LinkedList()
        {
            observers = new List<IObserver>();
        }

        public void Add(string s)
        {
            if (head == null)
            {
                head = new Node(s, null, null);
                tail = head;
            }
            else 
            {
                tail.next = new Node(s, null, tail);
                tail = tail.next;
            }
        }

        public void Delete(string s)
        {
            Node node = Find(s);
            if (node != null)
            {
                if (node == head)
                {
                    head.next.prev = null;
                    head = head.next;
                }
                else
                {
                    if (node == tail)
                    {
                        tail.prev.next = null;
                        tail = tail.prev;
                    }
                    else
                    {
                        node.prev.next = node.next;
                        node.next.prev = node.prev;
                        node = null;
                    }
                }
            }
            else 
            {
                MessageBox.Show("No such item in the list!");
            }
        }

        private Node Find(string s)
        {
            Node node = head;
            while (node != null)
            {
                if (node.item == s)
                    return node;
                else
                    node = node.next;
            }
            return null;
        }

        public string[] Map()
        {
            List<string> itemList = new List<string>();
            Node node = head;
            while (node != null)
            {
                itemList.Add(node.item);
                node = node.next;
            }
            return itemList.ToArray();             
        }
        
        public void AddObserver(IObserver observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer); 
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers(string state)
        {
            foreach(IObserver observer in observers)
            {
                observer.Update(state);
            }
        }


    }
}
