using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public class Node<T>  //链表节点类
    {
        public Node<T> Next  //Next属性 
        {
            get;
            set;
        }

        public T Data { get; set; }


        public Node(T t)
        {
            Data = t;
            Next = null;
        }
    }
}
