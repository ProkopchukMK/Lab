using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Diagnostics;

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new PresenterStopWatch(this);;
        }
        DispatcherTimer dt = new DispatcherTimer();
        Stopwatch sw = new Stopwatch();
        string currentTime = string.Empty;
        string elapsedTime = string.Empty;
        
        void dt_Tick(object sender, EventArgs e)
        {
            if (sw.IsRunning)
            {
                TimeSpan ts = sw.Elapsed;
                currentTime = String.Format("{0:00}:{1:00}:{2:00}",
                ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                label.Content = currentTime;
            }
        }
        public event EventHandler StartStopWatch = null;
        //START
        public void button_Click(object sender, RoutedEventArgs e)
        {
            sw.Start();
            dt.Start();
        }
        //RESULT
        public void button1_Click(object sender, RoutedEventArgs e)
        {
            if (!sw.IsRunning)
            {
                sw.Stop();
            }
            label1.Content = currentTime;
        }
        //RELOAD
        public void button2_Click(object sender, RoutedEventArgs e)
        {
            sw.Reset();
            label.Content = "00:00:00";
        }
    }
}
