using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using ModelLib.Model;

namespace PlainServer
{
    class Server
    {











        #region Methods

        public void Start()
        {
            TcpListener server = new TcpListener(IPAddress.Loopback, 10001);
            server.Start();

            while (true)
            {

                TcpClient socket = server.AcceptTcpClient();

                Task.Run(() =>
                {
                    TcpClient tempSocket = socket;
                    DoClient(tempSocket);
                }
                    );

            }


        }

        private void DoClient(TcpClient socket)
        {
            using (StreamReader sr = new StreamReader(socket.GetStream()))
            using (StreamWriter sw = new StreamWriter(socket.GetStream()))
            {

                string carString = sr.ReadLine();

                Car newCar = new Car();

                List<string> tempList = new List<string>(); 

                if (carString != null)
                {

                    foreach (string s in carString.Split(' '))
                    {

                        if (s.EndsWith(',') || !s.EndsWith(':'))
                        {
                            tempList.Add(s);
                        }

                    }

                    newCar.Model = tempList[0].Remove(tempList[0].Length-1);
                    newCar.Colour = tempList[1].Remove(tempList[1].Length - 1);
                    newCar.RegistrationNumber = tempList[2];

                }

                sw.WriteLine(newCar);
                sw.Flush();
            }
            
            socket?.Close();

        }

        #endregion

    }
}
