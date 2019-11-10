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

        public bool isHostGame;
        private bool isMessageOpened;

        private int player1_score = 0;
        private int player2_score = 0;

        public Form2(bool isHostGame, SocketManager socket, Form1 form1, string IP = null)
        {
            InitializeComponent();

            // set button text to right arrow
            button_expand.BackgroundImage = Resource1.open;

            isMessageOpened = false;

            richTextBox_message.BackColor = Color.White;

            Size = new Size(750, this.Height);

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
            this.isHostGame = isHostGame;
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
                        
                        ConvertSocketDataReceived(Dataset);
                        
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
                    this.Invoke((MethodInvoker)(() =>
                    {
                        //richtextbox:
                        int pos_Start = richTextBox_message.TextLength;
                        int name_length = label_NameGuest.Text.Length;
                        richTextBox_message.AppendText(label_NameGuest.Text + ": ");
                        richTextBox_message.Select(pos_Start, name_length + 2);
                        richTextBox_message.SelectionColor = (isHostGame) ? Color.Blue : Color.Red;
                        richTextBox_message.AppendText(Data.message + Environment.NewLine+Environment.NewLine);
                        richTextBox_message.Select(name_length + pos_Start + 2, richTextBox_message.TextLength);
                        richTextBox_message.SelectionColor = Color.Black;
                        richTextBox_message.ScrollToCaret();
                    }));
                    
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
                            System.Environment.Exit(1);
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

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBoxEx.Show(this, "Do you really want to quit ?", "Quit Game", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                form1.Close();
                SocketData socDat = new SocketData((int)SocketCommand.QUIT, new Point());
                SOCKET.Send(socDat);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void timer_Message_Tick(object sender, EventArgs e)
        {
            if (this.Width < 1100 && !isMessageOpened)
            {
                Size = new Size(this.Width + 5, this.Height);
            }
            else if (!isMessageOpened)
            {
                timer_Message.Stop();
                isMessageOpened = true;
                button_expand.BackgroundImage = Resource1.close;
                panel_cover.Visible = false;
            }

            if (this.Width > 750 && isMessageOpened)
            {
                panel_cover.Visible = true;
                Size = new Size(this.Width - 5, this.Height);
            }
            else if (isMessageOpened)
            {
                timer_Message.Stop();
                isMessageOpened = false;
                button_expand.BackgroundImage = Resource1.open;
            }

        }

        private void textBox_Type_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_send_Click(this, new EventArgs());
                e.SuppressKeyPress = true;
            }

        }

        private void button_send_Click(object sender, EventArgs e)
        {
            if (textBox_Type.Text != "" || textBox_Type.Text != null)
            {
                //Show color with RichTextBox
                int pos_Start = richTextBox_message.TextLength;
                int name_length = label_NameMain.Text.Length;
                richTextBox_message.AppendText(label_NameMain.Text + ": ");
                richTextBox_message.Select(pos_Start, name_length + 2);
                richTextBox_message.SelectionColor = (isHostGame) ? Color.Red : Color.Blue;
                richTextBox_message.AppendText(textBox_Type.Text + Environment.NewLine+Environment.NewLine);
                richTextBox_message.Select(name_length + pos_Start + 2, richTextBox_message.TextLength);
                richTextBox_message.SelectionColor = Color.Black;
                richTextBox_message.ScrollToCaret();

                //send message:
                SocketData socdat = new SocketData((int)SocketCommand.NOTIFY, new Point(), textBox_Type.Text);
                SOCKET.Send(socdat);
                //clear:
                textBox_Type.Text = "";
            }
        }

        private void button_expand_Click(object sender, EventArgs e)
        {
            timer_Message.Start();
            this.ActiveControl = textBox_Type;
        }


        private void richTextBox_message_TextChanged(object sender, EventArgs e)
        {
            if (!isMessageOpened)
                button_expand.PerformClick();
        }
    }
}
