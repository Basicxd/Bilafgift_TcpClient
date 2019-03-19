using System;
using System.IO;
using System.Net.Sockets;

namespace Bilafgift_TcpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpClient connectionSocket = new TcpClient("localhost", 6789);

            Console.WriteLine("Klient Starter");

            Stream ns = connectionSocket.GetStream();
            StreamWriter sw = new StreamWriter(ns);
            StreamReader sr = new StreamReader(ns);
            sw.AutoFlush = true;

            while (true)
            {
                string message = Console.ReadLine();
                sw.WriteLine(message);

                string answer = sr.ReadLine();
                Console.WriteLine("Server: " + answer);
            }

            Console.ReadLine();
            ns.Close();
            connectionSocket.Close();
        }
    }
}
