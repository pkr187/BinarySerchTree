using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerchTree
{
    internal class Node<T>
    {
        public T data;
        public Node<T> leftNode;
        public Node<T> rightNode;

        ///<summary>
        ///Constructor To Initialize data
        ///Binary Search Tree contains definition of three Parameters - data, left and right node.
        ///</summary>
        public Node(T data)
        {
            this.data = data;
            this.leftNode = null;
            this.rightNode = null;
        }
    }
}
    

