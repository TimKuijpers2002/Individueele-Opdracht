using System;
using System_DAL;
using System_Interfaces;

namespace System_Logic
{
    public class GameLogic
    {
        DataBaseConnectionHandler DBObj = new DataBaseConnectionHandler();
        public object RecieveGames()
        {
            return DBObj.GetAllSharedGames();
        }

        public object RecieveTeams()
        {
            return DBObj.GetAllTeams();
        }
    }
}
