using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface LogInterface
    {
        LogInterface Log(string str);
        LogInterface Write();
    }
}
