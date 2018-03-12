using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace WpfApplication1
{
    class PresenterStopWatch
    {
        ModelStopWatch model;
        MainWindow mainWindow;
        int i = 0;
        public PresenterStopWatch(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            this.model = new ModelStopWatch();

            DispatcherTimer timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromMilliseconds(0.5)
            };
            timer.Tick += (o, e) =>
            {
                DateTime dtCurrentTime = DateTime.Now;
                this.mainWindow.labelstopwatch.Content = this.model.Elapsed();
            };
            timer.IsEnabled = true;

            this.mainWindow.StartStopWatch += new EventHandler(MainWindow_StartStopWatch);
            this.mainWindow.ElapseStopWatch += new EventHandler(MainWindow_ElapseStopWatch);
            this.mainWindow.ResetStopWatch += new EventHandler(MainWindow_ResetStopWatch);
        }

        private void MainWindow_CurrentStopWatch(object sender, DependencyPropertyChangedEventArgs e)
        {
            this.mainWindow.labelstopwatch.Content = this.model.Elapsed();
        }

        private void MainWindow_ResetStopWatch(object sender, EventArgs e)
        {
            this.mainWindow.labelstopwatch.Content = this.model.Reset();
            this.mainWindow.label1.Content = this.model.Elapsed();
            this.mainWindow.label2.Content = this.model.Elapsed();
            this.mainWindow.label3.Content = this.model.Elapsed();
            this.mainWindow.label4.Content = this.model.Elapsed();
            this.mainWindow.label5.Content = this.model.Elapsed();
            this.mainWindow.label6.Content = this.model.Elapsed();
            this.mainWindow.label7.Content = this.model.Elapsed();
            this.mainWindow.label8.Content = this.model.Elapsed();
            this.mainWindow.label9.Content = this.model.Elapsed();
            this.mainWindow.label10.Content = this.model.Elapsed();
            this.mainWindow.label11.Content = this.model.Elapsed();
            this.mainWindow.label12.Content = this.model.Elapsed();
            this.mainWindow.label13.Content = this.model.Elapsed();
            this.mainWindow.label14.Content = this.model.Elapsed();
            this.mainWindow.label15.Content = this.model.Elapsed();
            i = 0;
        }

        private void MainWindow_ElapseStopWatch(object sender, EventArgs e)
        {

            if (i > 14)
            {
                i = 1;
            }
            else {  i++;}
           
            switch (i)
            {
                case 1:
                    this.mainWindow.label1.Content = this.model.Elapsed();
                    break;
                case 2:
                    this.mainWindow.label2.Content = this.model.Elapsed();
                    break;
                case 3:
                    this.mainWindow.label3.Content = this.model.Elapsed();
                    break;
                case 4:
                    this.mainWindow.label4.Content = this.model.Elapsed();
                    break;
                case 5:
                    this.mainWindow.label5.Content = this.model.Elapsed();
                    break;
                case 6:
                    this.mainWindow.label6.Content = this.model.Elapsed();
                    break;
                case 7:
                    this.mainWindow.label7.Content = this.model.Elapsed();
                    break;
                case 8:
                    this.mainWindow.label8.Content = this.model.Elapsed();
                    break;
                case 9:
                    this.mainWindow.label9.Content = this.model.Elapsed();
                    break;
                case 10:
                    this.mainWindow.label10.Content = this.model.Elapsed();
                    break;
                case 11:
                    this.mainWindow.label11.Content = this.model.Elapsed();
                    break;
                case 12:
                    this.mainWindow.label12.Content = this.model.Elapsed();
                    break;
                case 13:
                    this.mainWindow.label13.Content = this.model.Elapsed();
                    break;
                case 14:
                    this.mainWindow.label14.Content = this.model.Elapsed();
                    break;
                case 15:
                    this.mainWindow.label15.Content = this.model.Elapsed();
                    break;
            }
        }

        void MainWindow_StartStopWatch(object sender, EventArgs e)
        {
            this.model.Start_Stop();
        }

        //
    }
}
