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
        
        public event EventHandler StartStopWatch = null;
        public event EventHandler ElapseStopWatch = null;
        public event EventHandler ResetStopWatch = null;
        //START
        public void start_Click(object sender, RoutedEventArgs e)
        {
            StartStopWatch.Invoke(sender,e);
        }
        //RESULT
        public void elapse_Click(object sender, RoutedEventArgs e)
        {
            ElapseStopWatch.Invoke(sender, e);
        }
        //RELOAD
        public void reset_Click(object sender, RoutedEventArgs e)
        {
            ResetStopWatch.Invoke(sender, e);
        }
    }
}
