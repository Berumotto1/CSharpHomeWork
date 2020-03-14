using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work2
{
    public delegate void ClockHandler(Object sender, ClockEventArgs args);

    
    public class ClockEventArgs
    {
        public int Hour { set; get; }
        public int Minute { set; get; }
        public int Second { set; get; }
    }
}
