using System;
using System.Threading;
using System.Net.Sockets;
using System.Text;
using System.Net;
using System.Collections.Generic;

namespace MultiThreadedServer
{
    class Program
    {

        static void Main(string[] args)
        {
            List<TcpClient> clientList = new List<TcpClient>();
            TcpListener serverSocket = new TcpListener(8888);
            TcpClient clientSocket = default(TcpClient);
            int counter = 0;

            serverSocket.Start();
            Console.WriteLine(" >> " + "Server Started");

            counter = 0;
            while (true)
            {
                try
                {
                    counter += 1;
                    clientSocket = serverSocket.AcceptTcpClient();
                    Console.WriteLine(" >> " + "Client No: " + Convert.ToString(counter) + " started!");
                    HandleClient client = new HandleClient();
                    clientList.Add(clientSocket);
                    client.startClient(clientSocket, Convert.ToString(counter), clientList);
                }
                catch (Exception)
                {
                    clientSocket.Close();
                    serverSocket.Stop();
                    Console.WriteLine(" >> " + "exit");
                    Console.ReadLine();
                }
            }

        }
    }

    
    public class HandleClient
    {
        List<TcpClient> clients;
        TcpClient clientSocket;
        string clNo;
        public void startClient(TcpClient inClientSocket, string clientNo, List<TcpClient> clientList)
        {
            clients = clientList;
            this.clientSocket = inClientSocket;
            this.clNo = clientNo;
            Thread ctThread = new Thread(doChat);
            ctThread.Start();
        }
        private void doChat()
        {
            int requestCount = 0;
            clientSocket.ReceiveBufferSize = 4095;
            byte[] bytesFrom = new byte[4096];
            string dataFromClient = null;
            byte[] sendBytes = null;
            string serverResponse = null;
            string rCount = null;
            requestCount = 0;

            while ((true))
            {
                try
                {

                    requestCount = requestCount + 1;
                    NetworkStream networkStream = clientSocket.GetStream();
                    networkStream.Read(bytesFrom, 0, clientSocket.ReceiveBufferSize);
                    dataFromClient = Encoding.ASCII.GetString(bytesFrom);
                    dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));
                    Console.WriteLine("Message from client - " + clNo + ": " + dataFromClient);
                        

                    rCount = Convert.ToString(requestCount);
                    sendBytes = Encoding.ASCII.GetBytes(dataFromClient);
                    NetworkStream netStream;
                    for (int i = 0; i < clients.Count; i++)
                    {
                        netStream = clients[i].GetStream();
                        if (netStream != networkStream)
                        {
                            netStream.Write(sendBytes, 0, sendBytes.Length);
                            netStream.Flush();
                            Console.WriteLine(serverResponse);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(" >> " + ex.ToString());
                }
            }
        }
    }
}
