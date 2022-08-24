using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class Program
    {
        struct Students
        {
            public string name;
            public int id;
        };
        class Node
        {
            public Node LeftNode { get; set; }
            public Node RightNode { get; set; }
            public int Data { get; set; }
        }
        class BinaryTree
        {
            public Node Root { get; set; }
            public int length;
            public bool Add(int value)
            {
                Node before = null;
                Node after = this.Root;

                while (after != null)
                {
                    before = after;
                    if (value < after.Data) //Is new node in left tree? 
                        after = after.LeftNode;
                    else if (value > after.Data) //Is new node in right tree?
                        after = after.RightNode;
                    else
                    {
                        //Exist same value
                        return false;
                    }
                }

                Node newNode = new Node();
                newNode.Data = value;

                if (this.Root == null)//Tree ise empty
                    this.Root = newNode;
                else
                {
                    if (value < before.Data)
                        before.LeftNode = newNode;
                    else
                        before.RightNode = newNode;
                }
                length++;
                return true;
            }
            
            public int MinValue()
            {
                Node node = Root;
                while (node.LeftNode != null)
                {
                    node = node.LeftNode;
                }
                return node.Data;
            }
            public int MaxValue()
            {
                Node node = Root;
                while (node.RightNode != null)
                {
                    node = node.RightNode;
                }
                return node.Data;
            }
            public void PreOrder(Node parentRoot)
            {
                if (parentRoot != null)
                {
                    Console.Write(parentRoot.Data + " ");
                    PreOrder(parentRoot.LeftNode);
                    PreOrder(parentRoot.RightNode);
                }
            }
            public void InOrder(Node parentRoot)
            {
                if (parentRoot != null)
                {
                    InOrder(parentRoot.LeftNode);
                    Console.Write(parentRoot.Data + " ");
                    InOrder(parentRoot.RightNode);

                }
            }
            public void DecOrder(Node parentRoot)
            {
                if (parentRoot != null)
                {
                    DecOrder(parentRoot.LeftNode);
                    DecOrder(parentRoot.RightNode);
                    Console.Write(parentRoot.Data + " ");
                }
            }


        }
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Add(1);
            binaryTree.Add(2);
            binaryTree.Add(8);
            binaryTree.Add(3);
            binaryTree.Add(4);
            binaryTree.Add(5);  
            binaryTree.Add(6);
            binaryTree.Add(7);
            int len = binaryTree.length;
            Console.WriteLine("Tree lenght: "+ len);
            Console.WriteLine("PreOrder:");
            binaryTree.PreOrder(binaryTree.Root);
            Console.WriteLine();
            Console.WriteLine("InOrder: ");
            binaryTree.InOrder(binaryTree.Root);
            Console.WriteLine();
            Console.WriteLine("Decreasing Order: ");
            binaryTree.DecOrder(binaryTree.Root);
            Console.WriteLine();
            Console.WriteLine("Minimum value: " + binaryTree.MinValue());
            Console.WriteLine("Maximum value: " + binaryTree.MaxValue());
            Console.ReadLine();
        }
    }
}
