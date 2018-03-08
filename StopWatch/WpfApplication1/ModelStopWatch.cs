using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace WpfApplication1
{
    class ModelStopWatch
    {
        DispatcherTimer dt = new DispatcherTimer();
        Stopwatch sw = new Stopwatch();
        string currentTime = "00:00:00:000";
        string elapsedTime = string.Empty;
        
        public ModelStopWatch()
        {
            dt.IsEnabled = false;
            dt.Tick += new EventHandler(dt_Tick);
            dt.Interval = new TimeSpan(0, 0, 0, 0, 1);
        }

        public void dt_Tick(object sender, EventArgs e)
        {
            if (sw.IsRunning)
            {
                TimeSpan ts = sw.Elapsed;
                currentTime = String.Format("{0:00}:{1:00}:{2:00}:{3:000}", ts.Hours,
                ts.Minutes, ts.Seconds, ts.Milliseconds);
                Elapsed();
            }
        }
        //start stop
        public void Start_Stop()
        {            
                dt.Start();
                sw.Start();            
        }
        //reset
        public string Reset()
        {
            sw.Reset();
            currentTime = "00:00:00:000";
            return currentTime;
        }
        //elapsed
        public string Elapsed()
        {
            return currentTime;
        }
    }
}
