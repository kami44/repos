using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace EchoServer
{
    class Server
    {
        public void Start()
        {
            TcpListener echoListener = new TcpListener(IPAddress.Loopback, 7777);

            echoListener.Start();
            while (true)
            {
                TcpClient socket = echoListener.AcceptTcpClient();
                Task.Run(() =>
                {
                    TcpClient tempSocket = socket;
                    DoClient((tempSocket));
                });
             
            }



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
