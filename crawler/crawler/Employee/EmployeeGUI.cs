﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace crawler.Employee
{
    public partial class EmployeeGUI : Form
    {
        ListBox l = null;
        public EmployeeGUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            
            
            
            l = listBox2;
            Thread t1 = new Thread(new ThreadStart(temp1));
            Thread t2 = new Thread(new ThreadStart(temp2));
            t1.IsBackground = true;
            t1.Start();
            t2.IsBackground = true;
            t2.Start();


        }
        void temp1()
        {
            ClerkRequestSend c = new ClerkRequestSend();
            
            Console.Write("Thread 1 started");
            new Thread(new ThreadStart(c.startTread(this)));
            
        }
        void temp2()
        {
            
            ManagerRequestSend m = new ManagerRequestSend();
            
            Console.Write("Thread 2started");
            new Thread(new ThreadStart(m.startTread(this)));
        }
        public void AddToListBoxClerk(String oo)
        {
            Invoke(new MethodInvoker(
                           delegate { listBox2.Items.Add(oo); }
                           ));
        }
        public void AddToListBoxManager(String oo)
        {
            Invoke(new MethodInvoker(
                           delegate { listBox1.Items.Add(oo); }
                           ));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
