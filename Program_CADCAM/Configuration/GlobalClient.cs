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

        public static bool IsConnected()
        {
            return Client != null && Client.Connected;
        }

        public static void EnqueueIncomingMessage(string msg)
        {
            IncomingMessages.Enqueue(msg);
        }

        public static void Disconnect()
        {
            try
            {
                Writer?.WriteLine("LOGOUT|");
                Client?.Close();
            }
            catch
            {
                // ignored
            }
            Client = null;
            Writer = null;
            Reader = null;
            UserId = null;
            UserName = null;
        }
    }
}
