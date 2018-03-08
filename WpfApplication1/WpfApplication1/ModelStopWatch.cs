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
        string currentTime = string.Empty;
        string elapsedTime = string.Empty;

        public ModelStopWatch()
        {
            dt.IsEnabled = false;
            dt.Tick += new EventHandler(dt_Tick);
            dt.Interval = new TimeSpan(0, 0, 0, 0, 1);
        }

        private void dt_Tick(object sender, EventArgs e)
        {
            if (sw.IsRunning)
            {
                TimeSpan ts = sw.Elapsed;
                currentTime = String.Format("{0:00}:{1:00}:{2:00}:{3:000}", ts.Hours,
                ts.Minutes, ts.Seconds, ts.Milliseconds / 1);
            }
        }
        //start stop
        public void Start_Stop()
        {
            if (!sw.IsRunning)
            {
                dt.Start();
                sw.Start();
            }
            else
            {
                dt.Stop();
                sw.Stop();
            }
        }
        //reset
        public string Reset()
        {
            sw.Stop();
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
