using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace clerk
{
    public partial class ClerkGUI : Form
    {
        public ClerkGUI()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            
            Thread t = new Thread(new ThreadStart(temp));
            t.IsBackground = true;
            t.Start();


        }
        void temp()
        {
            Communication c = new Communication();
            Thread threadStart = new Thread(new ThreadStart(c.startTread(this)));
        }
        public void AddToTextBox(String oo)
        {
            Invoke(new MethodInvoker(
                           delegate { textBox2.Text += oo; }
                           ));
        }
        public string getIp()
        {
            return textBox1.Text;
        }


        private void ClerkGUI_Load(object sender, EventArgs e)
        {
            textBox1.Text = "127.0.0.1";
            
        }
    }
}
