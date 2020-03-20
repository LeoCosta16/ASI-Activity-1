using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace TodoApi
{
    public class WebPageDownload
    {
       static void Download ()
        {
            var client = new WebClient();
            var text = client.DownloadString("https://www.wunderground.com/weather/pt/bragan%C3%A7a/41.80,-6.75");
            Console.WriteLine(text);
        }

    }
}
