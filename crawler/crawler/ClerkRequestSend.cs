using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

class ClerkRequestSend
{



    internal System.Threading.ThreadStart startTread(crawler.Employee.EmployeeGUI employeeGUI)
    

    //internal System.Threading.WaitCallback startTread(ListBox ls)
    {
        while (true)
        {
            Console.WriteLine("strt");
            DataReceive dr = new DataReceive("5210");
            String ipaddress = dr.ipaddress;
            StackIpaddress.ClerkIpAddress.Enqueue(ipaddress);
            Console.WriteLine(ipaddress);
            employeeGUI.AddToListBoxClerk(ipaddress);
        }
        throw new NotImplementedException();
    }

    
}

