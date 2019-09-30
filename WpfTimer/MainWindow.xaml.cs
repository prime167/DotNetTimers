using System;
using System.Threading;
using System.Windows;
using System.Windows.Threading;

namespace WpfTimer
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _count = 0;
        private readonly DispatcherTimer _timer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            _timer.Interval = TimeSpan.FromMilliseconds(100);
            _timer.Tick += _timer_Tick;
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            _count++;
            lblCount.Content = _count.ToString("0000");
            if (_count >= 30)
            {
                _timer.Stop();
            }
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            _timer.Start();
        }
    }
}
