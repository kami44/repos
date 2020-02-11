using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace EchoServer
{
    class Server
    {
        public TcpClient Start()
        {
            TcpListener echoListener = new TcpListener(IPAddress.Loopback, 7777);

            echoListener.Start();

            TcpClient Socket = echoListener.AcceptTcpClient();

            return Socket;
        }

        public void DoClient(TcpClient socket)
        {
            using (socket)
            {

                NetworkStream ns = socket.GetStream();
                StreamReader sr = new StreamReader(ns);
                StreamWriter sw = new StreamWriter(ns);
                sw.AutoFlush = true;

                string line = sr.ReadLine();
                sw.WriteLine(line);
            }
        }
    }
}
