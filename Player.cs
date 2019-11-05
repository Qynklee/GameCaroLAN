using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaroLAN_v2
{
    public class Player
    {
        public string Nickname;

        public bool isHostGame;
        
        public Player(string name, bool isHostgame)
        {
            this.Nickname = name;
            
            this.isHostGame = isHostgame;
        }
    }
}
