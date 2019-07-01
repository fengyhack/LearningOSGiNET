using System;
using UIShell.OSGi;

namespace OSGi.HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            using(BundleRuntime bdrt=new BundleRuntime())
            {
                Console.WriteLine("Start bundle...");
                bdrt.Start();
                bdrt.Stop();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
