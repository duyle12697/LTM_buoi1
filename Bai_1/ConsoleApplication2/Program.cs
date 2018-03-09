using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string strHostName = Dns.GetHostName();
            Console.WriteLine("Host Name" + strHostName);
            IPHostEntry iphostentry = Dns.GetHostByName(strHostName);
            int nIP = 0;
            foreach (IPAddress ipaddress in iphostentry.AddressList)
            {
                Console.WriteLine("IP #" + ++nIP + ": " +ipaddress.ToString());
            
            Console.ReadLine();
            }
        }
    }
}
