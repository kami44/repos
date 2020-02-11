using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace ConsoleAppServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IPAddress ip = IPAddress.Parse("192.168.24.115");
            Console.WriteLine("MGV2-DMU2 IP:" + ip + "Password lanmagle");
            TcpListener serverSocket = new TcpListener(ip,7777);

            serverSocket.Start();

            Console.WriteLine("server started waiting for connection!");

            TcpClient connectionSocket = serverSocket.AcceptTcpClient();
            Console.WriteLine("Server activated");

            Stream ns = connectionSocket.GetStream();

            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            sw.AutoFlush = true;

            string message = sr.ReadLine();
            string answer = "";

            while (message != null && message != "")
            {
                Console.WriteLine("Client:" + message);
                answer = message.ToUpper();
                sw.WriteLine(answer);
                message = sr.ReadLine();
            }

            ns.Close();
            connectionSocket.Close();
            serverSocket.Stop();
        }
    }
}
