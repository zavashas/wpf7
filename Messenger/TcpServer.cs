using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Messenger
{
    internal class TcpServer
    {
        public static Socket socket;
        public static string name;
        public static Dictionary<Socket, string> clients = new Dictionary<Socket, string>();
        public static List<string> logList = new List<string>();

        public static void Server()
        {
            IPEndPoint ipPoint = new IPEndPoint(IPAddress.Any, 8888);
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(ipPoint);
            socket.Listen(1000);
            clients.Add(socket, $"[{name}]");
            logList.Add($"[{DateTime.Now}] \nНовый пользователь: [{name}] ");
        }

        public static async Task SendMessage(Socket client, string message)
        {
            byte[] bytes = Encoding.UTF8.GetBytes($"1{message}");
            await client.SendAsync(bytes, SocketFlags.None);
        }

        public static async Task SendUsers(Socket client, string allUsers)
        {
            byte[] bytes = Encoding.UTF8.GetBytes($"2{allUsers}");
            await client.SendAsync(bytes, SocketFlags.None);
        }
    }
}