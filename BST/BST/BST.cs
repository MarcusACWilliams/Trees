using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class BST
    {
        Node Root { get; set; }

        int Count { get; set; }
        int Tree_Depth { get; set; }

        BST()
        {
            Console.WriteLine("Creating an Empty Binary Search Tree");
        }

        //Create Tree with Starting Node
        BST(Node node)
        {
            Root = node;
        }

        //Insert Node into Top Node in tree
        public void Insert(Node NewNode, Node ThatNode)
        {
            if(NewNode.ID > ThatNode.ID)
            {

            }
                
        }
        
        public void Remove(Node node) { }

        public void Sort() { }

        public void Find(int Value) { }

        //Use Tree Depth to properly format print statement
        public void PrintTree() { }

       


    }
}
