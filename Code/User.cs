﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaskBallDB
{
    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public int userID { get; set; }
        public bool isAdmin { get; set; }
        public string leagueName { get; set; }
        public int teamID { get; set; }
    }
}
