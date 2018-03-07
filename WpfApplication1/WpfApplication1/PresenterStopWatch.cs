using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApplication1
{
    class PresenterStopWatch
    {
        ModelStopWatch model;
        MainWindow mainWindow;
        public PresenterStopWatch(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            this.model = new ModelStopWatch();
            this.mainWindow.StartStopWatch += new EventHandler(mainWindow_StartStopWatch);
        }
        void mainWindow_StartStopWatch(object sender, EventArgs e)
        {
            //this.mainWindow.label.Content = this.model.StopWatch("start");
        }
    }
}
