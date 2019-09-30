using System;
using System.Drawing;
using System.Windows.Forms;

namespace DotNetTimers
{
    public partial class Form2 : Form
    {
        private int _count;
        private readonly System.Timers.Timer _timer = new System.Timers.Timer();
        private readonly Label _lblCount = new Label();

        public Form2()
        {
            InitializeComponent();
            Size = new Size(450,450);
            Controls.Add(_lblCount);
            _lblCount.Location = new Point(200, 200);
            _timer.Interval = 100;
            _timer.SynchronizingObject = this;
            _timer.Elapsed += _timer_Elapsed;
        }

        private void _timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            _count++;
            _lblCount.Text = _count.ToString("0000");
            if (_count >= 30)
            {
                _timer.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _timer.Start();
        }
    }
}
