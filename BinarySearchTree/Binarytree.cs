using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Binarytree<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        public Binarytree<T> LeftTree { get; set; }
        public Binarytree<T> RightTree { get; set; }

        public Binarytree(T nodeData)
        {
            this.NodeData = nodeData;
            this.LeftTree = LeftTree;
            this.RightTree = RightTree;
        }
        int leftCount = 0, rightCount = 0;
        bool result = false;
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if (currentNodeValue.CompareTo(item) > 0)
            {
                if (this.LeftTree == null)
                    this.LeftTree = new Binarytree<T>(item);
                else
                    this.LeftTree.Insert(item);
            }
            else
            {
                if (this.RightTree == null)
                    this.RightTree = new Binarytree<T>(item);
                else
                    this.RightTree.Insert(item);
            }
        }

        /*public void Display()
        {
            if (this.LeftTree != null)
            {
                leftCount++;
                this.LeftTree.Display();

            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.RightTree != null)
            {
                this.rightCount++;
                this.RightTree.Display();
            }
        }*/

        public void Display(Binarytree<T> binarytree)
        {
            if (this.LeftTree != null)
            {
                binarytree.leftCount++;
                this.LeftTree.Display(binarytree);

            }

            if (this.RightTree != null)
            {
                binarytree.rightCount++;
                this.RightTree.Display(binarytree);
            }

            Console.WriteLine(this.NodeData.ToString());
        }

        
        public void GetSize(Binarytree<T> binarytree)
        {
            //Display(binarytree);
            Console.WriteLine("Size" + " " + (1 + this.leftCount + this.rightCount));
        }
                  
        
    }
}
