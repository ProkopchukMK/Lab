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
            this.mainWindow.ElapseStopWatch += new EventHandler(mainWindow_ElapseStopWatch);
            this.mainWindow.ResetStopWatch += new EventHandler(mainWindow_ResetStopWatch);
        }

        private void mainWindow_CurrentStopWatch()
        {
            for (int i = 0; i > 0; i++)
            {
                this.mainWindow.label.Content = this.model.CurentTime();
            }
        }

        private void mainWindow_ElapseStopWatch(object sender, EventArgs e)
        {
            this.mainWindow.label1.Content = this.model.CurentTime();
        }

        private void mainWindow_ResetStopWatch(object sender, EventArgs e)
        {
            this.model.Reset();
        }

        void mainWindow_StartStopWatch(object sender, EventArgs e)
        {
            this.model.Start();
            this.mainWindow.label.Content = this.model.CurentTime();
        }
    }
}
