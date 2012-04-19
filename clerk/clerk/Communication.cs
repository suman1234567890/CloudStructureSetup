using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Communication
{
    internal System.Threading.ThreadStart startTread(clerk.ClerkGUI c)
    //internal System.Threading.WaitCallback startTread(ListBox ls)
    {
        while (true)
        {
            //Requesting for Sending Data //
            c.AddToTextBox("Data Send to : "+c.getIp());
            DataSend ds = new DataSend(c.getIp(), "5210");
            ds.sendData("Free");
            //Requesting For 
            c.AddToTextBox("Data Successfully Sent to : " + c.getIp());
            DataReceive dr = new DataReceive("5211");
            computeIt(dr.getData());


        }
        throw new NotImplementedException();
    }
    void computeIt(String data)
    {
        
    }

}

