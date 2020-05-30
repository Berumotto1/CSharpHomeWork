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
            AlarmClock Aclock = new AlarmClock();
            Console.WriteLine("现在的时间是:" + DateTime.Now.ToLongTimeString().ToString());
            Console.WriteLine("请输入你要设置的闹钟时间（格式： 12:00:00）:");
            Console.WriteLine("注意:当你设置的闹钟时间和当前时间的分钟相同时，Alarm会一直持续下去");

            string str = Console.ReadLine();
            string[] arr = str.Split(':');

            int h= Convert.ToInt32(arr[0]);
            int m= Convert.ToInt32(arr[1]);
            int s= Convert.ToInt32(arr[2]);
            Aclock.clock.setTime(h, m, s);//设置闹钟时间

            while(true)
            {
                //获取当前时间
                int h1 = DateTime.Now.Hour;
                int m1 = DateTime.Now.Minute;
                int s1 = DateTime.Now.Second;

                Aclock.clock.ClockRun(h1, m1, s1);
                Aclock.clock.TimeOut(h1, m1, s1);
                System.Threading.Thread.Sleep(1000);
            }

        }
        

    }
}
