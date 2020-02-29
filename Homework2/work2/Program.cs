using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work2
{
    class Program
    {
        static void Main(string[] args)
        {
            //编程求一个整数数组最大值、最小值、和所有元素的和
            //以长度为20的数组为例

            int sum=0;//所有元素的和
            int max=int.MinValue;//最大值
            int min=int.MaxValue;//最小值
            float average;//平均值

            int[] arr=new int[20];//创建一个数组

            Random rnd = new Random();//创建一个随机数对象

            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = rnd.Next(1, 100);//产生0-99之间的随机数
                sum += arr[i];
                if(max<=arr[i])
                {
                    max = arr[i];
                }
                if(min>=arr[i])
                {
                    min = arr[i];
                }

                Console.Write(arr[i] + " ");
                
            }
            Console.WriteLine();
            average = (float)sum / arr.Length;
            Console.WriteLine("数组的最大值是:" + max);
            Console.WriteLine("数组的最小值是:" + min);
            Console.WriteLine("数组的平均值是:" + average);
            Console.WriteLine("数组的总和:" + sum);
            Console.ReadLine();

        }
    }
}
