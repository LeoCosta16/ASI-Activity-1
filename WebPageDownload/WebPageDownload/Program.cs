using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace WebPageDownload
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new WebClient();

            var text = client.DownloadString("https://www.renatomacedo.com");

            Console.WriteLine(text);
        }
    }
}
