using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System_DAL.Entities;
using System_Interfaces;


namespace System_DAL
{
    public class DataBaseConnectionHandler : IDataBaseConnectionHandler
    {
        private string dataConnectionString = @"Data Source=LAPTOP-4O72ESA4\SQLEXPRESS;Initial Catalog=BeginnerDB;Integrated Security=True";

        public List<IShareGame> GetAllSharedGames()
        {
            List<IShareGame> games = new List<IShareGame>();
            using (SqlConnection conn = new SqlConnection(dataConnectionString))
            {
                using (SqlCommand query = new SqlCommand("SELECT * FROM share_game"))
                {
                    conn.Open();
                    var reader = query.ExecuteReader();
                    while(reader.Read())
                    {
                        Game game = new Game();
                        game.game_id = reader.GetInt32(1);
                        game.team_id = reader.GetInt32(2);

                        games.Add(game);
                    }
                }

                return games;
            }
        }

        public List<ITeam> GetAllTeams()
        {
            List<ITeam> teams = new List<ITeam>();
            using (SqlConnection conn = new SqlConnection(dataConnectionString))
            {
                using (SqlCommand query = new SqlCommand("SELECT * FROM team"))
                {
                    conn.Open();
                    var reader = query.ExecuteReader();
                    while (reader.Read())
                    {
                        Team team = new Team();
                        team.team_id = reader.GetInt32(1);

                        teams.Add(team);
                    }
                }

                return teams;
            }

        }
    }
}
