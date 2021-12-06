using System;
using System.Collections.Generic;
using System.Text;

namespace Kishmariya
{
    class KishmariyaException : Exception
    {
        public KishmariyaException(string message) : base(message) { }
    }
}