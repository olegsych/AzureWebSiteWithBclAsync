using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class Net40Class
    {
        public static void DoAsyncStuff()
        {
            TaskEx.Run(() => Thread.Sleep(42));
        }
    }
}
