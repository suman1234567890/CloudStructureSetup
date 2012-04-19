using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestSocket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            DataReceive dr = new DataReceive(textBox1.Text);
            textBox2.Text=dr.getData()+"\n Data Received From this ip"+dr.ipaddress;
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            DataSend ds = new DataSend(textBox3.Text,textBox4.Text);
            ds.sendData(textBox5.Text);
            button2.Enabled = true;
        }
    }
}
