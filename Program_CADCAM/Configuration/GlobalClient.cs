using System;
using System.Net.Sockets;
using System.IO;
using System.Collections.Concurrent;

namespace Program_CADCAM.Configuration
{
    public static class GlobalClient
    {
        public static TcpClient Client { get; set; }
        public static StreamWriter Writer { get; set; }
        public static StreamReader Reader { get; set; }
        public static string UserId { get; set; }
        public static string UserName { get; set; }

        public static ConcurrentQueue<string> IncomingMessages = new ConcurrentQueue<string>();

        public static event Action<string> MessageReceived;


        private static Thread receiveThread;
        private static bool isReceiving = false;

        public static bool IsConnected()
        {
            return Client != null && Client.Connected;
        }

        public static void EnqueueIncomingMessage(string msg)
        {
            IncomingMessages.Enqueue(msg);
        }

        public static void StartReceiving()
        {
            Thread receiveThread = new Thread(() =>
            {
                try
                {
                    while (Client != null && Client.Connected)
                    {
                        string line = Reader.ReadLine();
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            // Raise event to all listeners
                            MessageReceived?.Invoke(line);

                            // Still queue it if needed elsewhere
                            EnqueueIncomingMessage(line);
                        }
                    }
                }
                catch { /* Handle disconnection if needed */ }
            });

            receiveThread.IsBackground = true;
            receiveThread.Start();
        }
    }

}
