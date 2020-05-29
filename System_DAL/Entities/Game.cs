using System;
using System.Collections.Generic;
using System.Text;
using System_Interfaces;

namespace System_DAL.Entities
{
    public class Game : IShareGame
    {
        public int game_id { get; set; }
        public int team_id { get; set; }
    }
}
