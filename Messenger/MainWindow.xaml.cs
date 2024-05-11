using Messenger.Properties;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Messenger
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            if (Name.Text != "")
            {
                TcpServer.name = Name.Text.ToString();
                ServerWindow serverWindow = new ServerWindow();
                serverWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Заполните имя пользователя!");
            }
        }

        private void Connect_Click(object sender, RoutedEventArgs e)
        {
            if (Name.Text != "" && IP.Text != "")
            {
                if (IsValidIP(IP.Text))
                {
                    TcpClient.ip = IP.Text.ToString();
                    TcpClient.name = Name.Text.ToString();
                    ClientWindow clientWindow = new ClientWindow();
                    clientWindow.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Некорректный формат IP-адреса!");
                }
            }
            else
            {
                MessageBox.Show("Имя пользователя и ip-адрес должны быть заполнены!");
            }
        }

        private bool IsValidIP(string ipString)
        {
            IPAddress ip;
            return IPAddress.TryParse(ipString, out ip);
        }

    }
}