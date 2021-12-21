using System;

namespace ClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.FunctionsClient client = new ServiceReference1.FunctionsClient();
            string res=  client.Combine("Ajay", "Sood");
            Console.WriteLine(res);
            Console.Read();
        }
    }
}
