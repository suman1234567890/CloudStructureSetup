﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ManagerRequestSend
{
    internal System.Threading.ThreadStart startTread(crawler.Employee.EmployeeGUI employeeGUI)


    //internal System.Threading.WaitCallback startTread(ListBox ls)
    {
        while (true)
        {
            Console.WriteLine("strt");
            DataReceiveManager dr = new DataReceiveManager("5212");
            String ipaddress = dr.ipaddress;
            StackIpaddress.ManagerIpAddress.Enqueue(dr.getData());
            Console.WriteLine(ipaddress);
            employeeGUI.AddToListBoxManager(dr.getData());
            employeeGUI.AddToStatus("Data Received : '"+dr.getData()+"' from "+ipaddress);
        }
        throw new NotImplementedException();
    }
}