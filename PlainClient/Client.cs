using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;
using ModelLib.Model;

namespace PlainClient
{
    class Client
    {


















        #region Methods

        public void Start()
        {
            Car tempCar = new Car("Tesla", "red", "EL23400");
            

            using (TcpClient socket = new TcpClient("localhost", 10001))
            using (Stream ns = socket.GetStream())
            using (StreamReader sr = new StreamReader(ns))
            using (StreamWriter sw = new StreamWriter(ns))
            {
                
                sw.WriteLine(tempCar);
                sw.Flush();

                string readString = sr.ReadLine();
                Console.WriteLine(readString);

            }
            


        }


        #endregion








    }
}
