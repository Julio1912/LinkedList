using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedList
{
    class LinkedList
    {
        public Node insertbeg(int value,Node first) {
            Node temp=new Node(value,first);
            first = temp;
            return first;
        }

        public void GetElements(Node n) {
            Node temp = n;
            while (temp != null)
            {
                Console.Write(temp.value + " ");
                temp= temp.link;
            }
            Console.WriteLine("");
        }

        public Node insertend(Node first,int value) {
            Node ptr = first;
            while (ptr.link != null) {
                ptr = ptr.link;
            }
            Node temp = new Node(value,null);
            ptr.link = temp;
            return first;
        }

        public Node insertmiddle(int value,Node first,int entry) {
            Node ptr = first;
            while(ptr.value!=value){
                ptr = ptr.link;
            }
            Node temp = new Node(entry,ptr.link);
            ptr.link = temp;
            return first;
        }

        public Node deletebeg(Node n) {
            n = n.link;
            return n;
        }

        public Node deleteend(Node first) {
            Node ptr = first;
            while((ptr.link).link!=null){
                ptr = ptr.link;
            }
            ptr.link = null;
            return first;
        }
    }
}
