using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.IO;
using System.Diagnostics;

class Communication
{
    private clerk.ClerkGUI n = null;
    internal System.Threading.ThreadStart startTread(clerk.ClerkGUI c)
    //internal System.Threading.WaitCallback startTread(ListBox ls)
    {
        while (true)
        {
            n = c;
            //Requesting for Sending Data //
            c.AddToTextBox("Data Send to : "+c.getIp());
            DataSend ds = new DataSend(c.getIp(), "5210");
            ds.sendData("Free");
            //Requesting For 
            c.AddToTextBox("\nData Successfully Sent to : " + c.getIp());
            DataReceive dr = new DataReceive("5211");
            c.AddToTextBox("\nData Received"+dr.getData()+"from ip-address"+dr.ipaddress);
            computeIt(dr.getData());


        }
        throw new NotImplementedException();
    }
    void computeIt(String data)
    {
        Database db = new Database();
        MySqlDataReader rdr=db.SelectDataFromDatabase("select prog,operation from crawler where id="+data);
        if (rdr.HasRows)
        {
            if (rdr.Read())
            {
                if (rdr.GetInt32(1) == 1)
                {
                    n.AddToTextBox("Data Retrived : " + rdr.GetString(0) + rdr.GetInt32(1));
                    //int res = rdr.GetInt32(0) + rdr.GetInt32(1);
                    String res=dojob(rdr.GetString(0));
                    db.UpdateIntoDatabase("update crawler set result='" + res + "' where id=" + data);
                }
                if (rdr.GetInt32(1) == 2)
                {
                    n.AddToTextBox("Data Retrived : " + rdr.GetInt32(0) + rdr.GetInt32(1));
                    //int res = rdr.GetInt32(0) - rdr.GetInt32(1);
                    String res = dojob(rdr.GetString(0));
                    db.UpdateIntoDatabase("update crawler set result=" + res + " where id=" + data);
                }
                if (rdr.GetInt32(1) == 3)
                {
                    n.AddToTextBox("Data Retrived : " + rdr.GetInt32(0) + rdr.GetInt32(1));
                    //int res = rdr.GetInt32(0) * rdr.GetInt32(1);
                    String res = dojob(rdr.GetString(0));
                    db.UpdateIntoDatabase("update crawler set result=" + res + " where id=" + data);
                }
                if (rdr.GetInt32(1) == 4)
                {
                    n.AddToTextBox("Data Retrived : " + rdr.GetInt32(0) + rdr.GetInt32(1));
                    //int res = rdr.GetInt32(0) / rdr.GetInt32(1);
                    String res = dojob(rdr.GetString(0));
                    db.UpdateIntoDatabase("update crawler set result=" + res + " where id=" + data);
                }

            }
        }
        
    }
    String dojob(String prog)
    {
        String fileLoc = @"sample1.c";
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
                sw.Write(prog);
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
        String soutput = compiler.StandardError.ReadToEnd();

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
         return soutput;

    }

}

