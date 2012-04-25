using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Allocate
{
    public Allocate()
    {

    }
    internal System.Threading.ThreadStart startTread(crawler.Employee.EmployeeGUI employeeGUI)


    //internal System.Threading.WaitCallback startTread(ListBox ls)
    {
        while (true)
        {
            while (StackIpaddress.ManagerIpAddress.Count == 0) ;
            while (StackIpaddress.ClerkIpAddress.Count == 0) ;
            String managerip = StackIpaddress.ManagerIpAddress.Dequeue();
            String Clerkip = StackIpaddress.ClerkIpAddress.Dequeue();
            DataSend ds = new DataSend(Clerkip, "5211");
            ds.sendData(managerip);
            employeeGUI.RemoveToListBoxClerk(Clerkip);
            employeeGUI.RemoveToListBoxManager(managerip);
            employeeGUI.AddToStatus(" JOB ALLOCATED TO :"+Clerkip+" ( "+managerip+")") ;

            
        }
        throw new NotImplementedException();
    }
}

