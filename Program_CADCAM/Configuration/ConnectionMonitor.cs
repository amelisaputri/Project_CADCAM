using System;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Threading;

namespace Program_CADCAM.Configuration
{
    internal static class ConnectionMonitor
    {
        private static System.Threading.Timer? reconnectTimer;
        private static System.Threading.Timer? pingTimer;
        private static readonly int reconnectInterval = 5000;  // 5 detik
        private static readonly int pingInterval = 30000;      // 30 detik

        public static void StartMonitoring()
        {
            reconnectTimer = new System.Threading.Timer(ReconnectIfNeeded, null, 0, reconnectInterval);
            pingTimer = new System.Threading.Timer(SendPing, null, 0, pingInterval);
        }


        public static void StopMonitoring()
        {
            reconnectTimer?.Dispose();
            pingTimer?.Dispose();
        }

        private static void ReconnectIfNeeded(object? state)
        {
            try
            {
                if (GlobalClient.Client == null || !GlobalClient.Client.Connected)
                {
                    GlobalClient.Client = new TcpClient();
                    GlobalClient.Client.Connect(Connection.IPAddress, 5000);
                    GlobalClient.Writer = new StreamWriter(GlobalClient.Client.GetStream()) { AutoFlush = true };
                    GlobalClient.Reader = new StreamReader(GlobalClient.Client.GetStream());

                    GlobalClient.Writer.WriteLine($"LOGIN|{GlobalClient.UserId}|{GlobalClient.UserName}");
                }
            }
            catch
            {
                // Optional: logging or status update
            }
        }

        private static void SendPing(object? state)
        {
            try
            {
                if (GlobalClient.Writer != null && GlobalClient.Client.Connected)
                {
                    GlobalClient.Writer.WriteLine($"PING|{GlobalClient.UserId}");
                }
            }
            catch
            {
                // Ignore ping failure; reconnect timer handles reconnection
            }
        }
    }
}
