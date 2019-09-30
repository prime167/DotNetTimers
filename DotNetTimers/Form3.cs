using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace DotNetTimers
{
    public partial class Form3 : Form
    {
        private int _count;
        private System.Threading.Timer _timer;
        private readonly Label _lblCount = new Label();
        private readonly SynchronizationContext _context;

        public Form3()
        {
            InitializeComponent();
            _lblCount.Text = "0000";
            _context = SynchronizationContext.Current ?? new SynchronizationContext();
            Size = new Size(450,450);
            Controls.Add(_lblCount);
            _lblCount.Location = new Point(200, 200);
        }

        private void UpdateCount(object state)
        {
            _count++;
            _context.Send(delegate { _lblCount.Text = _count.ToString("0000"); }, null);
            if (_count >= 30)
            {
                _timer.Change(Timeout.Infinite, Timeout.Infinite);
            }
        }

        private void Form3_Shown(object sender, EventArgs e)
        {
            _timer = new System.Threading.Timer(UpdateCount, null, 1000, 100);
        }
    }
}
