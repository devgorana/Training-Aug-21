using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp_Practice_Event
{
    class Program
    {
        static void Main(string[] args)
        {
            var theClock = new Clock();
            var visibleClock = new VisibleClock();
            visibleClock.Subscribe(theClock);
            var logger = new Logger();
            logger.Subscribe(theClock);
            theClock.RunClock();

        }
    }

    public class Clock
    {
        private int hour;
        private int minute;
        private int second;

        public delegate void TimeChangeHandler(object clock, TimeEventArgs timeInfo);
        public event TimeChangeHandler TimeChanged;

        public void RunClock()
        {
            while (true)
            {
                Thread.Sleep(100);
                DateTime currentTime = DateTime.Now;
                if(currentTime.Second != this.second)
                {
                    TimeEventArgs timeEventArgs = new TimeEventArgs()
                    {
                        Hour = currentTime.Hour,
                        Minute = currentTime.Minute,
                        Second = currentTime.Second
                    };
                    if (TimeChanged != null)
                    {
                        TimeChanged(this, timeEventArgs);
                    }
                    this.second = currentTime.Second;
                    this.minute = currentTime.Minute;
                    this.hour = currentTime.Hour;
                }
            }
        }
    }

    public class TimeEventArgs : EventArgs
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }

    }
    public class VisibleClock
    {
        public void Subscribe(Clock theClock)
        {
            theClock.TimeChanged += new Clock.TimeChangeHandler(NewTime);
        }

        //public Clock.TimeChangeHandler NewTime { get; set; }
        public void NewTime(object theClock, TimeEventArgs e)
        {
            Console.WriteLine("{0}:{1}:{2}", e.Hour.ToString(), e.Minute.ToString(), e.Second.ToString());
        }
    }

    public class Logger
    {
        /*
        public void Subscribe(Clock theClock)
        {
            theClock.TimeChanged += new Clock.TimeChangeHandler(NewTime);
        }
        public void NewTime(object theClock, TimeEventArgs e)
        {
            Console.WriteLine("Logging event at {0}:{1};{2}", e.Hour.ToString(), e.Minute,ToString(), e.Second.ToString());
        }
        */


        //Using Anonymous methods
        /*
        public void Subscribe(Clock theClock)
        {
            theClock.TimeChanged += delegate(object sender, TimeEventArgs e)
            {
                Console.WriteLine("Logging event at {0}:{1};{2}", e.Hour.ToString(), e.Minute, ToString(), e.Second.ToString());
            };
        }*/


        //Using Lambda Methods
        public void Subscribe(Clock theClock)
        {
            theClock.TimeChanged += 
            (sender, e) =>
            {
                Console.WriteLine("Logging event at {0}:{1};{2}", e.Hour.ToString(), e.Minute, ToString(), e.Second.ToString());
            };
        }
    }
    
}
