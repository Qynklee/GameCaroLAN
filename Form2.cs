using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaroLAN_v2
{
    public partial class Form2 : Form
    {
        public SocketManager SOCKET;
        public Form1 form1;
        public ChessBoard CHESSBOARD;

        private int player1_score = 0;
        private int player2_score = 0;

        public Form2(bool isHostGame, SocketManager socket, Form1 form1, string IP = null)
        {
            InitializeComponent();

            //Show name and turn:
            label_player1_score.Text = player1_score.ToString();
            label_player2_score.Text = player2_score.ToString();
            pictureBox_MainTurn.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_GuestTurn.SizeMode = PictureBoxSizeMode.StretchImage;
            if(isHostGame)
            {
                pictureBox_MainTurn.Image = Resource1.haveTurn;
                pictureBox_GuestTurn.Image = null;
                label_TurnFor.Text = "Your turn !";
            }
            else
            {
                pictureBox_GuestTurn.Image = Resource1.haveTurn;
                pictureBox_MainTurn.Image = null;
                label_TurnFor.Text = "Opponent turn !";
            }
            SOCKET = socket;
            this.form1 = form1;

            CHESSBOARD = new ChessBoard(this.Panel_ChessBoard, this, isHostGame);

            CHESSBOARD.BoardChecked += CHESSBOARD_BoardChecked;
            CHESSBOARD.Game_over += CHESSBOARD_Game_over;

            CHESSBOARD.DrawChessBoard();

        }

        private void CHESSBOARD_Game_over(object sender, EventArgs e)
        {
            Endgame();
        }

        private void CHESSBOARD_BoardChecked(object sender, EventArgs e)
        {
            coolDownBar.Value = 0;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SocketData Test_Data = new SocketData((int)SocketCommand.NOTIFY, new Point(), "ahaha");
            SOCKET.Send(Test_Data);
        }


        public void sendInformation()
        {
            Thread sendInforThread = new Thread(() => 
            {
                SocketData MyInfor = new SocketData((int)SocketCommand.FIRST_CONNECT, new Point(),form1.MainPlayer.Nickname.ToString());
                SOCKET.Send(MyInfor);
            });
            sendInforThread.IsBackground = true;
            sendInforThread.Start();
        }

        public void Listen()
        {
            Thread listenThread = new Thread(() =>
            {
                while (true)
                {
                    Thread.Sleep(10);
                    try
                    {
                        SocketData Dataset = (SocketData)SOCKET.Receive();
                        //MessageBox.Show(message);
                        ConvertSocketDataReceived(Dataset);
                        Listen();
                        break;
                    }
                    catch (Exception)
                    {


                    }
                }
            });
            listenThread.IsBackground = true;
            listenThread.Start();
        }

        public void Endgame()
        {
            Panel_ChessBoard.Enabled = false;
            timer1.Stop();
            if (CHESSBOARD.isTurnForMe)
            {
                MessageBoxEx.Show(this, "You looseeeeeeeee !!!");
                player2_score++;
                label_player2_score.Text = player2_score.ToString();
            }
            else
            {
                MessageBoxEx.Show(this, "You Winnnnnnnnnnn !!!");
                player1_score++;
                label_player1_score.Text = player1_score.ToString();
            }
        }


        public void ConvertSocketDataReceived(SocketData Data)
        {
            switch (Data.command)
            {
                case (int)SocketCommand.FIRST_CONNECT:
                    label_NameGuest.Text = Data.message.ToString();
                    label_NameMain.Text = form1.MainPlayer.Nickname.ToString();
                    break;
                case (int)SocketCommand.SEND_POINT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        coolDownBar.Value = 0;
                        CHESSBOARD.GuestMark(Data.point);
                    }));

                    break;
                case (int)SocketCommand.NOTIFY:
                    MessageBoxEx.Show(this, Data.message.ToString());
                    break;
                case (int)SocketCommand.NEW_GAME:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        //Reset_ProgressBar();
                        DialogResult result = MessageBoxEx.Show(this, "Your partner want to make new game, Accept?", "", MessageBoxButtons.YesNo);
                        //CHESSBOARD.NewGame();
                        if (result == DialogResult.Yes)
                        {
                            SocketData data = new SocketData((int)SocketCommand.ACCEPT, new Point());
                            SOCKET.Send(data);
                            CHESSBOARD.NewGame();
                        }
                        else
                        {
                            SocketData data = new SocketData((int)SocketCommand.IGNORE, new Point());
                            SOCKET.Send(data);
                            //MessageBoxEx.Show(this, "New game request is aborted.");
                        }
                    }));
                    break;
                case (int)SocketCommand.END_GAME:
                    break;
                case (int)SocketCommand.QUIT:
                    timer1.Stop();
                    this.Invoke((MethodInvoker)(() =>
                    {
                        DialogResult result2 = MessageBoxEx.Show(this, "Opponent left the game. Do you want to quit?", "", MessageBoxButtons.YesNo);
                        if (result2 == DialogResult.Yes)
                        {
                            Close();
                        }
                    }));
                    break;
                case (int)SocketCommand.ACCEPT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        CHESSBOARD.NewGame();
                        MessageBoxEx.Show(this, "Your partner accepted new game request");
                        Text = "Caro Game";
                    }));
                    break;
                case (int)SocketCommand.IGNORE:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        MessageBoxEx.Show(this, "Your partner ignored new game request");
                        Text = "Caro Game";
                    }));
                    break;
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Close();
            SocketData socDat = new SocketData((int)SocketCommand.QUIT, new Point());
            SOCKET.Send(socDat);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            coolDownBar.PerformStep();
            if (coolDownBar.Value == coolDownBar.Maximum)
            {
                Endgame();
            }
        }

        public void Reset_ProgressBar()
        {
            timer1.Stop();
            coolDownBar.Value = 0;
        }

        private void NewMatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            //CHESSBOARD.NewGame();
            SocketData data = new SocketData((int)SocketCommand.NEW_GAME, new Point());
            SOCKET.Send(data);
            //MessageBoxEx.Show(this, "Waitting for respond ...");
            Text = "Caro Game (Waitting for new game respond ...)";
        }

        private void QuitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBoxEx.Show(this, "Do you really want to quit ?","Quit Game",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                form1.Close();
                SocketData socDat = new SocketData((int)SocketCommand.QUIT, new Point());
                SOCKET.Send(socDat);
            }
            else
            {
                return;
            }
        }

        private void AboutCaroGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxEx.Show(this, Resource1.Gamerule, "Game Rules");
        }

        private void AboutDevTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxEx.Show(this, Resource1.About_DevTeam, "About");
        }
    }
}
