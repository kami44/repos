using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace EchoServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! SERVER");
            
            Server s1 = new Server();
            TcpClient socket = s1.Start();
            s1.DoClient(socket);
            Console.ReadLine();

        }
    }
}
