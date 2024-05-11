using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Messenger
{
    public partial class ClientWindow : Window
    {
        private CancellationTokenSource isWorking;
        public ClientWindow()
        {
            InitializeComponent();

            TcpClient.Client();
            isWorking = new CancellationTokenSource();
            ReceiveMessage(isWorking.Token);
        }

        private async Task ReceiveMessage(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                byte[] bytes = new byte[1024];
                await TcpClient.server.ReceiveAsync(bytes, SocketFlags.None);
                string message = Encoding.UTF8.GetString(bytes);
                int action = Convert.ToInt32(message.Substring(0, 1));
                message = message.Substring(1, message.Length - 1);
                switch (action)
                {
                    case 1:
                        MessageListView.Items.Add(message);
                        break;
                    case 2:
                        UsersList.Items.Clear();
                        string[] userList = message.Split(';');
                        foreach (string user in userList)
                        {
                            UsersList.Items.Add(user);
                        }
                        break;
                }
            }
        }

        private void Send_Click(object sender, RoutedEventArgs e)
        {
            if (Message.Text == "/disconnect")
            {
                ExitAction();
            }
            else
            {
                if (Message.Text != "")
                {
                    TcpClient.SendMessage($"[{DateTime.Now}] [{TcpClient.name}]: {Message.Text}");
                    Message.Text = "";
                }
                else
                {
                    MessageBox.Show("Введите сообщение!");
                }
            }
        }


        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            ExitAction();
        }


        private void ExitAction()
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            isWorking.Cancel();
            TcpClient.server.Close();
            this.Close();
        }
    }
}