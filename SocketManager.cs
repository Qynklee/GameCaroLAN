using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CaroLAN_v2
{
    public class SocketManager
    {
        public const int PORT = 2812;
        public int BUFFER = 1024;
        public bool isHostGame;
        public string IP = "127.0.0.1";
        public Form1 form1;
        public Form2 form2;

        #region Client
        Socket client;
        public bool ConnectServer()
        {
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse(IP), PORT);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                client.Connect(ipe);
            }
            catch
            {
                return false;
            }

            //Connect Server thành công thì mở cái form Game:
            form1.Visible = false;
            form2.Listen();
            form2.sendInformation();
            form2.ShowDialog();
            return true;
        }

        #endregion

        #region Server
        Socket server;

        public bool CreateServer()
        {
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse(IP), PORT);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Bind(ipe);
                server.Listen(10);
            }
            catch (Exception)
            {
                return false;
            }
            Thread accpectClient = new Thread(() =>
            {
                client = server.Accept();
                //Client connect thành công thì mở cái form Game:
                form1.Visible = false;
                form2.Listen();
                form2.sendInformation();
                form2.ShowDialog();
            });
            accpectClient.IsBackground = true;
            accpectClient.Start();
            return true;
        }

        #endregion

        #region Both

        public byte[] SerializeData(Object o)
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf1 = new BinaryFormatter();
            bf1.Serialize(ms, o);
            return ms.ToArray();
        }

        public object DeserializeData(byte[] theByteArray)
        {
            MemoryStream ms = new MemoryStream(theByteArray);
            BinaryFormatter bf1 = new BinaryFormatter();
            ms.Position = 0;
            return bf1.Deserialize(ms);
        }

        public string GetLocalIPv4(NetworkInterfaceType _type)
        {
            string output = "";
            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (item.NetworkInterfaceType == _type && item.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            output = ip.Address.ToString();
                        }
                    }
                }
            }
            return output;
        }

        public bool SendData(Socket target, byte[] data)
        {
            return target.Send(data) == 0 ? false : true;
        }
        public bool ReceiveData(Socket target, byte[] data)
        {
            return target.Receive(data) == 0 ? false : true;
        }

        public bool Send(object data)
        {
            byte[] sendData = SerializeData(data);
            return SendData(client, sendData);
        }

        public object Receive()
        {
            byte[] receiveData = new byte[BUFFER];
            ReceiveData(client, receiveData);
            return DeserializeData(receiveData);
        }

        #endregion




        #region Init

        public SocketManager(Form1 thisform1)
        {
            this.form1 = thisform1;
        }

        #endregion



    }
}
