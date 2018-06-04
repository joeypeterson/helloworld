using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace APIConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Source for web request: https://docs.microsoft.com/en-us/dotnet/framework/network-programming/how-to-request-data-using-the-webrequest-class 

            // Create a request for the URL.   
            WebRequest request = WebRequest.Create(
              "http://localhost:54103/api/values");
            
            // Get the response.  
            WebResponse response = request.GetResponse();
            // Get the stream containing content returned by the server.  
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.  
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.  
            string responseFromServer = reader.ReadToEnd();
            // Display the content.  
            Console.WriteLine(responseFromServer.Replace("[\"","").Replace("\"]",""));
            // Clean up the streams and the response.  
            reader.Close();
            response.Close();
            Console.WriteLine("Press key to close");
            Console.ReadLine();


        }
    }
}
