﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Device_test
{
    public partial class version : Form
    {
        public version()
        {
            InitializeComponent();
        }

        public bool isClick_ver = false;
        private void button2_Click(object sender, EventArgs e)
        {
            isClick_ver = false;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isClick_ver = true;
            this.Close();
        }

        private void version_Load(object sender, EventArgs e)
        {
            Thread.Sleep(100);
            PT601_TEST.pCurrentWin.serialPort1.Write("$SYS:VER\r\n");
        }
    }
}
