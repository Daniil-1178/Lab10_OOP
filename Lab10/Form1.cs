using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace Lab10
{
    public partial class Form1 : Form
    {
        private Thread thread1;
        private Thread thread2;
        private Thread thread3;

        private bool isRunning1 = false;
        private bool isRunning2 = false;
        private bool isRunning3 = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void SimulateRC2()
        {
            Random rnd = new Random();
            while (isRunning1)
            {
                byte[] block = new byte[8];
                rnd.NextBytes(block);
                string hexData = BitConverter.ToString(block).Replace("-", "");

                this.Invoke(new MethodInvoker(() =>
                {
                    txtOutput1.AppendText($"[RC2 Block]: {hexData}\r\n");
                }));

                Thread.Sleep(600);
            }
        }

        private void SimulateMDC2()
        {
            Random rnd = new Random();
            while (isRunning2)
            {
                byte[] hash = new byte[16];
                rnd.NextBytes(hash);
                string hexHash = BitConverter.ToString(hash).Replace("-", "");

                this.Invoke(new MethodInvoker(() =>
                {
                    txtOutput2.AppendText($"[MDC-2 Hash]: {hexHash}\r\n");
                }));

                Thread.Sleep(800);
            }
        }

        private void SimulateESIGN()
        {
            Random rnd = new Random();
            while (isRunning3)
            {
                int k = rnd.Next(100000, 999999);
                string signature = Convert.ToBase64String(Encoding.UTF8.GetBytes(k.ToString()));

                this.Invoke(new MethodInvoker(() =>
                {
                    txtOutput3.AppendText($"[ESIGN Sign]: {signature.Substring(0, 8)}...\r\n");
                }));

                Thread.Sleep(700);
            }
        }

        private void btnStart1_Click(object sender, EventArgs e)
        {
            if (isRunning1) return;
            isRunning1 = true;
            thread1 = new Thread(new ThreadStart(SimulateRC2));
            thread1.Start();
        }

        private void btnStop1_Click(object sender, EventArgs e)
        {
            isRunning1 = false;
        }

        private void btnStart2_Click(object sender, EventArgs e)
        {
            if (isRunning2) return;
            isRunning2 = true;
            thread2 = new Thread(new ThreadStart(SimulateMDC2));
            thread2.Start();
        }

        private void btnStop2_Click(object sender, EventArgs e)
        {
            isRunning2 = false;
        }

        private void btnStart3_Click(object sender, EventArgs e)
        {
            if (isRunning3) return;
            isRunning3 = true;
            thread3 = new Thread(new ThreadStart(SimulateESIGN));
            thread3.Start();
        }

        private void btnStop3_Click(object sender, EventArgs e)
        {
            isRunning3 = false;
        }

        private void btnStartAll_Click(object sender, EventArgs e)
        {
            btnStart1_Click(sender, e);
            btnStart2_Click(sender, e);
            btnStart3_Click(sender, e);
        }

        private void btnStopAll_Click(object sender, EventArgs e)
        {
            isRunning1 = false;
            isRunning2 = false;
            isRunning3 = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            isRunning1 = false;
            isRunning2 = false;
            isRunning3 = false;
        }
    }
}