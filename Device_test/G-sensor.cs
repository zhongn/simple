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
    public partial class G_sensor : Form
    {
        public G_sensor()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        public bool isClick_g = false;
        private void button2_Click(object sender, EventArgs e)
        {
            isClick_g = false;
            PT601_TEST.pCurrentWin.serialPort1.Write("$LIS:STOP\r\n");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isClick_g = true;
            PT601_TEST.pCurrentWin.serialPort1.Write("$LIS:STOP\r\n");
            this.Close();
        }

        private void G_sensor_Load(object sender, EventArgs e)
        {
            Thread.Sleep(100);
            PT601_TEST.pCurrentWin.serialPort1.Write("$LIS:START\r\n");
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
