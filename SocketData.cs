using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaroLAN_v2
{
    [Serializable]
    public class SocketData
    {
        public int command;
        public string message;
        public Point point;

        public SocketData(int cmd, Point point, string message = null)
        {
            this.command = cmd;
            this.message = message;
            this.point = point;
        }
       

    }


    public enum SocketCommand
    {
        FIRST_CONNECT,
        SEND_POINT,
        NOTIFY,
        NEW_GAME,
        END_GAME,
        QUIT,
        ACCEPT,
        IGNORE
    }
}
