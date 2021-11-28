﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GroupProject
{
    public class ConnectionManager
    {
        public SqlConnection Connection { get; private set; }

        private SqlCommand getTouchdownLeaders;
        private SqlCommand searchByPlayerName;
        private SqlCommand searchByTeamName;
        private SqlCommand getAllGames;
        private SqlCommand getPlayerInfo;

        public ConnectionManager(string conStr)
        {
            Connection = new SqlConnection(conStr);

            getTouchdownLeaders = new SqlCommand(@"Season.usp_TouchdownLeaders", Connection);
            getTouchdownLeaders.CommandType = CommandType.StoredProcedure;

            searchByPlayerName = new SqlCommand(@"Season.usp_SearchPlayers", Connection);
            searchByPlayerName.CommandType = CommandType.StoredProcedure;

            searchByTeamName = new SqlCommand(@"Season.usp_SearchTeams", Connection);
            searchByTeamName.CommandType = CommandType.StoredProcedure;

            getAllGames = new SqlCommand(@"Season.usp_SearchGames", Connection);
            getAllGames.CommandType = CommandType.StoredProcedure;

            getPlayerInfo = new SqlCommand(@"Season.usp_PlayerByID", Connection);
            getPlayerInfo.CommandType = CommandType.StoredProcedure;
        }

        public DataTable TouchDownLeaders(string sortBy)
        {
            getTouchdownLeaders.Parameters.Clear();

            SqlParameter pr = new SqlParameter("@OrderBy", SqlDbType.VarChar);
            pr.Value = sortBy;

            getTouchdownLeaders.Parameters.Add(pr);

            SqlDataAdapter chartFiller = new SqlDataAdapter(getTouchdownLeaders);

            DataTable dt = new DataTable();
            chartFiller.Fill(dt);
            return dt;
        }

        public DataTable SearchPlayerName(string name)
        {
            searchByPlayerName.Parameters.Clear();

            SqlParameter pr = new SqlParameter("@name", SqlDbType.VarChar);
            pr.Value = name;

            searchByPlayerName.Parameters.Add(pr);

            SqlDataAdapter chartFiller = new SqlDataAdapter(searchByPlayerName);

            DataTable dt = new DataTable();
            chartFiller.Fill(dt);
            return dt;
        }

        public DataTable SearchTeamName(string name)
        {
            searchByTeamName.Parameters.Clear();

            SqlParameter pr = new SqlParameter("@name", SqlDbType.VarChar);
            pr.Value = name;

            searchByTeamName.Parameters.Add(pr);

            SqlDataAdapter chartFiller = new SqlDataAdapter(searchByTeamName);

            DataTable dt = new DataTable();
            chartFiller.Fill(dt);
            return dt;
        }

        public DataTable AllGames(DateTime start, DateTime end)
        {
            getAllGames.Parameters.Clear();
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("@StartDate", SqlDbType.Date);
            pr[0].Value = start.ToString();
            pr[1] = new SqlParameter("@EndDate", SqlDbType.Date);
            pr[1].Value = end.ToString();

            getAllGames.Parameters.AddRange(pr);
            SqlDataAdapter chartFiller = new SqlDataAdapter(getAllGames);

            DataTable dt = new DataTable();
            chartFiller.Fill(dt);
            return dt;
        }

        public string PlayerString(int playerID)
        {
            getPlayerInfo.Parameters.Clear();
            SqlParameter pr = new SqlParameter("@PlayerID", SqlDbType.Int);
            pr.Value = playerID;
            getPlayerInfo.Parameters.Add(pr);

            SqlDataAdapter chartFiller = new SqlDataAdapter(getPlayerInfo);
            DataTable dt = new DataTable();
            
            chartFiller.Fill(dt);
            object[] info = dt.Rows[0].ItemArray;
            string s = info[0] + " : " + info[2] + " " + info[3];

            return s;
        }
    }
}
