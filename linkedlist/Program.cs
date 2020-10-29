using System;

namespace linkedlist
{
    class Program
    {
        public class LinkedList
        {
            Node head;
            public class Node
            {

                public int data;
                public Node next;

                public Node(int d)
                {
                    data = d;
                    next = null;
                }
            }

            // A simple and tail recursive function to reverse 
            // a linked list. prev is passed as NULL initially. 
            Node reverseUtil(Node curr, Node prev)
            {

                /* If last node mark it head*/
                if (curr.next == null)
                {
                    head = curr;

                    /* Update next to prev node */
                    curr.next = prev;

                    return head;
                }

                /* Save curr->next node for recursive call */
                Node next1 = curr.next;

                /* and update next ..*/
                curr.next = prev;

                reverseUtil(next1, curr);
                return head;
            }

            // prints content of double linked list 
            void printList(Node node)
            {
                while (node != null)
                {
                    Console.Write(node.data + " ");
                    node = node.next;
                }
            }

            // Driver code 
            public static void Main(String[] args)
            {
                LinkedList list = new LinkedList();
                list.head = new Node(1);
                list.head.next = new Node(2);
                list.head.next.next = new Node(3);
                list.head.next.next.next = new Node(4);
                list.head.next.next.next.next = new Node(5);
                list.head.next.next.next.next.next = new Node(6);
                list.head.next.next.next.next.next.next = new Node(7);
                list.head.next.next.next.next.next.next.next = new Node(8);

                Console.WriteLine("Original Linked list ");
                list.printList(list.head);
                Node res = list.reverseUtil(list.head, null);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Reversed linked list ");
                list.printList(res);
            }
        }

        // This code contributed by Rajput-Ji 
    }
}
