using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Messenger
{
    internal class TcpClient
    {
        public static string ip;
        public static string name;
        public static Socket server;

        public static void Client()
        {
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Connect(ip, 8888);
            SendName(name);
        }

        private static async Task SendName(string name)
        {
            byte[] bytes = Encoding.UTF8.GetBytes($"0[{name}]");
            await server.SendAsync(bytes, SocketFlags.None);
        }
        public static async Task SendMessage(string message)
        {
            byte[] bytes = Encoding.UTF8.GetBytes($"1{message}");
            await server.SendAsync(bytes, SocketFlags.None);
        }
    }
}
