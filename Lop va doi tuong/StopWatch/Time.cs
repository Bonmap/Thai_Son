using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLearn05
{
    internal class Time
    {
        private DateTime startTime, endTime;

        public Time()
        {
            this.startTime = DateTime.Now;
        }
        public void TimeRun()
        {
            this.endTime = DateTime.Now;
            Console.WriteLine("Time run: {0}", endTime - startTime);
        }
    }
}
