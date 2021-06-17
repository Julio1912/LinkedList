using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedList
{
    class Node
    {
        public Node(int value,Node link) {
            this.value = value;
            this.link = link;
        }
        public int value { get; set; }
        public Node link { get; set; }
    }
}
