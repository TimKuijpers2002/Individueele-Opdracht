using System;
using System.Collections.Generic;
using System.Text;

namespace System_Interfaces
{
    public interface IDataBaseConnectionHandler
    {
        List<IShareGame> GetAllSharedGames();

        List<ITeam> GetAllTeams();
    }
}
