using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaroLAN_v2
{
    public class ChessBoard
    {
        public Panel CHESSBOARD;
        public Form2 form2;
        public List<List<Button>> matrix;
        public bool isHostGame;
        public bool isTurnForMe;
        public SocketManager SOCKET;
        public const int ChieuNgangBanCo = 28;
        public const int ChieuCaoBanCo = 25;
        public const int SoQuanDeThang = 5;

        private event EventHandler boardChecked;
        public event EventHandler BoardChecked
        {
            add
            {
                boardChecked += value;
            }
            remove
            {
                boardChecked -= value;
            }
        }

        private event EventHandler game_over;
        public event EventHandler Game_over
        {
            add
            {
                game_over += value;
            }
            remove
            {
                game_over -= value;
            }
        }

        public ChessBoard(Panel chessboard, Form2 thisform2, bool isHostGame)
        {
            this.CHESSBOARD = chessboard;
            this.form2 = thisform2;
            this.isHostGame = isHostGame;
            this.isTurnForMe = isHostGame;
            this.SOCKET = form2.SOCKET;
        }

        #region Method

        public void DrawChessBoard()
        {
            CHESSBOARD.Controls.Clear();
            CHESSBOARD.Enabled = true;

            matrix = new List<List<Button>>();
            for (int i = 0; i < ChieuNgangBanCo; i++) //28 hàng ngang
            {
                matrix.Add(new List<Button>());

                for (int j = 0; j < ChieuCaoBanCo; j++)
                {
                    Button btn = new Button()
                    {
                        Height = 25,
                        Width = 25,
                        Location = new Point(i * 25, j * 25),
                        Tag = i.ToString()
                    };

                    CHESSBOARD.Controls.Add(btn);
                    matrix[i].Add(btn);
                    btn.Click += Btn_Click;
                }
            }
            //if (!isTurnForMe)
            //{
            //    CHESSBOARD.Enabled = false;
            //}
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackgroundImage == null && isTurnForMe)
            {
                Point point = GetPotion(btn);
                if (isHostGame)
                {
                    btn.BackgroundImage = Resource1.X;
                    btn.ImageKey = "X";
                }
                else
                {
                    btn.BackgroundImage = Resource1.O;
                    btn.ImageKey = "O";
                }
                ChangeTurn();
                SocketData Mark_data = new SocketData((int)SocketCommand.SEND_POINT, point);
                SOCKET.Send(Mark_data);

                boardChecked?.Invoke(this, new EventArgs());

                if (isEndGame(btn))
                {
                    EndGame();
                }
            }
            else
            {
                return;
            }
        }

        #endregion

        void ChangeTurn()
        {
            isTurnForMe = !isTurnForMe;
            //CHESSBOARD.Enabled = isTurnForMe;

        }

        public Point GetPotion(Button button)
        {
            Point point = new Point();
            point.X = Convert.ToInt32(button.Tag.ToString());
            point.Y = matrix[point.X].IndexOf(button);
            return point;
        }

        public void GuestMark(Point point)
        {
            if (isHostGame) //kiểm tra xem mình là gì? Host là X; => Gúet O
            {
                matrix[point.X][point.Y].BackgroundImage = Resource1.O;
                matrix[point.X][point.Y].ImageKey = "O";
            }
            else
            {
                matrix[point.X][point.Y].BackgroundImage = Resource1.X;
                matrix[point.X][point.Y].ImageKey = "X";
            }
            ChangeTurn();

            boardChecked?.Invoke(this, new EventArgs());

            if (isEndGame(matrix[point.X][point.Y]))
            {
                EndGame();
            }
        }

        public void EndGame()
        {
            //if(isTurnForMe)
            //{
            //    if(MessageBox.Show("You looseeeeeeeee !!!","",MessageBoxButtons.OK) == DialogResult.OK)
            //    {
            //        //NewGame();
            //    }
            //}
            //else
            //{
            //    if(MessageBox.Show("You Winnnnnnnnnnn !!!","",MessageBoxButtons.OK) == DialogResult.OK)
            //    {
            //        //NewGame();
            //    }
            //}
            game_over?.Invoke(this, new EventArgs());
        }

        public void NewGame()
        {
            form2.Reset_ProgressBar();
            DrawChessBoard();

        }

        #region CheckWinLose

        bool isEndGame(Button btn)
        {
            return isEndHorizontal(btn) || isEndPrimaryDiagonal(btn) ||
                isEndVertical(btn) || isEndSubDiagonal(btn);
        }

        bool isEndHorizontal(Button btn)
        {
            Point point = GetPotion(btn);
            int countL = 0;
            int countR = 0;

            //[0,X]
            int temp;
            if (point.X > 0)
            {
                temp = point.X - 1;
                while (matrix[temp][point.Y].ImageKey == btn.ImageKey)
                {
                    temp--;
                    countL++;
                    if (temp < 0)
                        break;
                }
            }
            if (point.X < ChieuNgangBanCo - 1)
            {
                temp = point.X + 1;
                while (matrix[temp][point.Y].ImageKey == btn.ImageKey)
                {
                    temp++;
                    countR++;
                    if (temp >=ChieuNgangBanCo)
                        break;
                }
            }
            if(countL + countR >= SoQuanDeThang -1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        bool isEndVertical(Button btn)
        {

            Point point = GetPotion(btn);
            int countU = 0;
            int countD = 0;

            //[0,Y]
            int temp;
            if (point.Y > 0)
            {
                temp = point.Y - 1;
                while (matrix[point.X][temp].ImageKey == btn.ImageKey)
                {
                    temp--;
                    countU++;
                    if (temp < 0)
                        break;
                }
            }

            //down:
            if (point.Y < ChieuCaoBanCo - 1)
            {
                temp = point.Y + 1;
                while (matrix[point.X][temp].ImageKey == btn.ImageKey)
                {
                    temp++;
                    countD++;
                    if (temp >= ChieuCaoBanCo)
                        break;
                }
            }

            if (countU + countD >= (SoQuanDeThang - 1)) //Chua tinh cai point
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        bool isEndPrimaryDiagonal(Button btn)
        {
            Point point = GetPotion(btn);
            int toadoX = point.X;
            int toadoY = point.Y;

            //Len:
            int countLen = 0;
            int tempX = toadoX - 1;
            int tempY = toadoY - 1;
            if (toadoX > 0 && toadoY > 0)
            {
                while (matrix[tempX][tempY].ImageKey == btn.ImageKey)
                {
                    countLen++;
                    tempX--;
                    tempY--;
                    if (tempX < 0 || tempY < 0)
                    {
                        break;
                    }
                }
            }
            //Xuong:
            int countXuong = 0;
            tempX = toadoX + 1;
            tempY = toadoY + 1;
            if (toadoX <ChieuNgangBanCo - 1 && toadoY < ChieuCaoBanCo - 1)
            {
                while (matrix[tempX][tempY].ImageKey == btn.ImageKey)
                {
                    countXuong++;
                    tempX++;
                    tempY++;
                    if (tempX >= ChieuNgangBanCo || tempY >= ChieuCaoBanCo)
                    {
                        break;
                    }
                }
            }
            if (countXuong + countLen >= SoQuanDeThang - 1)
            {
                return true;
            }
            else
                return false;

        }

        bool isEndSubDiagonal(Button btn)
        {
            Point point = GetPotion(btn);

            int toadoX = point.X;
            int toadoY = point.Y;

            //Len:
            int tempX = toadoX + 1;
            int tempY = toadoY - 1;
            int countLen = 0;
            if (toadoX < ChieuNgangBanCo - 1 && toadoY > 0)
            {
                while (matrix[tempX][tempY].ImageKey == btn.ImageKey)
                {
                    countLen++;
                    tempX++;
                    tempY--;
                    if (tempX >= ChieuNgangBanCo || tempY < 0)
                    {
                        break;
                    }
                }
            }

            //Xuong:
            tempX = toadoX - 1;
            tempY = toadoY + 1;
            int countXuong = 0;
            if (toadoX > 0 && toadoY < ChieuCaoBanCo - 1)
            {
                while (matrix[tempX][tempY].ImageKey == btn.ImageKey)
                {
                    countXuong++;
                    tempX--;
                    tempY++;
                    if (tempX < 0 || tempY >= ChieuCaoBanCo)
                    {
                        break;
                    }
                }
            }

            if (countLen + countXuong >= SoQuanDeThang - 1)
            {
                return true;
            }
            else
                return false;

        }

        #endregion

    }
}
