using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Time
    {
        private int hour;
        private int min;
        private int sec;
        public Time(int hour, int min, int sec)
        {
            this.hour = hour;
            this.min = min;
            this.sec = sec;
        }
        public Time(int hour, int min)
        {
            this.hour = hour;
            this.min = min;
            this.sec = 0;
        }
        public int getHour()
        {
            return hour;
        }
        public int getMin()
        {
            return min;
        }
        public int getSec()
        {
            return sec;
        }
    }
}
