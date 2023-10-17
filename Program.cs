using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    public class Program
    {

        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {
            DoubleLinkedList doublyLinkedList = new DoubleLinkedList();

            // Adding nodes with predefined values
            Node node1 = new Node { Data = "Array" };
            Node node2 = new Node { Data = "Stack" };
            Node node3 = new Node { Data = "Queue" };

            doublyLinkedList.Add(node1);
            doublyLinkedList.Add(node2);
            doublyLinkedList.Add(node3);

            Console.WriteLine("Forward Traversal:");
            Node current = doublyLinkedList.GetRoot();
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = doublyLinkedList.GetNext();
            }

            Console.WriteLine("Backward Traversal:");
            current = doublyLinkedList.GetCurrent();
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = doublyLinkedList.GetPrev();
            }

            Console.ReadLine(); 

        }
    }
 }
