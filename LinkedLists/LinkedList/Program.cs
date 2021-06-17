using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList l = new LinkedList();
            Node t = new Node(1,null);
            Console.WriteLine("INSERTION AT THE BEGINNING");
            t=l.insertbeg(23,t);
            t = l.insertbeg(11,t);
            t = l.insertbeg(43, t);
            t = l.insertbeg(28, t);
            l.GetElements(t);
            Console.WriteLine("INSERTION AT THE END");
            Node n = new Node(11,null);
            n = l.insertend(n,43);
            n = l.insertend(n, 28);
            n = l.insertend(n, 23);
            n = l.insertend(n, 8);
            l.GetElements(n);
            Console.WriteLine("INSERTION IN THE MIDDLE");
            n = l.insertmiddle(28,n,25);
            l.GetElements(n);
            Console.WriteLine("DELETING NODE FROM THE BEGINNING");
            n = l.deletebeg(n);
            l.GetElements(n);
            Console.WriteLine("DELETING NODE FROM THE END");
            t = l.deleteend(t);
            l.GetElements(t);
            Console.ReadKey();
        }
    }
}
