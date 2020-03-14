using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public class GenericList<T> //泛型链表类
    {
        private Node<T> head; //头指针
        private Node<T> tail; //尾指针

        public GenericList()
        {
            head = tail = null;
        }

        public Node<T> Head //Head 属性
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> node = new Node<T>(t);
            if(tail==null)
            {
                head = tail = node;
            }
            else
            {
                //尾插法
                tail.Next = node;
                tail = node;
            }

        }

        public static void ForEach(GenericList<T> list, Action<T> action)
        {
            Node<T> node;
            node = list.head;
            while (node!=null)
            {
                action(node.Data);
                node = node.Next;
            }
        }

        
            
    }
}
