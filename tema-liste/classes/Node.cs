using System;

namespace tema_liste.classes
{
    public class Node
    {
        private Node next;
        private Object data;

        public Node()
        {
            
        }

        public Node(Object data, Node next)
        {
            this.data = data;
            this.next = next;
        }

        public Node Next
        {
            get => next;
            set => next = value;
        }

        public object Data
        {
            get => data;
            set => data = value;
        }
    }
}