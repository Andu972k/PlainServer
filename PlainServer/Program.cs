﻿using System;

namespace PlainServer
{
    class Program
    {
        static void Main(string[] args)
        {

            Server server = new Server();
            server.Start();

            Console.WriteLine("Hello World!");
        }
    }
}
