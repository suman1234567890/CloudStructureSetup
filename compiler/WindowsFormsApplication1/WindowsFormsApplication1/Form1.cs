using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
public partial class Form1 : Form
{
    String fileLoc = @"sample1.c";
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        //create the file if the file is not exist.

        dojob();

    }
    void dojob()
    {
        if (!File.Exists(fileLoc))
        {
            FileStream fs = null;
            using (fs = File.Create(fileLoc))
            {

            }
        }
        // Write the content of the file from the text box.
        if (File.Exists(fileLoc))
        {

            using (StreamWriter sw = new StreamWriter(fileLoc))
            {
                sw.Write(textBox1.Text);
            }

        }
        
        
        Process compiler = new Process();
        compiler.StartInfo.FileName = @"D:\tcc\tcc\tcc.exe";
        //ClamScan.StartInfo.Arguments = "--no-summary --move=" + (char)(34) + virtualPath + "quarantene" + (char)(34) + " " + (char)(34) + FileScan + (char)(34);
        compiler.StartInfo.Arguments = fileLoc;
        compiler.StartInfo.CreateNoWindow = true;
        compiler.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
        compiler.StartInfo.RedirectStandardOutput = true;
        compiler.StartInfo.RedirectStandardError = true;
        compiler.StartInfo.UseShellExecute = false;
        compiler.EnableRaisingEvents = true;
        compiler.Start();
        compiler.WaitForExit();
        String soutput= compiler.StandardError.ReadToEnd();
        
        if (soutput == "")
        {
            Process runobj = new Process();
            runobj.StartInfo.FileName = @"sample1.exe";
            runobj.StartInfo.Arguments = fileLoc;
            runobj.StartInfo.CreateNoWindow = true;
            runobj.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            runobj.StartInfo.RedirectStandardOutput = true;
            runobj.StartInfo.RedirectStandardError = true;
            runobj.StartInfo.UseShellExecute = false;
            runobj.EnableRaisingEvents = true;
            runobj.Start();
            runobj.WaitForExit();
            soutput = runobj.StandardError.ReadToEnd();
            soutput += runobj.StandardOutput.ReadToEnd();
        }
        textBox2.Text = soutput;
        
    }
}
}
