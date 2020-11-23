using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaskBallDB
{
    public class Player
    {
        public int PlayerID { get; set;}

        public string PlayerName { get; set;}

        public bool Is_Injuried { get; set; }

        public int Points { get; set; }

        public int Steals { get; set; }

        public int Rebounds { get; set; }

        public int Blocks { get; set; }

        public int Assists { get; set; }

        public int TeamID { get; set; }
        
    }
}
