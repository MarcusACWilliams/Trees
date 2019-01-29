using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    interface INode
    {

        void PrintNode();
    }

    public class Node : INode
    {
        public int ID          { get; set; }
        public Node L_child    { get; set; }
        public Node R_child    { get; set; }

        public void PrintNode()
        {
            throw new NotImplementedException();
        }
    }

}
