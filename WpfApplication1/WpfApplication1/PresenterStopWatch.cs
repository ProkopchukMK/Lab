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
            this.mainWindow.StartStopWatch += new EventHandler(MainWindow_StartStopWatch);
            this.mainWindow.StartStopWatch += new EventHandler(MainWindow_CurrentStopWatch);
            this.mainWindow.ElapseStopWatch += new EventHandler(MainWindow_ElapseStopWatch);
            this.mainWindow.ResetStopWatch += new EventHandler(MainWindow_ResetStopWatch);
            this.mainWindow.CurrentStopWatch += new EventHandler(MainWindow_CurrentStopWatch);
        }

        private void MainWindow_CurrentStopWatch(object sender, EventArgs e)
        {
            this.mainWindow.labelstopwatch.Content = this.model.Elapsed();
        }

        private void MainWindow_ResetStopWatch(object sender, EventArgs e)
        {
            this.mainWindow.labelstopwatch.Content = this.model.Reset();
        }

        private void MainWindow_ElapseStopWatch(object sender, EventArgs e)
        {
            this.mainWindow.label1.Content = this.model.Elapsed();
        }

        void MainWindow_StartStopWatch(object sender, EventArgs e)
        {
            this.model.Start_Stop();

        }
    }
}
