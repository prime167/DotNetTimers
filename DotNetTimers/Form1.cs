using System;
using System.Drawing;
using System.Windows.Forms;

namespace DotNetTimers
{
    public partial class Form1 : Form
    {
        private int _count;
        private readonly Timer _timer = new Timer();
        private readonly Label _lblCount = new Label();
        public Form1()
        {
            InitializeComponent();
            Size = new Size(450,450);
            Controls.Add(_lblCount);
            _lblCount.Location = new Point(200, 200);
            _timer.Interval = 100;
            _timer.Tick += timer1_Tick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _timer.Enabled = true;

            // 或者
            //_timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _count++;
            _lblCount.Text = _count.ToString("0000");
            if (_count >= 30)
            {
                _timer.Enabled = false;

                // 或者
                //_timer.Stop();
            }
        }
    }
}
