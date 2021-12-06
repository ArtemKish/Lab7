using System;
using System.Collections.Generic;
using System.Text;

namespace Kishmariya
{
    class KishmariyaLog:LogAbstract, LogInterface
    {
        private static KishmariyaLog instance;
        List<string> ListArr = new List<string>();
        public static KishmariyaLog I()
        {
            if (instance == null)
                instance = new KishmariyaLog();
            return instance;
        }
        public LogInterface Log(string str)
        {
            ListArr.Add(str);
            return this;
        }
        public LogInterface Write()
        {
            writeConsole(ListArr.ToArray());
            return this;
        }
    }
}
