using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work2
{

    public class Clock
    {
        public event ClockHandler Alarm;//Alarm事件
        public event ClockHandler Tick;//Tick事件

        //public event ClockHandler aaaa;  事件没绑定函数也没报异常啊
        
        public int hour_1;
        public int minute_1;
        public int second_1;

        public void setTime(int h, int m, int s) //设置闹钟时间
        {
            hour_1 = h;
            minute_1 = m;
            second_1 = s;

        }

        public void TimeOut(int hour, int minute, int second)
        {

            ClockEventArgs args = new ClockEventArgs()
            {
                Hour = hour,
                Minute = minute,
                Second = second
            };

            //触发TimeOut 事件
            //此处应加上一个判断条件，看是否等于设定的时间，时间相等则触发

            //响一分钟
            if(args.Hour==hour_1&&args.Minute==minute_1/*&&args.Second==second_1*/)
            {
                //Console.WriteLine($"Now the time is {hour}:{minute}:{second}");
                Alarm(this, args);
            }

        }

        public void ClockRun(int hour, int minute, int second) //时钟正在运行,运行时会发出滴答声
        {
            Console.WriteLine($"Now the time is {hour}:{minute}:{second}");
            ClockEventArgs args = new ClockEventArgs()
            {
                Hour = hour,
                Minute = minute,
                Second = second
            };

            Tick(this, args);
        }

    }

}