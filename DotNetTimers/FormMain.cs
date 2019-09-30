﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetTimers
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form1 = new Form1();
            form1.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form3 = new Form3();
            form3.ShowDialog(this);
        }
    }
}
