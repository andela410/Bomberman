using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman
{
    //klasa za postavljanje kontrola igrača 
    public class PlayerKeys
    {
        public String Left { get; set; }
        public String Up { get; set; }
        public String Down { get; set; }
        public String Right { get; set; }
        public String Bomb { get; set; }

        public PlayerKeys(string left, string up, string down, string right, string bomb)
        {
            Left = left;
            Up = up;
            Down = down;
            Right = right;
            Bomb = bomb;
        }
    }
}
