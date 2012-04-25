using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

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
        MySqlDataReader rdr=db.SelectDataFromDatabase("select value1,value2,operation from crawler where id="+data);
        if (rdr.HasRows)
        {
            if (rdr.Read())
            {
                if (rdr.GetInt32(2) == 1)
                {
                    n.AddToTextBox("Data Retrived : " + rdr.GetInt32(0) + rdr.GetInt32(1));
                    int res = rdr.GetInt32(0) + rdr.GetInt32(1);
                    db.UpdateIntoDatabase("update crawler set result=" + res + " where id=" + data);
                }
                if (rdr.GetInt32(2) == 2)
                {
                    n.AddToTextBox("Data Retrived : " + rdr.GetInt32(0) + rdr.GetInt32(1));
                    int res = rdr.GetInt32(0) - rdr.GetInt32(1);
                    db.UpdateIntoDatabase("update crawler set result=" + res + " where id=" + data);
                }
                if (rdr.GetInt32(2) == 3)
                {
                    n.AddToTextBox("Data Retrived : " + rdr.GetInt32(0) + rdr.GetInt32(1));
                    int res = rdr.GetInt32(0) * rdr.GetInt32(1);
                    db.UpdateIntoDatabase("update crawler set result=" + res + " where id=" + data);
                }
                if (rdr.GetInt32(2) == 4)
                {
                    n.AddToTextBox("Data Retrived : " + rdr.GetInt32(0) + rdr.GetInt32(1));
                    int res = rdr.GetInt32(0) / rdr.GetInt32(1);
                    db.UpdateIntoDatabase("update crawler set result=" + res + " where id=" + data);
                }

            }
        }
        
    }

}

