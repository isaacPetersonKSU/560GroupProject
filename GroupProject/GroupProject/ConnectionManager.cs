using System;
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

        public ConnectionManager(string conStr)
        {
            Connection = new SqlConnection(conStr);

            getTouchdownLeaders = new SqlCommand("Season.usp_TouchdownLeaders", Connection);
            getTouchdownLeaders.CommandType = CommandType.StoredProcedure;

            searchByPlayerName = new SqlCommand("Season.usp_SearchPlayers", Connection);
            searchByPlayerName.CommandType = CommandType.StoredProcedure;

            searchByTeamName = new SqlCommand("Season.usp_SearchTeams", Connection);
            searchByTeamName.CommandType = CommandType.StoredProcedure;
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
    }
}
