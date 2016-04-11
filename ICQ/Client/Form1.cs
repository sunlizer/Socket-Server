using ServerData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public static Form1 thisForm;
        bool isConnected = false;
        public Form1()
        {
            InitializeComponent();
            thisForm = this;
        }

        private static void addNewUser(string text)
        {

            thisForm.Invoke((MethodInvoker)delegate
            {
                thisForm.UserBox.Items.Add(text);
                thisForm.SendTO.Items.Add(text);
            });
        }
        private static void addToChat(string text)
        {

            thisForm.Invoke((MethodInvoker)delegate
            {
                thisForm.ChatBox.Items.Add(text);
            });
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!isConnected && NameBox.Text!=null && Int32.TryParse(portText.Text,out port))
            {
                SendTO.Visible = true;
                portText.Visible = false;
                portNumber.Visible = false;
                chatText.Visible = true;
                button1.Text = "Send";
                isConnected = true;
                NameBox.Visible = false;
                nameLabel.Visible = false;
                name = NameBox.Text;
                master = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);
                try
                {
                    master.Connect(ipe);
                }
                catch
                {
                    MessageBox.Show("Could not connect to server");
                    this.Close();
                }
                Thread t = new Thread(data_IN);
                t.Start();
                login();
            }
            else if(isConnected)
            {
                
                if(SendTO.SelectedIndex<0)
                {
                    Packet p = new Packet(PacketType.chat, id);
                    p.message = name +">"+chatText.Text;
                    master.Send(p.toBytes());
                }
                else
                {
                    Packet p = new Packet(PacketType.privateChat, id);
                    p.message = this.SendTO.SelectedItem.ToString()+">"+chatText.Text;
                    p.senderName = name;
                    master.Send(p.toBytes());
                }
                chatText.Clear();
                SendTO.SelectedItem = -1;
            }
            else
            {
                MessageBox.Show("you must fill the boxes below ");
            }
        }
        int port;
        public static Socket master;
        public static string name;
        public static string id;

        /*static void Main(string[] args)
        {
            name = Console.ReadLine();

             A: Console.Clear();
            // Console.WriteLine("Gimme ip");
            string ip = "127.0.0.1";//Console.ReadLine();

            master = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse(ip), 4242);

            try
            {
                master.Connect(ipe);
            }
            catch
            {
                Console.WriteLine("Could not connect to server");
                Thread.Sleep(1000);
                goto A;
            }

            Thread t = new Thread(data_IN);
            t.Start();
            login();
            while(true)
            {
                Console.Write("::>");
                string input = Console.ReadLine();

                Packet p = new Packet(PacketType.chat, id);
                p.message = input;
                master.Send(p.toBytes());
            }
        }
        */
        private static void login()
        {
            Packet p = new Packet(PacketType.login, name);
            p.message = name;
            master.Send(p.toBytes());
        }

        static void data_IN()//serverdaki incoming datanın aynısı
        {
            byte[] buffer;
            int readBytes;

            while(true)
            {
                try
                {
                    buffer = new byte[master.SendBufferSize];
                    readBytes = master.Receive(buffer);

                    if (readBytes > 0)
                    {
                        DataManager(new Packet(buffer));
                    }
                }
                catch (SocketException ex)
                {
                    Console.WriteLine("Server Lost!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }

        }

        static void DataManager(Packet p)
        {
            switch (p.packetType)
            {

                case PacketType.Registration:
                    addToChat("connected the server");
                    string[] usersdata = p.message.Split('#');
                    id = usersdata[0];
                    for (int i = 1; i < usersdata.Length ; i++)
                    {
                        addNewUser(usersdata[i]);
                    }
                    break;
                case PacketType.chat:
                    addToChat(p.message);
                    break;
                case PacketType.privateChat:
                    addToChat(p.senderName+">"+ p.message.Split('>')[1]);
                    break;
                case PacketType.login:
                    addNewUser(p.message);
                    break;
            }
        }
        
    }
}
