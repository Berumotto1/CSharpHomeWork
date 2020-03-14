using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work2
{
    
    public class AlarmClock
    {
        public Clock clock = new Clock();

        public AlarmClock()
        {
            //time.TimeOut += Tick;
            clock.Alarm += Alarm;
            clock.Tick += Tick;
        }

        void Tick(object sender,ClockEventArgs args)
        {
            Console.WriteLine("闹钟发出了滴答声....");
        }

        void Alarm(object sender, ClockEventArgs args)
        {
            Console.WriteLine("该起床了！！（BGM:哈利路亚）");
        }
    }
}
