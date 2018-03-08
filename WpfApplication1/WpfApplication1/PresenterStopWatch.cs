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
            this.mainWindow.StartStopWatch += new EventHandler(mainWindow_CurrentStopWatch);
            this.mainWindow.ElapseStopWatch += new EventHandler(mainWindow_ElapseStopWatch);
            this.mainWindow.ResetStopWatch += new EventHandler(mainWindow_ResetStopWatch);
            this.mainWindow.CurrentStopWatch += new EventHandler(mainWindow_CurrentStopWatch);
        }

        private void mainWindow_CurrentStopWatch(object sender, EventArgs e)
        {
            this.mainWindow.labelstopwatch.Content = this.model.Elapsed();
        }

        private void mainWindow_ResetStopWatch(object sender, EventArgs e)
        {
            this.mainWindow.labelstopwatch.Content = this.model.Reset();
        }

        private void mainWindow_ElapseStopWatch(object sender, EventArgs e)
        {
            this.mainWindow.label1.Content = this.model.Elapsed();
        }

        void mainWindow_StartStopWatch(object sender, EventArgs e)
        {
            this.model.Start_Stop();

        }
    }
}
