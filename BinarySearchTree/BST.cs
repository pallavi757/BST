using System;
using System.Collections.Generic;


namespace BinarySearchTree
{
    public class BST<T> where T : IComparable
    {
        public T NodeData { get; set; }
        public BST<T> LeftTree { get; set; }
        public BST<T> RightTree { get; set; }

        public BST(T nodeData)
        {
            this.NodeData = nodeData;
            this.LeftTree = null;
            this.RightTree = null;
        }

        int leftCount = 0;
        int rightCount = 0;
        bool result = false;
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.LeftTree == null)
                {
                    this.LeftTree = new BST<T>(item);
                }
                else
                {
                    this.LeftTree.Insert(item);
                }
                this.leftCount++;
            }
            else
            {
                if (this.RightTree == null)
                {
                    this.RightTree = new BST<T>(item);
                }
                else
                {
                    this.RightTree.Insert(item);
                }
                this.rightCount++;
            }
        }
        public void GetSize()
        {
            Console.WriteLine("Size :" + (this.leftCount + this.rightCount + 1));
        }
        public bool Search(T element, BST<T> node)
        {
            bool result = false;
            if (node == null)
            {
                return false;
            }
            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("Search perticular node:" + node.NodeData);
                result = true;
            }
            else
            {
                Console.WriteLine("Current node is :" + node.NodeData);
            }
            if (element.CompareTo(node.NodeData) < 0)
            {
                Search(element, node.LeftTree);
            }
            if (element.CompareTo(node.NodeData) > 0)
            {
                Search(element, node.RightTree);
            }
            return result;
        }
        public void Display()
        {
            if (this.LeftTree != null)
            {
                this.LeftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.RightTree != null)
            {
                this.RightTree.Display();
            }
        }
    }
}