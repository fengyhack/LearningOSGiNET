using System;
using UIShell.OSGi;

namespace PrintMessagePlugin
{
    public class PrintMessage:IBundleActivator
    {
        public void Start(IBundleContext context)
        {
            Console.WriteLine("<Start> Hello World  -- PrintMessage");
        }

        public void Stop(IBundleContext context)
        {
            Console.WriteLine("<Stop> See you next time. -- PrintMessage");
        }

    }
}
