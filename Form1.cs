using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaroLAN_v2
{
    public partial class Form1 : Form
    {
        //Form 1 thực hiện create and connect server:

        public SocketManager SOCKET;
        public bool haveAvatar;


        public Player MainPlayer;
        public Player GuestPlayer;
        
        public Form1()
        {
            InitializeComponent();
            SOCKET = new SocketManager(this);
            haveAvatar = false;

            string IPlocal = SOCKET.GetLocalIPv4(NetworkInterfaceType.Wireless80211);

            if (IPlocal == null || IPlocal == "")
            {
                IPlocal = SOCKET.GetLocalIPv4(NetworkInterfaceType.Ethernet);
            }
            if (IPlocal == null || IPlocal == "")
            {
                IPlocal = "No Internet";
            }
            IP_input.Text = IPlocal;
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && IP_input.Text != "")
            {
                BlankName_label.Visible = false;

                string IP = IP_input.Text;
                SOCKET.IP = IP;

                MainPlayer = new Player(textBox1.Text, false);

                Form2 Game = new Form2(false, SOCKET, this, IP);

                SOCKET.form2 = Game;
                Game.MainICON.Image = Resource1.ooo;
                Game.GuestICON.Image = Resource1.xxx;
                Game.GuestICON.SizeMode = PictureBoxSizeMode.StretchImage;
                Game.MainICON.SizeMode = PictureBoxSizeMode.StretchImage;
            
                bool Checked = SOCKET.ConnectServer();
                if (!Checked)//Connect unsuccess
                {
                    MessageBox.Show("Can't connect to Server");
                    Visible = true;
                    return;
                }
            }
            else
            {
                BlankName_label.Visible = true;
                return;
            }

        }

        private void btn_HostGame_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                BlankName_label.Visible = false;

                SOCKET.IP = IP_input.Text;
                MainPlayer = new Player(textBox1.Text, true);
                Form2 Game = new Form2(true, SOCKET, this);
                SOCKET.form2 = Game;

                Game.MainICON.Image = Resource1.xxx;
                Game.GuestICON.Image = Resource1.ooo;
                Game.GuestICON.SizeMode = PictureBoxSizeMode.StretchImage;
                Game.MainICON.SizeMode = PictureBoxSizeMode.StretchImage;


                bool Checked = SOCKET.CreateServer();
                if (!Checked)
                {
                    MessageBox.Show("Can't Create Server");
                    return;
                }
                else
                {
                    btn_HostGame.Text = "Server is created";
                    btn_HostGame.Enabled = false;
                }
            }
            else
            {
                BlankName_label.Visible = true;
                return;
            }


        }

    }
}
