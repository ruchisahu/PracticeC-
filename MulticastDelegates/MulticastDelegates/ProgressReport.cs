using System;
using System.Collections.Generic;
using System.Text;

namespace MulticastDelegates
{
    public delegate void ProgressReporter(int x);
    class ProgressReport
    {
        public static void Hardwork(ProgressReporter p)
        {
            for (int i  =0 ;i< 10; i++)
            {
                p(i * 10);
                System.Threading.Thread.Sleep(100);
            }
        }
    }
}
