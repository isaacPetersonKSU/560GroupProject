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

        private SqlCommand getAllPlayers;

        public ConnectionManager(string conStr)
        {
            Connection = new SqlConnection(conStr);

            getAllPlayers = new SqlCommand("Season.usp_Players", Connection);
            getAllPlayers.CommandType = CommandType.StoredProcedure;

        }

        public DataTable Players(string sortBy, string sortDirection)
        {
            getAllPlayers.Parameters.Clear();

            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("@OrderBy", SqlDbType.VarChar);
            pr[0].Value = sortBy;
            pr[1] = new SqlParameter("Direction", SqlDbType.VarChar);
            pr[1].Value = sortDirection;

            getAllPlayers.Parameters.AddRange(pr);

            SqlDataAdapter chartFiller = new SqlDataAdapter(getAllPlayers);

            DataTable dt = new DataTable();
            chartFiller.Fill(dt);
            return dt;
        }
    }
}
