using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace http
{
    class Program
    {
        static void Main(string[] args)
        {
            // Listening to client request
            Listener.SimpleListenerExample("http://localhost:8080/index/");
            Console.ReadLine();
        }

    }
}
