using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入链表的长度:");
            int length =Convert.ToInt32(Console.ReadLine());
            int[] arr=new int[length];
            
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            for(int i=0;i<length; i++)
            {
                arr[i] = rnd.Next(1, 100);
            }
            Console.WriteLine("链表构建中...");
            GenericList<int> list = new GenericList<int>();
            foreach(int i in arr)
            {
                list.Add(i);
            }

            //打印链表元素
            GenericList<int>.ForEach(list, m => Console.WriteLine(m));

            int max = int.MinValue;
            int min = int.MaxValue;
            int sum = 0;
            GenericList<int>.ForEach(list, m =>
            {
                if (m > max)
                    max = m;
                if (m < min)
                    min = m;
                sum += m;
            });
            Console.WriteLine("Max:" + max);
            Console.WriteLine("Min:" + min);
            Console.WriteLine("Sum:" + sum);
            Console.Read();
        }
    }
}
