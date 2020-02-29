using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input a number:");

            int num;
            String str = Console.ReadLine();
            if(int.TryParse(str,out num))
            {
                Console.WriteLine(num+"的素数因子有:");
                Prime(num);
            }
            else
            {
                Console.WriteLine("数据格式输入错误！");
            }
        }

        //求因子的函数
        public static void Prime(int num)
        {
            for(int i=1;i*i<=num;i++)   //开平方效率比较低  可以改为k*k<=num
            {
                if(num%i==0)
                {
                    if(IsPrime(i))
                    {
                        Console.Write(i + " ");
                    }
                    if(i!=num/i && IsPrime(num/i))
                    {
                        Console.Write(num / i + " ");
                    }
                }
            }

        }

        //判断一个数 是否是素数
        public static bool IsPrime(int num)
        {
            if(num>=2)
            {
                for (int i = 2; i <= Math.Sqrt(num);i++)
                {
                    if(num%i==0)
                    {
                        return false;
                    }
                }

                return true;         
            }
            else
            {
                return false;
            }
        }
    }
}
