using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace http
{
    class Listener
    {
        // Listening to client request
        public static void SimpleListenerExample(string prefixe)
        {
            HttpListener listener = null;
            HttpListenerContext context = null;
            HttpListenerRequest request = null;
            HttpListenerResponse response = null;
            string responseString = "";
            byte[] buffer;
            try
            {
                listener = new HttpListener();
                listener.Prefixes.Add(prefixe);
                listener.Start();
                while (true)
                {
                    Console.WriteLine("Listening...");
                    context = listener.GetContext();
                    request = context.Request;
                    // Obtain a response object.
                    response = context.Response;
                    // Construct a response.
                    responseString = "<HTML><BODY> Hello world!</BODY></HTML>";
                    buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
                    // Get a response stream and write the response to it.
                    response.ContentLength64 = buffer.Length;
                    System.IO.Stream output = response.OutputStream;
                    output.Write(buffer, 0, buffer.Length);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            // You must close the output stream.
            listener.Stop();
            Console.ReadLine();
        }

    }
}
