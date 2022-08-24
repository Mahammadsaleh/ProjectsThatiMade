using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class Program
    {
      
        class Node
        {
            public Node LeftNode { get; set; }
            public Node RightNode { get; set; }
            public int Id { get; set; }
            public string Name { get; set; }
        }
        class BinaryTree
        {
            public Node Root { get; set; }
            public int length;
            public bool Add(int id, string name)
            {
                Node before = null;
                Node after = this.Root;

                while (after != null)
                {
                    before = after;
                    if (id < after.Id) //Is new node in left tree? 
                        after = after.LeftNode;
                    else if (id > after.Id) //Is new node in right tree?
                        after = after.RightNode;
                    else
                    {
                        //Exist same value
                        return false;
                    }
                }

                Node newNode = new Node();
                newNode.Id = id;
                newNode.Name = name;
                if (this.Root == null)//Tree ise empty
                    this.Root = newNode;
                else
                {
                    if (id < before.Id)
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
                return node.Id;
            }
            public int MaxValue()
            {
                Node node = Root;
                while (node.RightNode != null)
                {
                    node = node.RightNode;
                }
                return node.Id;
            }
            public void PreOrder(Node parentRoot)
            {
                if (parentRoot != null)
                {
                    Console.Write(parentRoot.Id + " " + parentRoot.Name + "\n");
                    PreOrder(parentRoot.LeftNode);
                    PreOrder(parentRoot.RightNode);
                }
            }
            public void InOrder(Node parentRoot)
            {
                if (parentRoot != null)
                {
                    InOrder(parentRoot.LeftNode);
                    Console.Write(parentRoot.Id +" "+parentRoot.Name+"\n");
                    InOrder(parentRoot.RightNode);
                }
            }
            public void DecOrder(Node parentRoot)
            {
                if (parentRoot != null)
                {
                    DecOrder(parentRoot.LeftNode);
                    DecOrder(parentRoot.RightNode);
                    Console.Write(parentRoot.Id + " " + parentRoot.Name + "\n");
                }
            }
            public void Remove(int value)
            {
                this.Root = Remove(this.Root, value);
                length--;
            }

            private Node Remove(Node parent, int key)
            {
                if (parent == null) 
                {
                    return parent; 
                }

                if (key < parent.Id)
                {
                    parent.LeftNode = Remove(parent.LeftNode, key);
                }
                else if (key > parent.Id)
                {
                    parent.RightNode = Remove(parent.RightNode, key);
                }
                // if value is same as parent's value, then this is the node to be deleted  
                else
                {
                    // node with only one child or no child  
                    if (parent.LeftNode == null)
                        return parent.RightNode;
                    else if (parent.RightNode == null)
                        return parent.LeftNode;

                    // node with two children: Get the inorder successor (smallest in the right subtree)  
                    parent.Id = MinValue();

                    // Delete the inorder successor  
                    parent.RightNode = Remove(parent.RightNode, parent.Id);
                }

                return parent;
            }
            public string FindNode(Node node, int id) //sehv
            {
                
                Node before = null;
                Node after = this.Root;
                string Output = "";
                while (after != null)
                {
                    before = after;
                    if (node == null)
                        return Output = "not found";
                    else if (id < node.Id)
                    {
                        after = after.LeftNode;
                        return after.Name;
                    }
                    else if (id > node.Id)
                    {
                        after = after.RightNode;
                        return after.Name;
                    }
                }
                return Output ="found";
            }
            public string Find(int id) //recursiv
            {
                return this.Find(this.Root,id);
            }
            public string Find(Node node, int id)
            {
                string Output = "";
                if (node == null)
                    return Output = "not found";
                else if (id < node.Id)
                {
                    return Find(node.LeftNode,id); 
                }
                else if (id > node.Id)
                {
                    return Find(node.RightNode, id); 
                }
               
                return node.Name;
            }

        }
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();
           
            binaryTree.Add(2,"Saleh");
            binaryTree.Add(3, "Xalis");
            binaryTree.Add(5, "Rahib");
            binaryTree.Add(7, "Zahid");
            binaryTree.Add(4, "Xalid");

            binaryTree.Remove(7);//delete

            int len = binaryTree.length;//lenght
            Console.WriteLine("Tree lenght: " + len);

            Console.WriteLine("PreOrder:");
            binaryTree.PreOrder(binaryTree.Root);
            Console.WriteLine();

            Console.WriteLine("InOrder: ");
            binaryTree.InOrder(binaryTree.Root);
            Console.WriteLine();

            Console.WriteLine("Decreasing Order: ");
            binaryTree.DecOrder(binaryTree.Root);
            Console.WriteLine();

            Console.WriteLine("Founding 4rd id: " + binaryTree.FindNode(binaryTree.Root,4)); //sehvdir
            Console.WriteLine("Founding 4rd id: "+binaryTree.Find(4)); //duzdur

            Console.WriteLine("Minimum value: " + binaryTree.MinValue());
            Console.WriteLine("Maximum value: " + binaryTree.MaxValue());
            Console.ReadLine();
        }
    }
}