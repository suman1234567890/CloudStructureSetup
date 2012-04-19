using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class Static_Lock
{
    // if lockcontion is true then it is locked
    public static bool lockConditionPortClerk = false;
    public static bool lockConditionPortManager = false;
    public static bool lockCondition1 = false;
    public static bool running = false;
}