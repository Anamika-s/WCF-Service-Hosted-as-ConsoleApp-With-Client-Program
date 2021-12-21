using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WCFHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(WcfServiceLibrary1.Functions));
            host.Open();
            Console.WriteLine("Service Started");
            Console.Read();
            host.Close();
            Console.WriteLine("Service stopped");
            Console.Read();


        }
    }
}
