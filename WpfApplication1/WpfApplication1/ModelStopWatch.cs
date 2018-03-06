using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class ModelStopWatch
    {
        public DateTime date = new DateTime(0, 0);
        public DateTime StopWatch()
        {
           date = date.AddMilliseconds(1);
           return date;
        }
    }
}
