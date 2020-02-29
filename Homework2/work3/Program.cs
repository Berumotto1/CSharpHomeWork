using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work3
{
    class Program
    {
        static void Main(string[] args)
        {
     
            bool[] arr = new bool[100];
            arr[0] = true;//2-100之间的素数  首先去掉1
                           //根号100=10  小于10的质数有  2  3  5 7

            Prime(100, arr);
            for(int i=0;i<arr.Length; i++)
            {
                if(!arr[i])
                {
                    Console.Write(i + 1 + " ");
                }
            }
            Console.ReadLine();


        }

        public static void Prime(int num,bool[] arr)
        {
            for(int i=2;i*i<=num;i++)
            {
                if(IsPrime(i))
                {
                    //要得到自然数n以内的全部素数，必须把不大于 根号n 的所有素数的倍数剔除，剩下的就是素数。
                    //i为素数
                    for (int j=2;i*j<=num;j++)
                    {
                        arr[i * j-1] = true;
                    }
                }
            }
        }

        public static bool IsPrime(int num)
        {
            if (num >= 2)
            {
                for (int i = 2; i*i<=num; i++)
                {
                    if (num % i == 0)
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
