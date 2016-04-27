using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient web = new WebClient();
            web.Encoding = Encoding.UTF8;
            var result = web.DownloadString("http://adwebapi.e24health.com/api/ads/13");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
